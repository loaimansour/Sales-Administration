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

namespace Product_Managment.PL
{
    public partial class FRM_CUSTOMER_LIST : Form
    {
        public FRM_CUSTOMER_LIST()
        {
            InitializeComponent();
            PL.FRM_Customer cF = new FRM_Customer();
         

            DGV_CST.DataSource  = cF.GettAllCust();
            DGV_CST.Columns[0].Visible = false;
            DGV_CST.Columns[5].Visible = false;
        }
          FRM_ORDERS frm = new FRM_ORDERS();
        private void DGV_CST_DoubleClick(object sender, EventArgs e)
        {
            try
         { 
            if (DGV_CST.CurrentRow.Cells[5].Value is DBNull)
            {
                MessageBox.Show("This Customer Not have Pic");
                frm.GetOrder.txtIdCs.Text = DGV_CST.CurrentRow.Cells[0].Value.ToString();
                frm.GetOrder.txtFirst.Text = DGV_CST.CurrentRow.Cells[1].Value.ToString();
                frm.GetOrder.txtLast.Text = DGV_CST.CurrentRow.Cells[2].Value.ToString();
                frm.GetOrder.txtPh.Text = DGV_CST.CurrentRow.Cells[3].Value.ToString();
                frm.GetOrder.txtEmil.Text = DGV_CST.CurrentRow.Cells[4].Value.ToString();
                    frm.GetOrder.picC.Image = null;
 this.Close();
                    frm.GetOrder.ShowDialog();
                   
                return;
               
            }
                else
                {
                    frm.GetOrder.txtIdCs.Text = DGV_CST.CurrentRow.Cells[0].Value.ToString();
                    frm.GetOrder.txtFirst.Text = DGV_CST.CurrentRow.Cells[1].Value.ToString();
                    frm.GetOrder.txtLast.Text = DGV_CST.CurrentRow.Cells[2].Value.ToString();
                    frm.GetOrder.txtPh.Text = DGV_CST.CurrentRow.Cells[3].Value.ToString();
                    frm.GetOrder.txtEmil.Text = DGV_CST.CurrentRow.Cells[4].Value.ToString();
                    byte[] img = (byte[])DGV_CST.CurrentRow.Cells[5].Value;
                    MemoryStream ms = new MemoryStream(img);

                    frm.GetOrder.picC.Image = Image.FromStream(ms);
                    this.Close();

                    frm.GetOrder.ShowDialog();




                }



            }
            catch
            {
                return; 
            }


        
           
          
        }

        private void FRM_CUSTOMER_LIST_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
