using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class B_SaoLuuPhucHoi
    {
        public static B_SaoLuuPhucHoi _instance;
        public static B_SaoLuuPhucHoi Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new B_SaoLuuPhucHoi();
                return _instance;
            }
        }
        public bool Backup(string tenbang, string duongdan)
        {
            return D_SaoLuuPhucHoi.Instance.Backup(tenbang, duongdan);
        }
        public bool Restore(string tenbang, string duongdan)
        {
            return D_SaoLuuPhucHoi.Instance.Restore(tenbang, duongdan);
        }
    }
}
