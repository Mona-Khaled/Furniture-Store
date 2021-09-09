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
    public partial class addcustomer : UserControl
    {
        public addcustomer()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=desktop-0ufel1p;Initial Catalog=furnituresystem;Integrated Security=True");
            con.Open();
            string addcustomer = @"insert into cust_tb (id,name,address,telephone,mail,username,password,feedback,credit_card)values('" + this.textBox_ID.Text + "','" + this.textBox_name.Text + "','" + this.textBox_address.Text + "','" + this.textBox_telephone.Text + "','" + this.textBox_mail.Text + "','" + this.textBox_username.Text + "','" + textBox_password.Text + "','"+this.textBox_feedback.Text+"','"+this.textBox_credit.Text+"')";
            SqlCommand cmd = new SqlCommand(addcustomer, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("save successfully");
            textBox_ID.Text = " ";
            textBox_name.Text = " ";
            textBox_address.Text = " ";
            textBox_telephone.Text = " ";
            textBox_mail.Text = " ";
            textBox_username.Text = " ";
            textBox_password.Text = " ";
            textBox_feedback.Text = " ";
            textBox_credit.Text=" ";
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
