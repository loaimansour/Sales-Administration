using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Product_Managment.BL
{
    class Catagory
    {

  public void Add_new_Catagory(string Desc)
        {
            DAL.DataAccessLayer DL = new DAL.DataAccessLayer();
            DL.open();
            SqlParameter[] pr = new SqlParameter[1];

            
            pr[0] = new SqlParameter("@Desc",SqlDbType.VarChar,25);

          
            pr[0].Value = Desc;

           
            DL.Execute("Add_Catagory", pr);
            DL.Close();
        }

    }
}
