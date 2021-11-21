using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace Product_Managment.PL
{
    public partial class FRM_Customer : Form
    {
        SqlConnection conn = new SqlConnection("SERVER = DESKTOP-F7JRQN2 ; DATABASE = Product;Integrated Security = true");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        int id, postion;
        
        public FRM_Customer()
        {
            
            InitializeComponent();
            SqlConnection conn = new SqlConnection("SERVER = DESKTOP-F7JRQN2 ; DATABASE = Product;Integrated Security = true");
            conn.Open();
            string s = "Select ID_CUSTOMER,FIRST_NAME,LAST_NAME , TEL , EMAIL , IMAGE_CUSTOMER FROM CUSTOMER";

           
            //SqlDataAdapter ad = new SqlDataAdapter(cmd);
            //cmd.ExecuteNonQuery();
            dataGridView1.DataSource = this.GettAllCust();

            //ad.Fill(dt);

            //DGV_CST.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }
        public DataTable GettAllCust()
        {
            DAL.DataAccessLayer da = new DAL.DataAccessLayer();
            
            DataTable dt = new DataTable();
             dt = da.SelectData("GetAllCust",null);
            return dt;
        }

        private void FRM_Customer_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BL.CLS_Customer cs = new BL.CLS_Customer();
            try
            {
                byte[] imge = { 0 };
                if (Pic_cs.Image == null)
                {

                    cs.Add_Cust(txtFirst.Text, txtLast.Text, txtPhone.Text, txtEmail.Text, imge, "Without Image");
                    MessageBox.Show("Add Successfuly");
                    dataGridView1.DataSource = GettAllCust();
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    Pic_cs.Image.Save(ms, Pic_cs.Image.RawFormat);
                    imge = ms.ToArray();


                    cs.Add_Cust(txtFirst.Text, txtLast.Text, txtPhone.Text, txtEmail.Text, imge, "With Image");
                    MessageBox.Show("Add Successfuly");
                    dataGridView1.DataSource = GettAllCust();


                }
            }
            catch
            {
            }
            finally
            {
                button5.Enabled = false;





            }
        }
           
        

        private void Pic_cs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "Image_file|*.jpg;*.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Pic_cs.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                 id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                txtFirst.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtLast.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            byte[] im = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(im);
            Pic_cs.Image = Image.FromStream(ms);
               
            }
            catch
            {
                return;
            }
           

           
        }

        private void txtFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar)&& (!char.IsControl(e.KeyChar))   )
            {
                e.Handled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Navigate(0);
            

            
        }

        private void button6_Click(object sender, EventArgs e)
        { if(postion == 0)
            {
                MessageBox.Show("This First Element");
                return;
            }
            postion -= 1;
            Navigate(postion);
          

        }

        private void button9_Click(object sender, EventArgs e)
        {
            postion =   GettAllCust().Rows.Count - 1;
            Navigate(postion);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("this Customer Does not exist");
                return;
            }
            BL.CLS_Customer Cs = new BL.CLS_Customer();
             id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            byte[] img = { 0 };
            if (Pic_cs.Image == null)
            {
                Cs.Update_Cust(txtFirst.Text, txtLast.Text, txtPhone.Text, txtEmail.Text, img, "Without Image", id);
                MessageBox.Show("Update Done","Update",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dataGridView1.DataSource = GettAllCust();
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                Pic_cs.Image.Save(ms, Pic_cs.Image.RawFormat);
                img = ms.ToArray();
                Cs.Update_Cust(txtFirst.Text, txtLast.Text, txtPhone.Text, txtEmail.Text, img, "With Image", id);
                MessageBox.Show("Update Done", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = GettAllCust();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtFirst.Clear();
            txtPhone.Clear();
            txtLast.Clear();
            txtSearch.Clear();
            Pic_cs.Image = null;
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)

        {
             id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (id == 0)
            {
                MessageBox.Show("this Customer Does not exist");
                return;
            }
           
            if (MessageBox.Show("Are You  Sure Delete", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
              
           
            string Query = "delete from CUSTOMER where ID_CUSTOMER = " + id;
            conn.Open();
            cmd = new SqlCommand(Query,conn);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Done","Delete");
            dataGridView1.DataSource = GettAllCust();
            conn.Close();
            }
            else
            {
                return;
            }
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            BL.CLS_Customer cust = new BL.CLS_Customer();
         
            if (txtSearch.Text == null)
            {
                dataGridView1.DataSource = GettAllCust();
            }
            else
            {
            
            dataGridView1.DataSource = cust.Search_Cust(txtSearch.Text);
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainFrm f = new MainFrm();
            f.ShowDialog();
            this.Close();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button10_Click(sender,e);
            }
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
           
            if (postion == GettAllCust().Rows.Count-1)
            {
                MessageBox.Show("This Last Element");
                return;
            }
            postion += 1;
            Navigate(postion);
        }

        void Navigate(int Index)
        {
            try
            {
                Pic_cs.Image = null;


            DataRowCollection DRC = GettAllCust().Rows;
            id =Convert.ToInt32(DRC[Index][0]);
                txtFirst.Text = DRC[Index][1].ToString();
            txtLast.Text = DRC[Index][2].ToString();
            txtPhone.Text = DRC[Index][3].ToString();
            txtEmail.Text = DRC[Index][4].ToString();
            
            byte[] im = (byte[])DRC[Index][5];
            MemoryStream ms = new MemoryStream(im);
            Pic_cs.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
         

        }
    }
    }
