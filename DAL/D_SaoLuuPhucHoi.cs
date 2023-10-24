using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_SaoLuuPhucHoi
    {
        public static D_SaoLuuPhucHoi _instance;
        public static D_SaoLuuPhucHoi Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new D_SaoLuuPhucHoi();
                return _instance;
            }
        }
        public bool Backup(string tendb, string duongdan)
        {
            string sTen = "\\QLHD(" + DateTime.Now.Day.ToString() + "_" +
                 DateTime.Now.Month.ToString() + "_" +
                 DateTime.Now.Year.ToString() + "_" +
                 DateTime.Now.Hour.ToString() + "_" +
                 DateTime.Now.Minute.ToString() + ").bak";
            string sql = "BACKUP DATABASE [" + tendb + "] TO DISK =N'" + duongdan + sTen + "'";
            return Connect.Instance.Excute(sql);
        }
        public bool Restore(string tendb, string duongdan)
        {
            try
            {
                string sql = "alter database [" + tendb + "] set single_user with rollback immediate";
                string sql1 = "use master restore database [" + tendb + "] from disk ='" + duongdan + "' with replace";
                string sql2 = "alter database [" + tendb + "] set multi_user";
                if (Connect.Instance.Excute(sql) == false || Connect.Instance.Excute(sql1) == false || Connect.Instance.Excute(sql2) == false)
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
