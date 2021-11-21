using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Product_Managment.DAL
{
      public class DataAccessLayer
    {
        SqlConnection sqlconnection;

        public  DataAccessLayer()
        {
           sqlconnection = new SqlConnection("SERVER = DESKTOP-F7JRQN2 ; DATABASE = Product;Integrated Security = true");
        }

        public void open()
        {
            if(sqlconnection.State!=ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }

        public void Close()
        {
            if (sqlconnection.State==ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        public DataTable SelectData(string stored_procedure,SqlParameter[]param)
        {
           
            SqlCommand sqlcmd = new SqlCommand();
            
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;



            if (param!=null)
            {
              for (int i = 0; i<param.Length ;i++)
            {
                sqlcmd.Parameters.Add(param[i]);
            }

            }

            SqlDataAdapter ada = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            return dt;


        }

        public void Execute(string stored_procedur , SqlParameter[]param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedur;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
              sqlcmd.Parameters.AddRange(param);
            }
            

            sqlcmd.ExecuteNonQuery();
        }
    }
}
