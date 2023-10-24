using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class D_chitiethoadon
    {
        public static D_chitiethoadon instance;
        public static D_chitiethoadon Instance
        {
            get
            {
                if (instance == null)
                    instance = new D_chitiethoadon();
                return instance;
            }
        }
        public DataTable Load_ComboBox()
        {
            string s = "select id_product,name_product,fare from product";
            return Connect.Instance.get_DaTaTable(s);
        }
        public object Load(string id_bill, string name_table)
        {
            string s = "select ROW_NUMBER() OVER (ORDER BY d.Id_detail_bill) AS STT,d.Id_bill,d.Id_detail_bill,p.Name_product,d.quantity,d.Id_discount,Format(d.total,'#,##0') as total from " + name_table+" d, product p where id_bill ='" + id_bill + "' and d.id_product=p.id_product";
            return Connect.Instance.getdata(s,name_table);
        }
        public DataTable table(string name_table)
        {
            return Connect.Instance.GetTable(name_table);
        }
        public SqlDataAdapter adapter()
        {
            return Connect.Instance.Adapter();
        }
        public DataSet dataset()
        {
            return Connect.Instance.dataset();
        }
        public int Insert(string name_table)
        {
            string ss = "IF NOT EXISTS(SELECT * FROM "+name_table+" WHERE id_product = @id_product) BEGIN INSERT INTO "+name_table+ " VALUES(@id_bill,@id_product,@quantity,@id_discount,@total) END";
            //string s = "insert into " + name_table + " values(@id_bill,@id_product,@quantity,@id_discount,@total)";
            SqlParameter[] sp = new SqlParameter[5];
            sp[0] = new SqlParameter("@id_bill", SqlDbType.Int, 5, "id_bill");
            sp[1] = new SqlParameter("@id_product", SqlDbType.NVarChar, 5, "id_product");
            sp[2] = new SqlParameter("@quantity", SqlDbType.Int, 5, "quantity");
            sp[3] = new SqlParameter("@id_discount", SqlDbType.Int, 5, "id_discount");
            sp[4] = new SqlParameter("@total", SqlDbType.Money, 10, "total");
            return Connect.Instance.ExcuteNonQuery(ss, sp);
        }
        public void Update(string name_table, string name_where)
        {
            string s = "update " + name_table + " set id_bill=@id_bill,id_product=@id_product,quantity=@quantity,id_discount=@id_discount,total=@total where "+name_where+" =@"+name_where+"";
            SqlParameter[] sp = new SqlParameter[6];
            sp[0] = new SqlParameter("@id_bill", SqlDbType.Int, 5, "id_bill");
            sp[1] = new SqlParameter("@id_product", SqlDbType.NVarChar, 5, "id_product");
            sp[2] = new SqlParameter("@quantity", SqlDbType.Int, 5, "quantity");
            sp[3] = new SqlParameter("@id_discount", SqlDbType.Int, 5, "id_discount");
            sp[4] = new SqlParameter("@total", SqlDbType.Money, 10, "total");
            sp[5] = new SqlParameter("@"+name_where+"", SqlDbType.Int, 5, name_where);
            Connect.Instance.Update(s, sp);
        }
        public void Delete(string name_table, string name_where)
        {
            string s = "delete from " + name_table + " where "+name_where+" = @"+name_where+"";
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@"+name_where+"", SqlDbType.Int, 5, name_where);
            Connect.Instance.Delete(s, sp);
        }
        
    }
}
