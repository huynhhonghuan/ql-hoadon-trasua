using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_thongke
    {
        public static D_thongke _instance;
        public static D_thongke Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new D_thongke();
                }
                return _instance;
            }
        }
        public List<Thongke_DTO> Thongke(string chon, DateTime ngaybd, DateTime ngaykt)
        {
            string s = "select * from  " + chon + " (@ngaybd,@ngaykt)";
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@ngaybd", SqlDbType.Date);
            para[0].Value = ngaybd;
            para[1] = new SqlParameter("@ngaykt", SqlDbType.Date);
            para[1].Value = ngaykt;

            List<Thongke_DTO> lst = new List<Thongke_DTO>();
            Thongke_DTO tk;
            using (SqlDataReader reader = Connect.Instance.ExcuteReader(s, para).ExecuteReader(CommandBehavior.CloseConnection))
            {
                if (chon == "Fun_ThongKe_Bill_TheoNgay")
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tk = new Thongke_DTO(Convert.ToDateTime(reader["date_bill"]), Convert.ToDecimal(reader["total"]));
                            lst.Add(tk);
                        }
                    }
                }
                if (chon == "Fun_ThongKe_Bill_TheoSP")
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tk = new Thongke_DTO(Convert.ToString(reader["id_type_product"]), Convert.ToString(reader["name_type_product"]), Convert.ToDecimal(reader["total"]));
                            lst.Add(tk);
                        }
                    }
                }
                if (chon == "Fun_ThongKe_Bill_TheoThang")
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tk = new Thongke_DTO(Convert.ToString(reader["month"]), Convert.ToDecimal(reader["total"]));
                            lst.Add(tk);
                        }
                    }
                }
            }
            return lst;
        }
        public DataTable DanhThuHomNay(DateTime today)
        {
            string sql = "select COALESCE(sum(Bill.total),0) as total,count(Bill.Id_bill) as quantity_bill,\r\n\t(select count(Detail_bill.Id_detail_bill)\r\n\tfrom Bill, Detail_bill \r\n\twhere Bill.Id_bill=Detail_bill.Id_bill\r\n\tand Bill.Date_bill='" + today + "') as quantity_product\r\nfrom Bill\r\nwhere Bill.Date_bill='" + today + "'";
            return Connect.Instance.get_DaTaTable(sql);
        }
        public DataTable DanhThuDateToDate(DateTime to,  DateTime from)
        {
            string sql = "select COALESCE(sum(Bill.total),0) as total,count(Bill.Id_bill) as quantity_bill,\r\n(select count(Detail_bill.Id_detail_bill)\r\nfrom Bill, Detail_bill \r\nwhere Bill.Id_bill=Detail_bill.Id_bill\r\nand Bill.Date_bill between '" + to + "'\r\nand '" + from + "') as quantity_product\r\nfrom Bill\r\nwhere Bill.Date_bill between '" + to + "'\r\nand '" + from + "'";
            return Connect.Instance.get_DaTaTable(sql);
        }
    }
}
