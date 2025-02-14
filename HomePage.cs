﻿using System;
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

namespace Door_to_Door_Sales_App
{
    public partial class HomePage : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\__Students\McEwan\DoorToDoorSalesApp\Door to Door Sales App\Dbase\SalesAppDatabase.accdb""");

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
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

