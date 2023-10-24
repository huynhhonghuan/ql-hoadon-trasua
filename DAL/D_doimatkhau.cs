using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_doimatkhau
    {
        public static D_doimatkhau _instance;
        public static D_doimatkhau Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new D_doimatkhau();
                }
                return _instance;
            }
        }
        public bool DoiMatKhau(string id_staff,string mkht, string mkm, string xnmk)
        {
            string sql = "update Account set Password='" + mkm + "' where Password='" + mkht + "' and Account_name=(select Account_name from Account where Id_staff='"+id_staff+"') and '" + mkm + "'='" + xnmk + "'";
            if(Connect.Instance.ThucThiCL(sql)==1)
                return true;
            return false;
        }
    }
}
