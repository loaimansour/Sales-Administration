using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;
namespace Product_Managment.PL
{
    public partial class FRM_ORDERS : Form
    {
        private static FRM_ORDERS Order;
        DataTable dt = new DataTable();
        BL.CLS_ORDERS ORD = new BL.CLS_ORDERS();

        private void WhenClose(object sender, FormClosedEventArgs e)
        {
            Order = null;
        }

        public FRM_ORDERS GetOrder
        {
            get
            {
                if (Order == null)
                    Order = new FRM_ORDERS();
                Order.FormClosed += new FormClosedEventHandler(WhenClose);
                return Order;


            }

        }
        void CreateDataTable()
        {
            dt.Columns.Add("ID_PRODUCT");
            dt.Columns.Add("Name_PRODUCT");
            dt.Columns.Add("Price_Unit");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Amount");
            dt.Columns.Add("discount percentage(%)");
            dt.Columns.Add("Total amount");

            DGV_Product.DataSource = dt;
            //Add Buttun to DataGrid
            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.HeaderText = "product selection";
            //btn.Text = "Search";
            //btn.UseColumnTextForButtonValue = true;
            //DGV_Product.Columns.Insert(0,btn);
        }

        public void reSize()
        {
            DGV_Product.RowHeadersWidth = 70;
            this.DGV_Product.Columns[0].Width = 97;
            this.DGV_Product.Columns[1].Width = 146;
            this.DGV_Product.Columns[2].Width = 100;
            this.DGV_Product.Columns[3].Width = 95;
            this.DGV_Product.Columns[4].Width = 97;
            this.DGV_Product.Columns[5].Width = 95;
            this.DGV_Product.Columns[6].Width = 111;


        }

        public FRM_ORDERS()
        {
            InitializeComponent();
           
            if (Order == null)
                Order = this;
            CreateDataTable();
            reSize();
           
 txtSales.Text = Program.SalesMan;


        }



        private void button3_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = ORD.Get_NumInvoice();
            txtInvoiceNum.Text = DT.Rows[0][0].ToString();
            button3.Enabled = false;
            btnAdd.Enabled = true;

        }

        private void FRM_ORDERS_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMER_LIST FrmList = new FRM_CUSTOMER_LIST();
            FrmList.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_PRODUCT_LIST f = new FRM_PRODUCT_LIST();
            f.ShowDialog();
            ClearBox();
            txtID_Prud.Text = f.DGV_PR_LIST.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = f.DGV_PR_LIST.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = f.DGV_PR_LIST.CurrentRow.Cells[3].Value.ToString();
            txtQTY.Text = "";
            txtQTY.Focus();


        }
         void ClacAmount()
        {
            if(txtPrice.Text != string.Empty && txtQTY.Text!= string.Empty)
               
            txtAmount.Text = (Convert.ToDouble(txtQTY.Text)*Convert.ToInt32(txtPrice.Text)).ToString();
            
            
        }
        private void txtQTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&(e.KeyChar!=8  && e.KeyChar >8)     )
            {
                e.Handled = true;
            }
        
        }

        private void txtQTY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter  && txtQTY.Text != string.Empty)
            {
                txtDiscount.Focus();
            }

            
           
            
        }

        private void txtQTY_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(  !char.IsDigit(e.KeyChar) && (e.KeyChar != 8)   && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))   
            {
                e.Handled = true;
            }

        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPrice.Text != string.Empty)
            {
                txtQTY.Focus();
            }
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            ClacAmount();
            CalcTotalAmount();
        }
        void CalcTotalAmount()
        {
            if (txtDiscount.Text != string.Empty && txtAmount.Text != string.Empty)
            {
             double discpund = Convert.ToDouble(txtDiscount.Text);
            double Amount = Convert.ToInt32(txtAmount.Text);
            double R = Amount - ( Amount * (discpund/100) ) ;
            txtTotal.Text = R.ToString();
        }
            }
           
        private void txtQTY_KeyUp(object sender, KeyEventArgs e)
        {
            ClacAmount();
            CalcTotalAmount();
        }

        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            CalcTotalAmount();

        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        void ClearBox()
        {
            txtID_Prud.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQTY.Clear();
            txtAmount.Clear();
            txtDiscount.Clear();
            txtTotal.Clear();
            btnBrows.Focus();
        }
        void ClearData()
        {
            txtInvoiceNum.Clear();
            txtDesc.Clear();
            txtSales.Clear();
            txtDate.ResetText();
            txtIdCs.Clear();
            txtFirst.Clear();
            txtLast.Clear();
            txtEmil.Clear();
            txtPh.Clear();
            picC.Image = null;
            dt.Clear();
            DGV_Product.DataSource = null;
            txtFinalTotal.Clear();
            ClearBox();
            btnAdd.Enabled = false;
            button3.Enabled = true;



        }

        BL.ORDER rd = new BL.ORDER();
        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
          if (e.KeyCode == Keys.Enter)
          {
                double sum = 0;
            if (rd.VerifyQty(txtID_Prud.Text, Convert.ToInt32(txtQTY.Text)).Rows.Count < 1)
            {
                MessageBox.Show("The quantity entered for this product is not available", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            for (int  i = 0; i<DGV_Product.RowCount-1;i++ )
            {
                if (DGV_Product.Rows[i].Cells[0].Value.ToString() == txtID_Prud.Text)
                {
                    MessageBox.Show("ID already exists ","Erorr",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
               
            }
            

                DataRow dr = dt.NewRow();
                dr[0] = txtID_Prud.Text;
                dr[1] = txtName.Text;
                dr[2] = txtPrice.Text;
                dr[3] = txtQTY.Text;
                dr[4] = txtAmount.Text;
                dr[5] = txtDiscount.Text;
                dr[6] = txtTotal.Text;
                dt.Rows.Add(dr);

                DGV_Product.DataSource = dt;
                ClearBox();
                txtFinalTotal.Text = (from DataGridViewRow row in DGV_Product.Rows
                                      where row.Cells[6].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();



            }

            }

            private void DGV_Product_DoubleClick(object sender, EventArgs e)
        { 
            try
            {
                txtID_Prud.Text = DGV_Product.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = DGV_Product.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = DGV_Product.CurrentRow.Cells[2].Value.ToString();
                txtQTY.Text = DGV_Product.CurrentRow.Cells[3].Value.ToString();
                txtAmount.Text = DGV_Product.CurrentRow.Cells[4].Value.ToString();
                txtTotal.Text = DGV_Product.CurrentRow.Cells[5].Value.ToString();
                DGV_Product.Rows.RemoveAt(DGV_Product.CurrentRow.Index);

                CalcTotalAmount();
              
            }
            catch
            {
                return;
            }
            


        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGV_Product_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < DGV_Product.Rows.Count; i++)
            {
                double r = Convert.ToInt32(DGV_Product.Rows[i].Cells[6].Value);
                sum += r;


            }
            txtFinalTotal.Text = sum.ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGV_Product_DoubleClick(sender, e);
        }

        private void deleteCurrentLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGV_Product.Rows.RemoveAt(DGV_Product.CurrentRow.Index);
        }

        private void deleteALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            DGV_Product.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BL.ORDER order = new BL.ORDER();
            //check Values
            if(txtInvoiceNum.Text == string.Empty || txtDesc.Text == string.Empty || txtIdCs.Text == string.Empty || DGV_Product.Rows.Count < 1)
            {
                MessageBox.Show("Missing data must be entered","Notification",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            //Add Info Invoice
            order.ADD_ORDER(Convert.ToInt32(txtInvoiceNum.Text), txtDate.Value, Convert.ToInt32(txtIdCs.Text), txtDesc.Text, txtSales.Text);
            //Add All Product 

            for (int i = 0; i < DGV_Product.Rows.Count - 1; i++)
            {
                order.ADD_ORDER_DETAILS(DGV_Product.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(txtInvoiceNum.Text), Convert.ToInt32(DGV_Product.Rows[i].Cells[3].Value), DGV_Product.Rows[i].Cells[2].Value.ToString(), Convert.ToDouble(DGV_Product.Rows[i].Cells[5].Value), DGV_Product.Rows[i].Cells[4].Value.ToString(), DGV_Product.Rows[i].Cells[6].Value.ToString(),DGV_Product.CurrentRow.Cells[0].Value.ToString());
            }
            MessageBox.Show("Save Its Done", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
            btn_Print.Enabled = true;
        }

        private void DGV_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            BL.ORDER OR = new BL.ORDER();
            // get last  Order
            this.Cursor = Cursors.WaitCursor;
            int OrderId = Convert.ToInt32(ORD.GET_LAST_ORDER_ForPrint().Rows[0][0]);
            RPT.RPT_ORDER report = new RPT.RPT_ORDER();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();

            report.SetDataSource(OR.GetOrderDetils(OrderId));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void txtFinalTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picC_Click(object sender, EventArgs e)
        {

        }
    }
}