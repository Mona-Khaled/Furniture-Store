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
    public partial class updatecustomer : UserControl
    {
        public updatecustomer()
        {
            InitializeComponent();
        }

        private void buttoncheck_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=desktop-0ufel1p;Initial Catalog=furnituresystem;Integrated Security=True");

            string ch = "select id from cust_tb where id='" + textBox_id_cust.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand(ch, con);
            panel_id_check.Visible = false;
            panel_upcust.Visible = true;
            con.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=desktop-0ufel1p;Initial Catalog=furnituresystem;Integrated Security=True");
            con.Open();
            string update_customer = @"update cust_tb set id='"+textBox_ID.Text+"',name='"+textBox_name.Text+"',address='"+textBox_address.Text+"',telephone='"+textBox_telephone.Text+"',mail='"+textBox_mail.Text+"',username='"+textBox_password.Text+"'password='"+textBox_feedback.Text+"',credit_card='"+textBox_credit.Text+"'where id='" + textBox_ID.Text + "'";
            SqlCommand cmd = new SqlCommand(update_customer, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully update");
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }
    }
}
