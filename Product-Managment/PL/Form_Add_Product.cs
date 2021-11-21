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
using System.IO;
namespace Product_Managment.PL
{
    public partial class Form_Add_Product : Form

    {
        BL.Product pr = new BL.Product();
      

        public Form_Add_Product()
        {

       
            InitializeComponent();
            cpxPrdCAt.DataSource = pr.Get_ALL_CATEGORY();
            cpxPrdCAt.DisplayMember = "DESCCRIPTION";
            cpxPrdCAt.ValueMember = "ID_CAT";
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Title = "Select Image";
            ofd.Filter = "Images File|*.jpg; *.png;*.GIF; *.BMP;*.JFIF";
            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                picProduct.Image = Image.FromFile(ofd.FileName);
            }
        }
          
        private void btnExit_prod_Click(object sender, EventArgs e)
        {
            this.Close();
           
            
        }

        private void Form_Add_Product_Load(object sender, EventArgs e)
        {
          
        }

        private void cpxPrdCAt_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            
        }

        private void cpxPrdCAt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                e.Handled = true;
            
        }
        public DataTable CheckIDProduct(string IDProduct)
        {
            DAL.DataAccessLayer d = new DAL.DataAccessLayer();
            d.open();
            SqlParameter[] arr = new SqlParameter[1];
            arr[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            arr[0].Value = IDProduct;
            DataTable td = new DataTable();
            td = d.SelectData("VerifyProductID", arr);
            return td;

        }

        private void btnAgree_prod_Click(object sender, EventArgs e)
        {
            BL.Product p = new BL.Product();
            MemoryStream ms = new MemoryStream();
            picProduct.Image.Save(ms,picProduct.Image.RawFormat);
            byte[] byteImage = ms.ToArray();
            DataTable td = new DataTable();
            td = CheckIDProduct(txtID_p.Text);
            if ( td.Rows.Count>0)
            {
                MessageBox.Show("It already exists");
            }
            else
            {
            p.AddNew_Product(Convert.ToInt32(cpxPrdCAt.SelectedValue),txtID_p.Text,txtPrice_prod.Text,txt_Desc_prod.Text,Convert.ToInt32(txtQty_prod.Text),byteImage);
              MessageBox.Show("Add Done","Add Process" , MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            




            
        }

        private void txtID_p_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQty_prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (  !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)    )
            {
                e.Handled = true;
            }
        }

        private void txtID_p_Validated(object sender, EventArgs e)
        {
            DataTable td = new DataTable();
            td = CheckIDProduct(txtID_p.Text);
            if (td.Rows.Count > 0)
            {
                MessageBox.Show("It already exists","Wrning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtID_p.Focus();
                txtID_p.SelectionStart = 0;
                txtID_p.SelectionLength = txtID_p.MaxLength;
            }
            else
            {
                txtPrice_prod.Focus();
            }
        }

        private void txtQty_prod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_prod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
