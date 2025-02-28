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
    public partial class ViewHousePage : Form
    {
        public static Houses house = new Houses();
        private readonly DoorToDoorRepository _repository;
        
        public ViewHousePage()
        {
            InitializeComponent();
            _repository = new DoorToDoorRepository();
        }

        private void ViewHousePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            txtHouseAddress.Text = house.HouseAddress;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            var transactions = _repository.GetHousesTransactions(house.HouseID);
            this.dgvTransactions.DataSource = transactions;

            // Optional: Rename columns for a clearer display
            this.dgvTransactions.Columns["TransactionID"].HeaderText = "Transaction ID";
            this.dgvTransactions.Columns["HouseID"].HeaderText = "House ID";
            this.dgvTransactions.Columns["ItemName"].HeaderText = "Item Name";
            this.dgvTransactions.Columns["BoughtStatus"].HeaderText = "Bought Status";
            this.dgvTransactions.Columns["QuantityBought"].HeaderText = "Quantity Bought";
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
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

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            AddTransactionpage addTransactionpage = new AddTransactionpage();
            AddTransactionpage.house = house;
            Thread t = new Thread(new ThreadStart(Thread2));
            t.Start();
        }
        private void Thread2()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new AddTransactionpage());
        }
    }
}
