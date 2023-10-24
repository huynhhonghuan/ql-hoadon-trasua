using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_menu
    {
        public static D_menu _instance;
        public static D_menu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new D_menu();
                return _instance;
            }
        }
        public DataTable Product()
        {
            string s = "select * from product";
            return Connect.Instance.get_DaTaTable(s);
        }
        public List<Menu_DTO> Product_Image(string type_product)
        {
            List<Menu_DTO> imageDataList = new List<Menu_DTO>();
            using (SqlConnection conn = Connect.Instance.GetSqlConnection())
            {
                //conn.Open();
                using (SqlCommand cmd = new SqlCommand()) 
                { 
                    cmd.Connection = conn;
                    cmd.CommandText = "select id_product,name_product,fare,img_product from product where id_type_product='"+type_product+"'";
                    //cmd.Parameters.AddWithValue("img_product", truyenvao);
                    using(SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if(reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Menu_DTO mn = new Menu_DTO((string)reader["id_product"],(string)reader["name_product"],(decimal)reader["fare"], (byte[])reader["img_product"]);
                                imageDataList.Add(mn);
                            }
                        }
                    }
                }
            }
            return imageDataList;
        }
        public bool Insert_bill(Menu_DTO mn)
        {
            string s = "insert into bill values('"+mn.Ngay+"','"+mn.Id+"','"+mn.Sotien+"')";
            return Connect.Instance.Excute(s);
        }
        public bool Insert_detail_bill(Menu_DTO mn)
        {
            string s = "insert into detail_bill values((select Max(id_bill) from Bill),'" + mn.Id + "', " + mn.Soluong + "," + mn.Giamgia + "," + mn.Sotien + ")";
            return Connect.Instance.Excute(s);
        }
        public bool Update_bill()
        {
            string ss = "update bill set total = (select Sum((Total - (id_discount*total/100))*Quantity) as total from Detail_bill where Id_bill=(select Max(id_bill) from Bill)) where Id_bill=(select Max(id_bill) from Bill)";
            return Connect.Instance.Excute(ss);
        }
        public int id_bill()
        {
            string s = "select Max(id_bill) as id_bill from Bill";
            return Convert.ToInt32(Connect.Instance.get_DaTaTable(s).Rows[0]["id_bill"].ToString());
        }
    }
}
