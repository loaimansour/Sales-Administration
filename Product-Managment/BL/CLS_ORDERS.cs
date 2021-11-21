using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Product_Managment.BL
{
    class CLS_ORDERS
    {
        public DataTable Get_NumInvoice()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt =  dal.SelectData("GET_LAST_ORDER_ID",null);
            dal.Close();
            return dt;
        }
        public DataTable GET_LAST_ORDER_ForPrint()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GET_LAST_ORDER_ForPrint", null);
            dal.Close();
            return dt;
        }
        public DataTable Search_Order(string Critiration)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@Critiration",SqlDbType.VarChar,50);
            pr[0].Value = Critiration;

            DAL.DataAccessLayer dl = new DAL.DataAccessLayer();
            dl.open();
            DataTable dt = new DataTable();
            dt = dl.SelectData("Search_Orderr", pr);
            dl.Close();
            return dt;
        }


    }
}
