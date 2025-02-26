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
        public ViewHousePage()
        {
            InitializeComponent();
        }

        private void ViewHousePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            txtHouseAddress.Text = house.HouseAddress;
            //LoadDataGridView();
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
    }
}
