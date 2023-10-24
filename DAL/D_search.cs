using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_search
    {
        public static D_search _instance;
        public static D_search Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new D_search();
                return _instance;
            }
        }
        public List<Menu_DTO> Search(string s)
        {
            List<Menu_DTO> imageDataList = new List<Menu_DTO>();
            using (SqlConnection conn = Connect.Instance.GetSqlConnection())
            {
                //conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select id_product,name_product,fare,img_product from product where name_product like N'%" + s + "%'";
                    //cmd.Parameters.AddWithValue("img_product", truyenvao);
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Menu_DTO mn = new Menu_DTO((string)reader["id_product"], (string)reader["name_product"], (decimal)reader["fare"], (byte[])reader["img_product"]);
                                imageDataList.Add(mn);
                            }
                        }
                    }
                }
            }
            return imageDataList;
        }
        public DataTable Type_product(string id)
        {
            string s = "select name_product,id_type_product from product where id_product ='" + id + "'";
            return Connect.Instance.get_DaTaTable(s);
        }
    }
}
