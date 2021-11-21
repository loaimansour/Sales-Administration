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
namespace Product_Managment.PL
{
    public partial class FRM_BACKUP : Form
    {
        SqlConnection con = new SqlConnection(@"SERVER = DESKTOP-F7JRQN2;DATABASE = Product; Integrated Security=True");
        SqlCommand cmd;
        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            string FileName = txtFileName.Text + "\\Product";

            string strQuery = "Backup Database Product to Disk ='"+FileName + ".bak'";
            cmd = new SqlCommand(strQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("created BackUp Success", "Create BackUp", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
