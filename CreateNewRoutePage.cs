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
    public partial class CreateNewRoutePage : Form
    {
        public CreateNewRoutePage()
        {
            InitializeComponent();
        }
        private void CreateNewRoutePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnCreateRoute_Click(object sender, EventArgs e)
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
            Application.Run(new HomePage());
        }

    }
}
