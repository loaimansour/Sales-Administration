using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Product_Managment.BL
{
    class BusnissLayer
    {



        public DataTable Login(string A, string B)
        {
            DAL.DataAccessLayer da = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[1] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            da.open();
            DataTable dt = new DataTable();
            param[0].Value = A;
            param[1].Value = B;

            dt = da.SelectData("SF_LOGIN", param);
            
            da.Close();
            return dt;
         
        }
        public void Add_user(string id, string pw, string typeuser, string fullname)
        {
            DAL.DataAccessLayer dl = new DAL.DataAccessLayer();
            dl.open();
            SqlParameter[] pr = new SqlParameter[4];
            pr[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            pr[1] = new SqlParameter("@pcw", SqlDbType.VarChar, 50);
            pr[2] = new SqlParameter("@userType", SqlDbType.VarChar, 50);
            pr[3] = new SqlParameter("@FName", SqlDbType.VarChar, 50);
           

            pr[0].Value = id;
            pr[1].Value = pw;
            pr[2].Value = typeuser;
            pr[3].Value = fullname;
           
            dl.Execute("Add_user", pr);
            dl.Close();

        }
        public DataTable GetAllUsers(string Search_user)
        {
            DAL.DataAccessLayer dl = new DAL.DataAccessLayer();
            dl.open();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@Search_User",SqlDbType.VarChar,50);
            pr[0].Value = Search_user;
            
            DataTable dt = new DataTable();
            dt = dl.SelectData("GetAllUsers",pr);
            dl.Close();
            return dt;


        }
        public void Update_Users( string PS , string UserType,string Fname, string id)
        {
            DAL.DataAccessLayer dl = new DAL.DataAccessLayer();
            dl.open();
            SqlParameter[] pr = new SqlParameter[4];
           
            pr[0] = new SqlParameter("@PS", SqlDbType.VarChar, 50);
            pr[1] = new SqlParameter("@UserT", SqlDbType.VarChar, 50);
            pr[2] = new SqlParameter("@FName", SqlDbType.VarChar, 50);
            pr[3] = new SqlParameter("@T", SqlDbType.VarChar, 50);

           
            pr[0].Value = PS;
            pr[1].Value = UserType;
            pr[2].Value = Fname;
            pr[3].Value = id;
            dl.Execute("Update_Usersss",pr);
            dl.Close();

        }
        public void RemoveUser(string Delete)
        {
            DAL.DataAccessLayer dl = new DAL.DataAccessLayer();
            dl.open();
            SqlParameter[] pr = new SqlParameter[1];

            pr[0] = new SqlParameter("@Delete", SqlDbType.VarChar, 50);
      
            pr[0].Value = Delete;
           
            dl.Execute("RemoveUser", pr);
            dl.Close();

        }
        public DataTable SearchUsers(string Critiration)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@Critiration", SqlDbType.VarChar, 50);
            pr[0].Value = Critiration;

            DAL.DataAccessLayer dl = new DAL.DataAccessLayer();
            dl.open();
            DataTable dt = new DataTable();
            dt = dl.SelectData("SearchUsers", pr);
            dl.Close();
            return dt;
        }



    }
}

