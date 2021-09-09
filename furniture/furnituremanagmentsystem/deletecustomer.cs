using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace furnituremanagmentsystem
{
    public partial class deletecustomer : UserControl
    {
        public deletecustomer()
        {
            InitializeComponent();
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=desktop-0ufel1p;Initial Catalog=furnituresystem;Integrated Security=True");
            con.Open();
            string deletEcustomeer = "delete from cust_tb where id=" + this.textBox_ID.Text;
            SqlCommand cmd = new SqlCommand(deletEcustomeer, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("delete successfully");
            textBox_ID.Text = " ";
        }
        private void buttonback_Click_1(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }
    }
}
