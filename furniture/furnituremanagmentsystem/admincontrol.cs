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
    public partial class admincontrol : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=desktop-0ufel1p;Initial Catalog=furnituresystem;Integrated Security=True");
        bool menuisopen = false;
        public admincontrol()
        {
            InitializeComponent();
        }

        private void btn_product_Click(object sender, EventArgs e)  //button product
        {
            timer_pro.Start();
        }

        private void btn_branch_Click(object sender, EventArgs e) ///button branch
        {
            timer_branch.Start();
        }

        private void btn_customer_Click(object sender, EventArgs e)  //button customer
        {
            timer_customer.Start();
        }
        private void timer_pro_Tick(object sender, EventArgs e)   ///timer of customer
        {
            if(menuisopen)
            {
                panel_product.Height -= 20;
                if(panel_product.Height==0)
                {
                    timer_pro.Stop();
                    menuisopen = false;
                }
            }
            else
            {
                panel_product.Height += 20;
                if(panel_product.Height==200)
                {
                    timer_pro.Stop();
                    menuisopen = true;
                }
            }
        }
        private void timer_branch_Tick(object sender, EventArgs e)
        {
            if(menuisopen)
            {
                panel_branch.Height -= 20;
                if(panel_branch.Height==0)
                {
                    timer_branch.Stop();
                    menuisopen = false;
                }
            }
            else
            {
                panel_branch.Height += 20;
                if (panel_branch.Height == 200)
                {
                    timer_branch.Stop();
                    menuisopen = true;
                }
            }
        }

        private void timer_customer_Tick(object sender, EventArgs e)
        {
            if (menuisopen)
            {
                panel_customer.Height -= 20;
                if (panel_customer.Height == 0)
                {
                    timer_customer.Stop();
                    menuisopen = false;
                }
            }
            else
            {
                panel_customer.Height += 20;
                if (panel_customer.Height == 200)
                {
                    timer_customer.Stop();
                    menuisopen = true;
                }
            }
        }

        private void admincontrol_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_product_Click(object sender, EventArgs e)  ///add product by admin
        {
            addproduct addprod = null;
             addprod = new addproduct();
            this.Controls.Add(addprod);
            addprod.BringToFront();
        }

        private void btn_del_pr_Click(object sender, EventArgs e)
        {
            deleteproduct delproduct = null;
            delproduct = new deleteproduct();
            this.Controls.Add(delproduct);
            delproduct.BringToFront();
        }

        private void btn_update_pr_Click(object sender, EventArgs e)
        {
            updateproduct upproduct = null;
            upproduct = new updateproduct();
            this.Controls.Add(upproduct);
            upproduct.BringToFront();
        }

        private void btn_add_br_Click(object sender, EventArgs e)       ///button add branch
        {
            addbranch addbr = null;
            addbr = new addbranch();
            this.Controls.Add(addbr);
            addbr.BringToFront();
        }
        private void btn_del_br_Click(object sender, EventArgs e)  //button delete branch
        {
            deletebranch delbranch = null;
            delbranch = new deletebranch();
            this.Controls.Add(delbranch);
            delbranch.BringToFront();
        }
        private void btn_update_br_Click(object sender, EventArgs e)  ///button update branch
        {
            updatebranch update_br = null;
            update_br = new updatebranch();
            this.Controls.Add(update_br);
            update_br.BringToFront();
        }

        private void buttonadd_Click(object sender, EventArgs e)  //button of add order 
        {
            addorder addor = null;
            addor = new addorder();
            this.Controls.Add(addor);
            addor.BringToFront();
        }
        private void buttondel_Click(object sender, EventArgs e)   //button of delete
        {
            deleteorder delorder = null;
            delorder = new deleteorder();
            this.Controls.Add(delorder);
            delorder.BringToFront();
        }
        private void buttonupdate_Click(object sender, EventArgs e)   //button of update
        {
            updateorder updateord = null;
            updateord = new updateorder();
            this.Controls.Add(updateord);
            updateord.BringToFront();
        }

        private void button_order_Click(object sender, EventArgs e)
        {
            timer_order.Start();
        }

        private void timer_order_Tick(object sender, EventArgs e)
        {
            if (menuisopen)
            {
                panel_order.Height -= 20;
                if (panel_order.Height == 0)
                {
                    timer_order.Stop();
                    menuisopen = false;
                }
            }
            else
            {
                panel_order.Height += 20;
                if (panel_order.Height== 200)
                {
                    timer_order.Stop();
                    menuisopen = true;
                }
            }
        }

        private void btn_add_cust_Click(object sender, EventArgs e)  //add customer 
        {
            addcustomer addcust = null;
            addcust = new addcustomer();
            this.Controls.Add(addcust);
            addcust.BringToFront();
        }
        private void btn_del_cust_Click(object sender, EventArgs e)   //delete customer 
        {
            deletecustomer delcust = null;
            delcust = new deletecustomer();
            this.Controls.Add(delcust);
            delcust.BringToFront();
        }

        private void btn_update_cust_Click(object sender, EventArgs e)   //delete   customer 
        {
            updatecustomer upcust = null;
            upcust = new updatecustomer();
            this.Controls.Add(upcust);
            upcust.BringToFront();
        }

        private void panel_customer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
