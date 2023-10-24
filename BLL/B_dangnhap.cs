using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class B_dangnhap
    {
        public static B_dangnhap _instance;
        public static B_dangnhap Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new B_dangnhap();
                return _instance;
            }
        }
        public DataTable Login(string username, string password)
        {
            if (D_dangnhap.Instance.Login(username, password).Rows.Count == 1)
            {
                return D_dangnhap.Instance.Login(username, password);
            }
            return null;
        }
    }
}
