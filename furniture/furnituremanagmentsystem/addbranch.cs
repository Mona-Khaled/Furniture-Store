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
    public partial class addbranch : UserControl
    {
        public addbranch()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }
        private void empty3()
        {
         


        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=desktop-0ufel1p;Initial Catalog=furnituresystem;Integrated Security=True");
            con.Open();
            string addbranch_informatin = @"insert into branch (id,address,telephone)values('" +textBox_branch_addr.Text+"','"+textBox_telephone.Text+"')";
           if( textBox_branch_addr.Text==null||textBox_telephone.Text==null)
           {
               empty3();
               return;
           }
            SqlCommand cmd = new SqlCommand(addbranch_informatin, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("save successfully");
           
           textBox_branch_addr.Text=" ";
           textBox_telephone.Text = " ";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void paneladdproduct_Paint(object sender, PaintEventArgs e)
        {
            this.lbl_branch.Text = "not fill";
            this.lbl_branch.Text = "fill all data";
            this.lbl_branch.ForeColor = System.Drawing.Color.Red;
            this.lbl_branch.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
