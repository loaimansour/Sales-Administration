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
    public partial class MainFrm : Form
    {
        private static MainFrm frm;

        private static void WhenClose(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static MainFrm ReturnForm
        {
            get
            {
                if (frm == null)
                    frm = new MainFrm();
                frm.FormClosed += new FormClosedEventHandler(WhenClose);
                return frm;
            }

        }



        public MainFrm()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.Product.Enabled = false;
            this.Customer.Enabled = false;
            this.Users.Enabled = false;
            this.Create_Abackup.Enabled = false;
          

        }

        private void sdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.ShowDialog();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void Create_Abackup_Click(object sender, EventArgs e)
        {
            FRM_BACKUP frm = new FRM_BACKUP();
            frm.ShowDialog();
        }

        private void SignUot_Click(object sender, EventArgs e)
        {
           
            
            FrmLogin fr = new FrmLogin();
            fr.ShowDialog();
            this.Close();
        }

        private void MainFrm_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void MainFrm_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Add_Product f = new Form_Add_Product();
            f.ShowDialog();
        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Product f = new Form_Product();
            f.ShowDialog();
            
        }

        private void Msp_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addANewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void categoryManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CATEGORY frmCat = new FRM_CATEGORY();
            frmCat.ShowDialog();
        }

        private void addANewSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERS f = new FRM_ORDERS();
            f.ShowDialog();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Customer c = new FRM_Customer();
            c.ShowDialog();
        }

        private void salesAdministrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDER_LIST f = new FRM_ORDER_LIST();
            f.ShowDialog();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_USERcs fr = new FRM_ADD_USERcs();
            fr.ShowDialog();
        }

        private void Restore_Click(object sender, EventArgs e)
        {
           
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_USER_LIST f = new FRM_USER_LIST();
            f.ShowDialog();
        }
    }


    }
