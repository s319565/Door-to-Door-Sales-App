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

namespace Door_to_Door_Sales_App
{

    public partial class CreateNewRoutePage : Form
    {

        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\__Students\McEwan\DoorToDoorSalesApp\Door to Door Sales App\Dbase\SalesAppDatabase.accdb""");
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
            try
            {
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into SalesAppDatabase(RouteID,RouteName,RouteNotes)values('" + txtRouteName.Text + "','" + txtRouteNotes.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Route Created");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            ;//Close current form
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
