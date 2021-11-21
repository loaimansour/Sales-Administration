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
    public partial class FRM_ADD_USERcs : Form
    {
        public FRM_ADD_USERcs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty || txtFull.Text == string.Empty || cpx_user.Text ==string.Empty || txtPass.Text==string.Empty || txtConfigPass.Text ==string.Empty)
            {
                MessageBox.Show("Please Add All Information", " Error Add User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtConfigPass.Text != txtPass.Text)
            {
                MessageBox.Show("Please Add Correct Confirm PassWord ", " Error PassWord", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btnSave.Text =="Update User")
            {
                
                BL.BusnissLayer B = new BL.BusnissLayer();
                FRM_USER_LIST s = new FRM_USER_LIST();
                B.Update_Users(txtPass.Text, cpx_user.Text, txtFull.Text,txtID.Text);
               
               s. DGV_userList.DataSource = B.GetAllUsers("");
                MessageBox.Show("Update Done", " Update", MessageBoxButtons.OK);
                return;

            }
           else if (btnSave.Text == "Save User")
            {
             BL.BusnissLayer b = new BL.BusnissLayer();
            b.Add_user(txtID.Text,txtPass.Text,cpx_user.Text,txtFull.Text);
                MessageBox.Show("User Added", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }
            txtID.Clear();
            txtPass.Clear();
            txtConfigPass.Clear();
            txtFull.Clear();
            txtID.Focus();

        }
    }
}
