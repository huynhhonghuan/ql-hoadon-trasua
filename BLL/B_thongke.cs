using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class B_thongke
    {
        public static B_thongke _instance;
        public static B_thongke Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new B_thongke();
                return _instance;
            }
        }
        public List<Thongke_DTO> Thongke(string chon,DateTime ngaybd, DateTime ngaykt)
        {
            return D_thongke.Instance.Thongke(chon,ngaybd, ngaykt);
        }
        public DataTable DoanhThuHomNay(DateTime today)
        {
            return D_thongke.Instance.DanhThuHomNay(today);
        }
        public DataTable DanhThuDateToDate(DateTime to, DateTime from)
        {
            return D_thongke.Instance.DanhThuDateToDate(to,from);
        }
    }
}
