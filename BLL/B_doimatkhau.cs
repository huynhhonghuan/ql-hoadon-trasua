using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class B_doimatkhau
    {
        public static B_doimatkhau _instance;
        public static B_doimatkhau Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new B_doimatkhau();
                }
                return _instance;
            }
        }
        public bool DoiMatKhau(string id_staff, string mkht, string mkm, string xnmk)
        {
            return D_doimatkhau.Instance.DoiMatKhau(id_staff, mkht, mkm, xnmk);
        }
    }
}
