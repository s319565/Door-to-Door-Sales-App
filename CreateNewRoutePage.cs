using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Door_to_Door_Sales_App.Repository;

namespace Door_to_Door_Sales_App
{
    public partial class CreateNewRoutePage : Form
    {
        private readonly DoorToDoorRepository _repository;
        public CreateNewRoutePage()
        {
            InitializeComponent();
            _repository = new DoorToDoorRepository();
        }
        private void CreateNewRoutePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            this.LoadDataGridView();
            this.txtRouteName.Text = string.Empty;
            this.txtRouteNotes.Text = string.Empty;
        }
        private void LoadDataGridView()
        {
            var routes = _repository.GetAllRoutes();
            this.dgvRoutes.DataSource = routes;

            // Optional: Rename columns for a clearer display
            this.dgvRoutes.Columns["RouteID"].HeaderText = "Route ID";
            this.dgvRoutes.Columns["routeName"].HeaderText = "Route Name";
            this.dgvRoutes.Columns["RouteNotes"].HeaderText = "Route Notes";
        }
       

        private void Thread()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new HomePage());
        }

        private void btnCreateRoute_Click(object sender, EventArgs e)
        {
            DoorToDoorRoutes route = new DoorToDoorRoutes();

            route.routeName = this.txtRouteName.Text.Trim();
            route.RouteNotes = this.txtRouteNotes.Text.Trim();
            _repository.AddRoute(route);
            

            //Added
            MessageBox.Show("Successfully added Route.");
            this.SetControls();

            ;//Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(Thread));
            t.Start();
        }


    }
}
