using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Product_Managment.BL
{
    public class ORDER
    {
        
        public  void ADD_ORDER(int id_order ,DateTime date , int Id_cust, string Desc , string SalesMan)
        {
            
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("@ID_ORDER",SqlDbType.Int);
            pr[1] = new SqlParameter("@DATE",SqlDbType.DateTime);
            pr[2] = new SqlParameter("@CUST_ID",SqlDbType.Int);
            pr[3] = new SqlParameter("@DESC",SqlDbType.VarChar,250);
            pr[4] = new SqlParameter("@SALES_MAN", SqlDbType.VarChar, 75);

            pr[0].Value = id_order;
            pr[1].Value = date;
            pr[2].Value = Id_cust ;
            pr[3].Value = Desc;
            pr[4].Value = SalesMan;

            DAL.DataAccessLayer da = new DAL.DataAccessLayer();
            da.open();
            da.Execute("ADD_ORDER",pr);
            da.Close();

        }
        public void ADD_ORDER_DETAILS(String  id_PRODUCT, int id_order, int qty, string price, double Dicount ,string  Amount ,string T_Amount,string id_ch)
        {
            SqlParameter[] pr = new SqlParameter[8];
            pr[0] = new SqlParameter("@ID_PRODUCTT", SqlDbType.VarChar,30);
            pr[1] = new SqlParameter("@ID_ORDERR", SqlDbType.Int);
            pr[2] = new SqlParameter("@QTYY", SqlDbType.Int);
            pr[3] = new SqlParameter("@PRICEE", SqlDbType.VarChar, 50);
            pr[4] = new SqlParameter("@DICOUNTT", SqlDbType.Float);
            pr[5] = new SqlParameter("@AMOUNTT", SqlDbType.VarChar, 50);
            pr[6] = new SqlParameter("@TOTAL_AMOUNTT", SqlDbType.VarChar, 50);
            pr[7] = new SqlParameter("@ID_ch", SqlDbType.VarChar, 30);

            pr[0].Value = id_PRODUCT;
            pr[1].Value = id_order;
            pr[2].Value = qty;
            pr[3].Value = price;
            pr[4].Value = Dicount;
            pr[5].Value = Amount;
            pr[6].Value = T_Amount;
            pr[7].Value = id_ch;

            DAL.DataAccessLayer da = new DAL.DataAccessLayer();
            da.open();
            da.Execute("ADD_ORDER_DETAILS", pr);
            da.Close();

        }
        public DataTable VerifyQty(string id_product , int Qt)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
            pr[1] = new SqlParameter("@QTY_Entered", SqlDbType.Int);

            pr[0].Value = id_product;
            pr[1].Value = Qt;
            DAL.DataAccessLayer dl = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dl.SelectData("VerifyQty", pr);
            return dt;

        }
        public DataTable GetOrderDetils(int id_Order)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            

            pr[0].Value = id_Order;
          
            DAL.DataAccessLayer dl = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dl.SelectData("GetOrderDetils", pr);
            return dt;

        }


    }
}
