using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace Product_Managment.PL
{
    public partial class FRM_CATEGORY : Form
    {
        SqlConnection sqlconn = new SqlConnection("SERVER = DESKTOP-F7JRQN2 ; DATABASE = Product;Integrated Security = true");
        SqlDataAdapter ad;
        DataTable dt;
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public FRM_CATEGORY()
        {   
            InitializeComponent();
            
            ad = new SqlDataAdapter("select ID_CAT 'ID Item', DESCCRIPTION from CATAEGORY", sqlconn);
            ad.Fill(dt = new DataTable());
            this.DGV_cat.DataSource = dt;

            txtID.DataBindings.Add("text", dt, "ID Item");
            txtDesc.DataBindings.Add("text", dt, "DESCCRIPTION");

            bmb = BindingContext[dt];
            lblPostion.Text = (bmb.Position+1)+"/"+ bmb.Count;
            
        }

      

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(ad);
            ad.Update(dt);

            MessageBox.Show("Deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPostion.Text = (bmb.Position + 1) + "/" + bmb.Count;

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPostion.Text = (bmb.Position +1)+ "/" + bmb.Count;
        }

        private void btnPrevos_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Position - 1;
            lblPostion.Text = (bmb.Position + 1) + "/" + bmb.Count;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Position + 1;
            lblPostion.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPostion.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnNew.Enabled = false;
            btnAdd.Enabled = true;
            int id = Convert.ToInt32( dt.Rows[dt.Rows.Count -1 ][0])+1;
            txtID.Text = id.ToString();
            txtDesc.Focus();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(ad);
            ad.Update(dt);
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
              MessageBox.Show("Added successfully","Add",MessageBoxButtons.OK,MessageBoxIcon.Information);
            lblPostion.Text = (bmb.Position + 1) + "/" + bmb.Count;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(ad);
            ad.Update(dt);
           
            MessageBox.Show("Update successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPostion.Text = (bmb.Position + 1) + "/" + bmb.Count;


        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALL_CAT RPT_aLL_CAT = new RPT.RPT_ALL_CAT();
            RPT.FRM_RPT_PRODUCT frmAllCat = new RPT.FRM_RPT_PRODUCT();
            RPT_aLL_CAT.Refresh();
            frmAllCat.crystalReportViewer1.ReportSource = RPT_aLL_CAT;
            frmAllCat.ShowDialog();
        }
        public void SetPara(int id)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID",SqlDbType.Int);
            pr[0].Value = id;
        }

        private void btnPrintSelect_Click(object sender, EventArgs e)
        {
            RPT.RPT_CAT_SINGIL CAT_SINGIL = new RPT.RPT_CAT_SINGIL();
            CAT_SINGIL.SetParameterValue("@ID", Convert.ToInt32(txtID.Text));
            RPT.FRM_RPT_PRODUCT myForm = new RPT.FRM_RPT_PRODUCT();
            myForm.crystalReportViewer1.ReportSource = CAT_SINGIL;
            myForm.ShowDialog();
        }
    }
}
