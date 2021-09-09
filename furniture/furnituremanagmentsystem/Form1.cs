using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace furnituremanagmentsystem
{
    public partial class Form1 : Form
    {
        bool ismenupanelopen = false;  //to open panel of product
        public bool isadmin = false;
        public Form1()
        {
            InitializeComponent();
            sidepanel.Height = homebtn.Height;
            sidepanel.Top = homebtn.Top;
            homecontrol1.BringToFront();
        }
        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void productbtn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = productbtn.Height;
            sidepanel.Top = productbtn.Top;
            timer1.Start(); //to open timer
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ismenupanelopen)  //case that close menu
            {
                menupanel1.Height -= 20;
                if (menupanel1.Height == 0)
                {
                    timer1.Stop();
                    ismenupanelopen=false;
                }
            }
            else   //open menu
            {
                menupanel1.Height += 20;
                if (menupanel1.Height == 260)
                {
                    timer1.Stop();
                    ismenupanelopen = true;
                }
            }
        }

        private void memberbtn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = memberbtn.Height;
            sidepanel.Top = memberbtn.Top;
           memberControl1.BringToFront();
        }
        private void aboutbtn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = aboutbtn.Height;
            sidepanel.Top = aboutbtn.Top;
            aboutControl1.BringToFront();
        }
        private void aboutControl1_Load(object sender, EventArgs e)
        {
        }
        private void homebtn_Click_1(object sender, EventArgs e)
        {
            sidepanel.Height = homebtn.Height;
            sidepanel.Top = homebtn.Top;
            homecontrol1.BringToFront();
        }

        private void aboutbtn_Click_1(object sender, EventArgs e)
        {
            sidepanel.Height = aboutbtn.Height;
            sidepanel.Top = aboutbtn.Top;
            aboutControl1.BringToFront();
        }
        private void tablebutton_Click(object sender, EventArgs e)
        {
            tableControl11.BringToFront();
        }
        private void sofabutton_Click(object sender, EventArgs e)
        {
            sofaControl1.BringToFront();
        }
        private void chairbutton_Click(object sender, EventArgs e)
        {
            chairControl1.BringToFront();
        }
        private void bedbutton_Click(object sender, EventArgs e)
        {
            bedControl1.BringToFront();
        }
        private void menupanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void memberControl1_Load(object sender, EventArgs e)
        {

        }

        private void admincontrol1_Load(object sender, EventArgs e)
        {

        }

        private void button_addproduct_Click(object sender, EventArgs e)
        {
            addproduct1.BringToFront();
        }

    }
}
