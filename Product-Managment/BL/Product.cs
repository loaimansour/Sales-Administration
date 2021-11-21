using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Product_Managment.BL
{
    public class Product
    {
        public DataTable Get_ALL_CATEGORY()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Get_ALL_CATEGORY",null);

            return dt; 
        }

       





        public void AddNew_Product(int id_cat  , string id_prod , string price , string Label , int qty ,byte [] img)
        {
            DAL.DataAccessLayer D = new DAL.DataAccessLayer();
            D.open();
            SqlParameter[] para = new SqlParameter[6];
            para[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            para[1] = new SqlParameter("@ID_PRODUCT",SqlDbType.VarChar,30);
            para[2] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            para[3] = new SqlParameter("@LABEL_PROD", SqlDbType.VarChar, 30);
            para[4] = new SqlParameter("@QTY", SqlDbType.Int);
            para[5] = new SqlParameter("@iMAGE", SqlDbType.Image);

            para[0].Value = id_cat;
            
            para[1].Value = id_prod;
            para[2].Value = price;
            para[3].Value = Label;
            para[4].Value = qty;
            para[5].Value = img;

            
            D.Execute("AddNewProduct", para);
            D.Close();

        }

        public DataTable SelectAll_Product()
        {
            DAL.DataAccessLayer d = new DAL.DataAccessLayer();
            d.open();
            DataTable dt = new DataTable();

            dt = d.SelectData("SelectAll_Product",null);
            return dt;

        }
         DAL.DataAccessLayer d = new DAL.DataAccessLayer();
        public void Delete_Produuct(string Delete)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@Delete",SqlDbType.VarChar,50);
            p[0].Value = Delete;
           
            d.open();
            d.SelectData("Delete_Produuct", p);
            d.Close();
        }

        public DataTable Result_search(string Search)
        {
            DataTable t = new DataTable();

            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Search",SqlDbType.VarChar,50);
            para[0].Value = Search; 
           
           return t =  d.SelectData("Result_search",para);
            d.Close();
        }

        public void Update_Prode(string id_pr , string label , int qty , string pric , byte[] img, int id_cat)
        {
            DAL.DataAccessLayer d = new DAL.DataAccessLayer();
            d.open();
            SqlParameter[] sqlpr = new SqlParameter[6];
            sqlpr[0] = new SqlParameter("@Id_prod",SqlDbType.VarChar,30);
            sqlpr[0].Value = id_pr;

            sqlpr[1] = new SqlParameter("@Lable_prod", SqlDbType.VarChar, 30);
            sqlpr[1].Value = label;

            sqlpr[2] = new SqlParameter("@Qty", SqlDbType.Int);
            sqlpr[2].Value = qty;

            sqlpr[3] = new SqlParameter("@Price", SqlDbType.VarChar, 50);
            sqlpr[3].Value = pric;
            
            sqlpr[4] = new SqlParameter("@Img", SqlDbType.Image);
            sqlpr[4].Value = img;

            sqlpr[5] = new SqlParameter("@ID_cat", SqlDbType.Int);
            sqlpr[5].Value = id_cat;

            d.Execute("Update_Prode", sqlpr);
            d.Close();

        }

    }
}
