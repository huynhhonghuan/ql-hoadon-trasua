using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_hoadon
    {
        public static D_hoadon instance;
        public static D_hoadon Instance
        {
            get
            {
                if (instance == null)
                    instance = new D_hoadon();
                return instance;
            }
        }
        public DataTable Table(DateTime dt)
        {
            string s = "select ROW_NUMBER() OVER (ORDER BY b.Id_bill) AS stt,b.id_bill,b.Date_bill,s.name_staff,Format(b.Total,'#,##0') as total from Bill b, Staff s where b.Date_bill ='" + dt + "' and b.id_staff=s.id_staff";
            return Connect.Instance.get_DaTaTable(s);
        }
        public DataTable Table_bill_daytoday(DateTime tungay, DateTime denngay)
        {
            string s = "select ROW_NUMBER() OVER (ORDER BY b.Id_bill) AS stt,b.id_bill,b.Date_bill,s.name_staff,Format(b.Total,'#,##0') as total from Bill b, Staff s where b.Date_bill >='" + tungay + "' and b.Date_bill <='" + denngay + "' and b.id_staff=s.id_staff";
            return Connect.Instance.get_DaTaTable(s);
        }
        public DataTable Table_detail_bill(string id_bill) 
        {
            string s = "select ROW_NUMBER() OVER (ORDER BY d.Id_detail_bill) AS STT,d.Id_bill,d.Id_detail_bill,p.Name_product,d.quantity,d.Id_discount,Format(d.total,'#,##0') as total from Detail_bill d,Product p where id_bill ='" + id_bill + "' and d.Id_product=p.Id_product";
            return Connect.Instance.get_DaTaTable(s);
        }
        public DataTable Table_return_bill(string id_bill)
        {
            string s = "select ROW_NUMBER() OVER (ORDER BY d.Id_return_bill) AS STT,d.Id_bill,d.Id_return_bill,p.Name_product,d.quantity,d.Id_discount,Format(d.total,'#,##0') as total from Return_bill d,Product p where id_bill ='" + id_bill + "' and d.Id_product=p.Id_product";
            return Connect.Instance.get_DaTaTable(s);
        }
        public bool Delete(string id_bill)
        {
            string s = "delete from bill where id_bill='" + id_bill + "'";
            return Connect.Instance.Excute(s);
        }
    }
}
