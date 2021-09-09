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
    public partial class updateorder : UserControl
    {
        public updateorder()
        {
            InitializeComponent();
        }

        private void btn_UPorder_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection("Data Source=desktop-0ufel1p;Initial Catalog=furnituresystem;Integrated Security=True");
            con.Open();
            string update_order = @"update order_tb set id='" + textBox_ID.Text + "',cu_id='" + txtbox_id_cust.Text + "',amount='" + textbox_amount.Text + "',date='" + textBox_date.Text + "',address='" + txtbox_address.Text + "',city='" + textbox_city.Text + "',piecenumber='" + txtbox_piece.Text + "'where id='" + textBox_ID.Text + "'";
            SqlCommand cmd = new SqlCommand(update_order, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully update");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }
        private void button2_Click(object sender, EventArgs e)
        {
         SqlConnection con = new SqlConnection("Data Source=desktop-0ufel1p;Initial Catalog=furnituresystem;Integrated Security=True");

            string ch = "select id from order_tb where id='" + textBox_ID;
            con.Open();
            SqlCommand cmd = new SqlCommand(ch, con);
            panelcheck.Visible=false;
            panelupdate.Visible=true;
            con.Close();
        } 
        private void btn_back_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }
        private void buttonback_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }
    }
}
