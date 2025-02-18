using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class HomePage : Form
    {

        private readonly DoorToDoorRepository _repository;
        public HomePage()
        {
            InitializeComponent();
            _repository = new DoorToDoorRepository();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            this.LoadDataGridView();
            

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
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(Thread));
            t.Start();
        }

        private void Thread()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new LoginPage());
        }

        private void btnCreateRoute_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(Thread2));
            t.Start();
           
        }

        private void Thread2()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new CreateNewRoutePage());
        }

        private void txtRouteName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

