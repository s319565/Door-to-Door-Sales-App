using Door_to_Door_Sales_App.Repository;
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

namespace Door_to_Door_Sales_App
{
    public partial class AddHousePage : Form

    {
        private readonly DoorToDoorRepository _repository;
        public static DoorToDoorRoutes route = new DoorToDoorRoutes();
        public AddHousePage()
        {
            InitializeComponent();
            _repository = new DoorToDoorRepository();
            this.CenterToScreen();
            this.txtHouseAddress.Text = string.Empty;
            this.txtHouseNotes.Text = string.Empty;
        }

        private void AddHousePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        private void btnCreateNewHouse_Click(object sender, EventArgs e)//ERROR with RouteID to House Syncapation
        {
            Houses house = new Houses();

            house.HouseAddress = this.txtHouseAddress.Text.Trim();
            house.HouseNotes = this.txtHouseNotes.Text.Trim();
            house.RouteID = route.RouteID;
            _repository.AddHouse(house);


            //Added
            MessageBox.Show("Successfully added House.");  
            

            ;//Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(Thread));
            t.Start();
        }
        private void Thread()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new ViewRoutePage());
        }

     
    }
}
