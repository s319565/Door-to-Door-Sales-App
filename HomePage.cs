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
using System.Data.Odbc;

namespace Door_to_Door_Sales_App
{
    public partial class HomePage : Form
    {

        private readonly DoorToDoorRepository _repository;
        private readonly DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
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
            addButtonColumn();
            dgvRoutes.Columns.Add(btn);
        }

        private void addButtonColumn()
        {
            btn.HeaderText = "Click to View Route";
            btn.Text = "View Route";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
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

        private void Thread3()
        {
           //RUNs a NEW application with the desired form
            Application.Run(new ViewRoutePage());
        }

        private void txtRouteName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvRoutes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int routeID = Convert.ToInt32(dgvRoutes.Rows[e.RowIndex].Cells[0].Value);
                DoorToDoorRoutes route = _repository.GetRouteById(routeID);

                
                
                ViewRoutePage viewRoutePage = new ViewRoutePage();
                ViewRoutePage.route = route;

                this.Close();
                //Create a thread to RUN a NEW application with the desired form
                Thread t = new Thread(new ThreadStart(Thread3));
                t.Start();
            }
        }
    }
}

