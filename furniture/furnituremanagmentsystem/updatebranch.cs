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
    public partial class updatebranch : UserControl
    {
        public updatebranch()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=desktop-0ufel1p;Initial Catalog=furnituresystem;Integrated Security=True");
            con.Open();
            string update_branch = @"update branch set id='" +textBox_ID.Text+"',address='" +txtbx_address.Text+"',telephone='"+txtbox_telephone.Text+"'where id='"+textBox_ID.Text+"'";
            SqlCommand cmd = new SqlCommand(update_branch, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully update");
        }

        private void buttoncheck_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=desktop-0ufel1p;Initial Catalog=furnituresystem;Integrated Security=True");

            string ch = "select id from addproduct where id='" + textBox_id_branch;
            con.Open();
            SqlCommand cmd = new SqlCommand(ch, con);
            panelupdatebranch.Visible = true;
            panel_id_check.Visible = false;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }

        private void updateproduct1_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }
    }
}
