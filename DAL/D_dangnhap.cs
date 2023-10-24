using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_dangnhap
    {
        public static D_dangnhap _instance;
        public static D_dangnhap Instance
        {
            get { 
                if(_instance == null)
                    _instance = new D_dangnhap();
                return _instance; 
            }
        }
        public DataTable Login(string username, string password)
        {
            string s = "select s.name_staff,a.* from staff s,account a where a.account_name ='" + username + "' and a.password = '" + password + "' and s.id_staff=a.id_staff";
            return Connect.Instance.get_DaTaTable(s);
        }
    }
}
