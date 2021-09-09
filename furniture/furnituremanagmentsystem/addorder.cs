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
    public partial class addorder : UserControl
    {
        public addorder()
        {
            InitializeComponent();
        }

        private void btn_addorder_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=desktop-0ufel1p;Initial Catalog=furnituresystem;Integrated Security=True");
            con.Open();
            string addorder = @"insert into order_tb (id,cu_id,amount,date,address,city,piecenumber)values('" + textBox_ID.Text + "','" + txtbox_id_cust.Text + "','" + textbox_amount.Text + "','" + textBox_date.Text + "','" + txtbox_address.Text + "','" + textbox_city.Text + "','" + txtbox_piece.Text + "')";
            SqlCommand cmd = new SqlCommand(addorder, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("save successfully");
            textBox_ID.Text = " ";
            txtbox_id_cust.Text = " ";
            textbox_amount.Text = " ";
            textBox_date.Text = " ";
            txtbox_address.Text = " ";
            textbox_city.Text = " ";
            txtbox_piece.Text =" ";
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
