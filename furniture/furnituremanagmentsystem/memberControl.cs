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
    public partial class memberControl : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source= desktop-0ufel1p;Initial Catalog=furnituresystem;Integrated Security=True");
        public memberControl()
        {
            InitializeComponent();
        }

        private void cusomerbtn_Click(object sender, EventArgs e)
        {
            custlogpanel.Visible = true;
            logadminpanel.Visible = false;
            registerpanel.Visible = false;
        }
        private void notregisterbtn_Click(object sender, EventArgs e)
        {
            registerpanel.Visible = true;
            logadminpanel.Visible = false;
            custlogpanel.Visible = false;
        }
        private void adminbtn_Click(object sender, EventArgs e)
        {
            logadminpanel.Visible = true;
            custlogpanel.Visible = false;
            registerpanel.Visible = false;
        }

        private void loguserbtn_Click(object sender, EventArgs e)
        {
        }

        private void logadminpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string loginadmin = "select*from admin where username='" + adminnametxtbx.Text.Trim() + "'and password ='" + passadmintxtBx.Text.Trim() + "'";
            bool hasallwhitespace = adminnametxtbx.Text.Length > 0 && adminnametxtbx.Text.Trim().Length == 0;
            caselog(); //if there is wrong username
            SqlDataAdapter sda = new SqlDataAdapter(loginadmin,con);
            DataTable dbtl = new DataTable();
            sda.Fill(dbtl);
           
            if(dbtl.Rows.Count==1)
            {
                admincontrol admincon = null;
                 admincon = new admincontrol();
                 this.Controls.Add(admincon);
                 admincon.BringToFront();
            }
            else
            {
                caselog();
            }
            con.Close();
        }

        private void adminnametxtbx_TextChanged(object sender, EventArgs e)
        {
        }

        private void adminnametxtbx_MouseEnter(object sender, EventArgs e)
        {
        //{
        //    if (adminnametxtbx.Text != "" || adminnametxtbx.Text != null)
        //    {

        //        adminnametxtbx.Text = "";

        //    }
        }

        private void lbl_caselog_Click(object sender, EventArgs e)
        {

        }
    private void caselog()
    {

        lbl_caselog.Text = "username or password wrong";
        this.lbl_caselog.ForeColor = System.Drawing.Color.Red;
        this.lbl_caselog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //this.sidepanel.BackColor = System.Drawing.Color.White;
    }
    }
}