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
    public partial class addproduct : UserControl
    {

        public addproduct()
        {
            InitializeComponent();
        }

        private void addproduct_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btn_save_Click(object sender, EventArgs e)   //button save of add product
        {
            SqlConnection con = new SqlConnection("Data Source=desktop-0ufel1p;Initial Catalog=furnituresystem;Integrated Security=True");
            con.Open();
            if (textBoxcatagory.Text == null || textBox_image.Text == null || pictureBox_addprod.Image == null || textBox_color.Text == null || textBox_prodname.Text == null || textbox_price.Text == null || textBox_branch_id.Text == null)
            {
                caseempty();
                return;
            }
            string addproduct_informatin = @"insert into addproduct (catagory,image,color,modul,price,branch_id)values('" + this.textBoxcatagory.Text + "','"+textBox_image.Text+"','" + this.textBox_color.Text + "','" + this.textBox_prodname.Text + "','" + textbox_price.Text + "','" + textBox_branch_id.Text + "')";
            //if( textBoxcatagory.Text==null&&textBox_image.Text ==null&&pictureBox_addprod.Image ==null&&textBox_color.Text ==null&&textBox_prodname.Text ==null&&textbox_price.Text ==null&&textBox_branch_id.Text ==null)
            //{
            //    caseempty();
            //}
            SqlCommand cmd = new SqlCommand(addproduct_informatin, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("save successfully");
            textBoxcatagory.Text = " ";
            textBox_image.Text = " ";
            pictureBox_addprod.Image = null;
            textBox_color.Text = " ";
            textBox_prodname.Text = " ";
            textbox_price.Text = " ";
            textBox_branch_id.Text = " ";

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
        private void btn_browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox_addprod.Image = new Bitmap(open.FileName);
                // image file path  
                textBox_image.Text = open.FileName;
            }
        }
        private void caseempty()
        {
            this.lbl_empty.Text = "fill all data";
            this.lbl_empty.ForeColor = System.Drawing.Color.Red;
            this.lbl_empty.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void pictureBox_addprod_Click(object sender, EventArgs e)
        {

        }
    }
}
