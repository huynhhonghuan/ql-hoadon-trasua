using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class B_chitiethoadon
    {
        public static B_chitiethoadon instance;
        public static B_chitiethoadon Instance
        {
            get
            {
                if (instance == null)
                    instance = new B_chitiethoadon();
                return instance;
            }
        }
        public DataTable Load_ComboBox()
        {
            return D_chitiethoadon.Instance.Load_ComboBox();
        }
        public object Load(string id_bill, string name)
        {
            return D_chitiethoadon.Instance.Load(id_bill, name);
        }
        public DataTable table(string name_table)
        {
            return D_chitiethoadon.Instance.table(name_table);
        }
        public SqlDataAdapter adapter()
        {
            return D_chitiethoadon.Instance.adapter();
        }
        public DataSet dataset()
        {
            return D_chitiethoadon.Instance.dataset();
        }
        public int Insert(string name_table)
        {
            return D_chitiethoadon.Instance.Insert(name_table);
        }
        public void Update(string name_table, string name_where)
        {
            D_chitiethoadon.Instance.Update(name_table,name_where);
        }
        public void Delete(string name_table, string name_where)
        {
            D_chitiethoadon.Instance.Delete(name_table, name_where);
        }
    }
}
