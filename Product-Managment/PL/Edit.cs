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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BL.Product p = new BL.Product();         
            MemoryStream ms = new MemoryStream();
            this.picEdit.Image.Save(ms,picEdit.Image.RawFormat);
            byte[] byteImg = ms.ToArray();
                p.Update_Prode(txtID.Text,txtLable.Text,Convert.ToInt16(txtQty.Text),txtPrice.Text, byteImg,Convert.ToInt32(txtIDCat.Text));
            MessageBox.Show("Update Done");

            Form_Product.getMForm.DGV.DataSource = p.SelectAll_Product();






        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "Image file|*.jpg;*.png;*.JFIF;*.BMP";
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                picEdit.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
