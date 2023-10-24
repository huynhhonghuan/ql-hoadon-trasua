using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_baocao
    {
        public static D_baocao _instance;
        public static D_baocao Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new D_baocao();
                return _instance;
            }
        }
        public DataTable Table_bill_daytoday(DateTime tungay, DateTime denngay)
        {
            string s = "select ROW_NUMBER() OVER (ORDER BY Id_bill) AS stt,Bill.id_bill,Bill.Date_bill,Bill.id_staff,Format(Bill.Total,'#,##0') as total from Bill where Date_bill >='" + tungay + "' and Date_bill <='" + denngay + "'";
            return Connect.Instance.get_DaTaTable(s);
        }
        public DataSet Baocao(DateTime bd, DateTime kt)
        {
            string s = "select Date_bill,Total from Fun_ThongKe_Bill_TheoNgay ('" + bd+"','"+kt+"')";
            return Connect.Instance.getdataset(s,"Bill");
        }
        public DataSet Baocao_tongbill(DateTime bd, DateTime kt)
        {
            string s = "select  Format(sum(Bill.total),'#,##0') as total1 " +
                "from(select MONTH(date_bill) as month, sum(total) as total from Bill" +
                "where Date_bill >= '"+bd+"' and Date_bill <= '"+kt+"'" +
                "group by MONTH(date_bill)) as Bill";
            return Connect.Instance.getdataset(s, "Bill_tong");
        }
        public DataSet Baocao_hoadon(int id_bill)
        {
            string s = "SELECT Bill.Id_bill, Bill.Date_bill, Staff.Name_staff, Product.Name_product, Product.Fare, Detail_bill.Quantity, Detail_bill.Id_discount, Format(Detail_bill.Total,'#,##0') as Total,Format(Bill.Total,'#,##0') as Total_fare FROM     Bill INNER JOIN                Detail_bill ON Bill.Id_bill = Detail_bill.Id_bill AND Bill.Id_bill = Detail_bill.Id_bill INNER JOIN Product ON Detail_bill.Id_product = Product.Id_product INNER JOIN Staff ON Bill.Id_staff = Staff.Id_staff " +
                "where Bill.Id_bill="+id_bill+"";
            return Connect.Instance.getdataset(s, "Hoadon");
        }
    }
}
