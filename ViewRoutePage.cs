using Door_to_Door_Sales_App.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Door_to_Door_Sales_App
{

    public partial class ViewRoutePage : Form
    {
        private readonly DoorToDoorRepository _repository;
        private readonly DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
        public static DoorToDoorRoutes route = new DoorToDoorRoutes();
        public ViewRoutePage()
        {
            InitializeComponent();
            _repository = new DoorToDoorRepository();
        }

        private void ViewRoutePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            txtRouteName.Text = route.routeName;
            txtRouteNotes.Text = route.RouteNotes;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            var houses = _repository.GetRoutesHouses(route.RouteID);
            this.dgvHouses.DataSource = houses;

            // Optional: Rename columns for a clearer display
            this.dgvHouses.Columns["HouseID"].HeaderText = "House ID";
            this.dgvHouses.Columns["RouteID"].HeaderText = "Route ID";
            this.dgvHouses.Columns["HouseAddress"].HeaderText = "House Address";
            this.dgvHouses.Columns["HouseNotes"].HeaderText = "House Notes";
            addButtonColumn();
            dgvHouses.Columns.Add(btn);
        }
        private void addButtonColumn()
        {
            btn.HeaderText = "Click to View House";
            btn.Text = "View House";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }

        private void dgvHouses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int houseID = Convert.ToInt32(dgvHouses.Rows[e.RowIndex].Cells[0].Value);
                Houses house = _repository.GetHouseByID(houseID);



                ViewHousePage viewHousePage = new ViewHousePage();
                ViewHousePage.house = house;

                this.Close();
                //Create a thread to RUN a NEW application with the desired form
                Thread t = new Thread(new ThreadStart(Thread3));
                t.Start();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(Thread));
            t.Start();
        }
        private void Thread()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new HomePage());
        }

        private void btnAddHouse_Click(object sender, EventArgs e)
        {
            this.Close();
            //Create a thread to RUN a NEW application with the desired form

            AddHousePage addHousePage = new AddHousePage();
            AddHousePage.route = route;
            
            Thread t = new Thread(new ThreadStart(Thread2));
            t.Start();
        }
        private void Thread2()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new AddHousePage());
        }
        private void Thread3()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new ViewHousePage());
        }
    }
}
