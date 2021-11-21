using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Product_Managment.PL
{
    public partial class Form_Product : Form
    {
        public static Form_Product frm;

        BL.Product p = new BL.Product();
    
        public Form_Product()
        {
              frm = this;
            InitializeComponent();
            this.DGV.DataSource = p.SelectAll_Product();
            DGV.Columns[5].Visible = false;
            DGV.Columns[6].Visible = false;
        }

        public static void frm_Closed(object sender , FormClosedEventArgs e )
        {
            frm = null;
        }

        public static Form_Product getMForm
        {
            get {
                if (frm == null)
                {
                    frm = new Form_Product();
                    frm.FormClosed += new FormClosedEventHandler(frm_Closed);
                   
                }
                        return frm;
                ; }
        }


        private void Form_Product_Load(object sender, EventArgs e)
        {
           

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void button2_Click(object sender, EventArgs e)
            
        {

            if (  MessageBox.Show("Do you really want to delete the product", "Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                p.Delete_Produuct(this.DGV.CurrentRow.Cells[0].Value.ToString());
               
                 MessageBox.Show("Product Is Deleted");
              this.DGV.DataSource = p.SelectAll_Product();
               
            }
           

            else{
                MessageBox.Show("Delete has been cancelled", "Delete");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            DGV.DataSource = p.Result_search(txtSearch.Text);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Add_Product d = new Form_Add_Product();
            d.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Edit Edit = new Edit();
            //Edit.Text = this.DGV.CurrentRow.Cells[4].Value.ToString();
            Edit.txtID.Text = this.DGV.CurrentRow.Cells[0].Value.ToString();
            Edit.txtLable.Text = this.DGV.CurrentRow.Cells[1].Value.ToString();
            Edit.txtQty.Text = this.DGV.CurrentRow.Cells[2].Value.ToString();
            Edit.txtPrice.Text = this.DGV.CurrentRow.Cells[3].Value.ToString();
            Edit.txtIDCat.Text = this.DGV.CurrentRow.Cells[6].Value.ToString();
            DataTable dt = new DataTable();
            try
            {
                byte[] image = (byte[])GET_IMAGE(this.DGV.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];

                MemoryStream ms = new MemoryStream(image);
                Edit.picEdit.Image = Image.FromStream(ms);
            }
            catch (Exception ex )
            {
                MessageBox.Show("No picture available");
                        }


            Edit.txtID.ReadOnly = true;



            Edit.ShowDialog();
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public DataTable GET_IMAGE(string ID)
        {
            DAL.DataAccessLayer DAL = new Product_Managment.DAL.DataAccessLayer();
            SqlParameter[] arr = new SqlParameter[1];
            arr[0] = new SqlParameter("@ID",SqlDbType.VarChar,30);
            arr[0].Value = ID;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_IMAGE", arr);
            DAL.Close();

                return dt;
           

            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowImage im = new ShowImage();
            byte[] image = (byte[])GET_IMAGE(this.DGV.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];

            MemoryStream ms = new MemoryStream(image);
            im.picSelect.Image = Image.FromStream(ms);
            im.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RPT.RPT_PRODUCT_SINGIL myReport = new RPT.RPT_PRODUCT_SINGIL();
            myReport.SetParameterValue("@ID",this.DGV.CurrentRow.Cells[0].Value.ToString());
            RPT.FRM_RPT_PRODUCT myForm = new RPT.FRM_RPT_PRODUCT();
            myForm.crystalReportViewer1.ReportSource = myReport;
            myForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALL_PRODUCT RptAllProduct = new RPT.RPT_ALL_PRODUCT();
            RPT.FRM_RPT_PRODUCT ALL_PRODUCT = new RPT.FRM_RPT_PRODUCT();
            ALL_PRODUCT.crystalReportViewer1.ReportSource = RptAllProduct;
            ALL_PRODUCT.ShowDialog();
            
        }
    }
}
