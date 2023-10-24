using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class B_baocao
    {
        public static B_baocao instance;
        public static B_baocao Instance
        {
            get
            {
                if (instance == null)
                    instance = new B_baocao();
                return instance;
            }
        }
        public DataTable Table_bill_daytoday(DateTime tungay, DateTime denngay)
        {
            return D_baocao.Instance.Table_bill_daytoday(tungay, denngay);
        }
        public DataSet Doanhthu(DateTime bd, DateTime kt)
        {
            return D_baocao.Instance.Baocao(bd, kt);
        }
        public DataSet Doanhthu_tong(DateTime bd, DateTime kt)
        {
            return D_baocao.Instance.Baocao_tongbill(bd, kt);
        }
        public DataSet Hoadon(int id_bill)
        {
            return D_baocao.Instance.Baocao_hoadon(id_bill);
        }
    }
}
