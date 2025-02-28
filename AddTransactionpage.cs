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
    public partial class AddTransactionpage : Form
    {
        public static Houses house = new Houses();
        private readonly DoorToDoorRepository _repository;
        public AddTransactionpage()
        {
            InitializeComponent();
            _repository = new DoorToDoorRepository();
        }

        private void AddTransactionpage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            txtHouseAddress.Text = house.HouseAddress;
            txtItemName.Text = string.Empty;
            txtBoughtStatus.Text = string.Empty;
            txtQuantityBought.Text = string.Empty;

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
            Application.Run(new ViewHousePage());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transactions transaction = new Transactions();

            transaction.ItemName = this.txtItemName.Text.Trim();
            if(this.txtBoughtStatus.Text.Contains("Y"))
            {
                transaction.BoughtStatus = true; //true = bought
            }
            else if(this.txtBoughtStatus.Text.Contains("N"))
            {
                transaction.BoughtStatus = false; //false = not bought
            }
            else
            {
                MessageBox.Show("Please enter either 'Y' or 'N' for Bought Status.");
                return;
            }
            transaction.HouseID = house.HouseID;
            transaction.QuantityBought = this.txtQuantityBought.Text.Trim();
            _repository.AddTransaction(transaction);


            //Added
            MessageBox.Show("Successfully added Transaction.");


            ;//Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(Thread));
            t.Start();
        }
    }
}
