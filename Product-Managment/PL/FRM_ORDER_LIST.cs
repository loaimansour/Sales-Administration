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
    public partial class FRM_ORDER_LIST : Form

    {
        BL.CLS_ORDERS or = new BL.CLS_ORDERS();
        DataTable DT = new DataTable();
        public FRM_ORDER_LIST()
        {
            InitializeComponent();
            DGV_orders.DataSource = or.Search_Order("");
            
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
            
            DGV_orders.DataSource = or.Search_Order(txtSearch.Text);
            }
            catch
            {
                return;
            }
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BL.ORDER OR = new BL.ORDER();
            // get last  Order
            this.Cursor = Cursors.WaitCursor;
            int OrderId = Convert.ToInt32(DGV_orders.CurrentRow.Cells[4].Value);
            RPT.RPT_ORDER report = new RPT.RPT_ORDER();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();

            report.SetDataSource(OR.GetOrderDetils(OrderId));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }
    }
}
