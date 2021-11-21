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
    public partial class FRM_USER_LIST : Form
    {
        BL.BusnissLayer B = new BL.BusnissLayer();

        public FRM_USER_LIST()
        {
            InitializeComponent();
            BL.BusnissLayer B = new BL.BusnissLayer();
            DGV_userList.DataSource = B.GetAllUsers("");
               
        }

          
        private void button2_Click(object sender, EventArgs e)
        {           

            FRM_ADD_USERcs f = new FRM_ADD_USERcs();
            f.btnSave.Text = "Update User";
            f.txtID.Text = DGV_userList.CurrentRow.Cells[0].Value.ToString();
            f.txtPass.Text = DGV_userList.CurrentRow.Cells[1].Value.ToString();
            f.cpx_user.Text = DGV_userList.CurrentRow.Cells[2].Value.ToString();
            f.txtFull.Text = DGV_userList.CurrentRow.Cells[3].Value.ToString();
           
             f.ShowDialog();
            this.DGV_userList.DataSource = B.GetAllUsers("");

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            FRM_ADD_USERcs f = new FRM_ADD_USERcs();
            f.btnSave.Text = "Save User";
            f.ShowDialog();
            this.DGV_userList.DataSource = B.GetAllUsers("");
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            BL.BusnissLayer B = new BL.BusnissLayer();

            DGV_userList.DataSource = B.GetAllUsers(txtSearchUser.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BL.BusnissLayer b = new BL.BusnissLayer();
            b.RemoveUser(this.DGV_userList.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("Delete User its Done");
            this.DGV_userList.DataSource = B.GetAllUsers("");
        }
    }
}
