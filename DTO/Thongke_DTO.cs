using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thongke_DTO
    {
        private string id_type_product;
        private string name_type_product;
        
        private Decimal total;
        private DateTime date_bill;

        public DateTime Date_bill { get => date_bill; set => date_bill = value; }
        public decimal Total { get => total; set => total = value; }
        public string Id_type_product { get => id_type_product; set => id_type_product = value; }
        public string Name_type_product { get => name_type_product; set => name_type_product = value; }

        //thống kê theo ngày
        public Thongke_DTO(DateTime date_bill, decimal total)
        {
            this.date_bill = date_bill;
            this.total = total;
        }
        //thống kê theo tháng
        public Thongke_DTO(string name_type_product, decimal total)
        {
            this.name_type_product = name_type_product;
            this.total = total;
        }
        public Thongke_DTO(string id_type_product, string name_type_product, decimal total)
        {
            this.id_type_product = id_type_product;
            this.name_type_product = name_type_product;
            this.total = total;
        }
        //thống kê theo sản phẩm

    }
}
