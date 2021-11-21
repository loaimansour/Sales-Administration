using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Product_Managment.BL
{
    class CLS_Customer
    {
        DAL.DataAccessLayer dl = new DAL.DataAccessLayer();

        public void Add_Cust(string FirstName , string Last , string tel ,string Email , byte[] img , string chick)
        {
            DAL.DataAccessLayer dl = new DAL.DataAccessLayer();
            dl.open();
            SqlParameter[] pr = new SqlParameter[6];
            pr[0] = new SqlParameter("@First_name",SqlDbType.VarChar,25);
            pr[1] = new SqlParameter("@Last_name", SqlDbType.VarChar, 25);
            pr[2] = new SqlParameter("@Tel", SqlDbType.NChar, 15);
            pr[3] = new SqlParameter("@Email", SqlDbType.VarChar, 25);
            pr[4] = new SqlParameter("@Image", SqlDbType.Image);
            pr[5] = new SqlParameter("@Check",SqlDbType.VarChar,50);

            pr[0].Value = FirstName;
            pr[1].Value = Last;
            pr[2].Value = tel;
            pr[3].Value = Email;
            pr[4].Value = img;
            pr[5].Value = chick;
            dl.Execute("Add_Cust",pr);
           

        }

        public  void Update_Cust(string first_name , string last_name , string tel , string Emails,byte[]img,string ch,int id)
        {
            SqlParameter[]pr = new SqlParameter[7];
            pr[0] = new SqlParameter("@First_name", SqlDbType.VarChar,25);
            pr[1] = new SqlParameter("@Last_name", SqlDbType.VarChar,25);
            pr[2] = new SqlParameter("@Tel", SqlDbType.NChar, 15);
            pr[3] = new SqlParameter("@Email", SqlDbType.VarChar, 25);
            pr[4] = new SqlParameter("@Image", SqlDbType.Image);
            pr[5] = new SqlParameter("@Check", SqlDbType.VarChar, 50);
            pr[6] = new SqlParameter("@ID", SqlDbType.Int);
           

            pr[0].Value = first_name;
            pr[1].Value = last_name;
            pr[2].Value = tel;
            pr[3].Value = Emails;
            pr[4].Value = img;
            pr[5].Value = ch;
            pr[6].Value = id;

            dl.open();
            dl.Execute("UPDAT_CUST", pr);
            
        }

        public DataTable Search_Cust(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@Search",SqlDbType.VarChar,50);
            pr[0].Value = search;
            
            DataTable dt = new DataTable();
            dt = dl.SelectData("Search_Cust",pr);
            return dt;
            
        }
    }
}
