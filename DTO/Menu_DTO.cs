using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Menu_DTO
    {
        
        private string tensp;
       
        private byte[] image;
    
        private DateTime ngay;

        private string id;
        private int soluong;
        private int giamgia;
        private decimal sotien;


        //Load hinh
        public Menu_DTO(string id,string tensp, decimal sotien, byte[] image)
        {
            this.id = id;
            this.tensp = tensp;
            this.sotien = sotien;
            this.image = image;
        }
        //insert bill
        public Menu_DTO(DateTime ngay, string id, decimal sotien)
        {
            this.Ngay = ngay;
            this.id = id;
            this.sotien = sotien;
        }
        //insert detail bill
        public Menu_DTO(string id, int soluong, int giamgia, decimal sotien)
        {
            this.id = id;
            this.soluong = soluong;
            this.giamgia = giamgia;
            this.sotien = sotien;
        }

        public string Id { get => id; set => id = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public decimal Sotien { get => sotien; set => sotien = value; }
        public byte[] Image { get => image; set => image = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Giamgia { get => giamgia; set => giamgia = value; }
    }
}
