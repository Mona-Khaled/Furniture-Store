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
    public partial class deletebranch : UserControl
    {
        public deletebranch()
        {
            InitializeComponent();
        }

        private void button_DEL_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=desktop-0ufel1p;Initial Catalog=furnituresystem;Integrated Security=True");
            con.Open();
            string deletebranch = "delete from branch where id=" + this.textBox_del_id.Text;
            SqlCommand cmd = new SqlCommand(deletebranch, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("delete successfully");
            textBox_del_id.Text = " ";
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
