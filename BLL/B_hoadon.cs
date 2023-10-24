using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class B_hoadon
    {
        public static B_hoadon _instance;
        public static B_hoadon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new B_hoadon();
                return _instance;
            }
        }
        public DataTable Table(DateTime dt)
        {
            return D_hoadon.Instance.Table(dt);
        }
        public DataTable Table_bill_daytoday(DateTime tungay, DateTime denngay)
        {
            return D_hoadon.Instance.Table_bill_daytoday(tungay,denngay);
        }
        public DataTable Table_detail_bill(string id_bill)
        {
            return D_hoadon.instance.Table_detail_bill(id_bill);
        }
        public DataTable Table_return_bill(string id_bill)
        {
            return D_hoadon.instance.Table_return_bill(id_bill);
        }
        public bool Delete (string id)
        {
            return D_hoadon.Instance.Delete(id);
        }
    }
}
