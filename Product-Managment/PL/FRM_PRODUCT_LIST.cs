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
    public partial class FRM_PRODUCT_LIST : Form
    {
        public FRM_PRODUCT_LIST()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            BL.Product p = new BL.Product();
            dt = p.SelectAll_Product();
            DGV_PR_LIST.DataSource = dt;
            DGV_PR_LIST.Columns[5].Visible = false;
            DGV_PR_LIST.Columns[6].Visible = false;
        }

        private void DGV_PR_LIST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_PR_LIST_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
            FRM_ORDERS f = new FRM_ORDERS();
            f.txtQTY.Text = "";
          
        }
    }
}
