using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Managment.PL
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BL.BusnissLayer bs = new BL.BusnissLayer();
            DataTable dt = new DataTable();


            dt = bs.Login(txtUser.Text , txtPass.Text);

            if (dt.Rows.Count > 0 )
                if (dt.Rows[0][2].ToString() == "adminstrator")
                {
                 Program.SalesMan = dt.Rows[0][3].ToString();
                MainFrm.ReturnForm.Product.Enabled = true;
                MainFrm.ReturnForm.Customer.Enabled = true;
                MainFrm.ReturnForm.Users.Enabled = true;
                MainFrm.ReturnForm.Create_Abackup.Enabled = true;
               // MainFrm.ReturnForm.Restore.Enabled = true;
              
               
                  this.Close();
                }
           
            else if(dt.Rows[0][2].ToString() != "adminstrator")
            {
                    Program.SalesMan = dt.Rows[0][3].ToString();
                    MainFrm.ReturnForm.Product.Enabled = true;
                    MainFrm.ReturnForm.Customer.Enabled = true;
                    MainFrm.ReturnForm.Users.Visible = false;
                    MainFrm.ReturnForm.Create_Abackup.Enabled = true;
                    

                 
                    this.Close();                                                                        



                }
            else

                MessageBox.Show("Its Not Correct");
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
        MainFrm f = new MainFrm();
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BL.BusnissLayer bs = new BL.BusnissLayer();
                DataTable dt = new DataTable();


                dt = bs.Login(txtUser.Text, txtPass.Text);

                if (dt.Rows.Count > 0)
                {
                    
                    MainFrm.ReturnForm.Product.Enabled = true;
                    MainFrm.ReturnForm.Customer.Enabled = true;
                    MainFrm.ReturnForm.Users.Enabled = true;
                    MainFrm.ReturnForm.Create_Abackup.Enabled = true;
                   

                    MainFrm.ReturnForm.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Its Not Correct");



                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
