using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        
        
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            cbbChon.Texts = cbbChon.Items[0].ToString();
            cbbThang.Texts = cbbThang.Items[0].ToString();
            Load_Combobox_Nam();
            cbbNam.Texts = cbbNam.Items[vitri].ToString();

            btnHomnay_Click(sender, e);
            Danhthu("HÔM NAY",B_thongke.Instance.DoanhThuHomNay(DateTime.Today));
        }
        int vitri = -1;
        private void Load_Combobox_Nam()
        {
            for (int i = 2010; i <= DateTime.Now.Year; i++)
            {
                cbbNam.Items.Add(i.ToString());
                vitri++;
            }
        }
        private void Danhthu(string chude,DataTable dt)
        {
            DataRow dr = dt.Rows[0];

            lblDT.Text = "DANH THU \n"+chude;
            lblTSP.Text = "TỔNG SẢN PHẢM BÁN \n" + chude;
            lblSLHD.Text = "SỐ LƯỢNG HÓA ĐƠN \n" + chude;

            lbldanhthuhomnay.Text = Decimal.Parse(dr["total"].ToString()).ToString("#,##0");
            lbltongsanpham.Text = dr["quantity_product"].ToString();
            lblsoluonghoadon.Text = dr["quantity_bill"].ToString();
        }
        private void ThongKe(string tendoanhthu,string ten_ngay,string chon,DateTime ngaybd,DateTime ngaykt)
        {
            chart1.Series.Clear();
            Series series1 = new Series("Doanh thu (VND)");
            chart1.Titles.Clear();
            Title title = new Title();
            int i = 0;
            if (chon=="Fun_ThongKe_Bill_TheoNgay")
            {
                foreach (Thongke_DTO item in B_thongke.Instance.Thongke(chon, ngaybd, ngaykt))
                {
                    series1.Points.Add(Convert.ToDouble(item.Total)); 
                    series1.Points[i].AxisLabel = item.Date_bill.ToString("dd/MM/yyyy");
                    series1.Points[i].Label = item.Total.ToString("#,##0");
                    i++;
                }
                title.Text = "DOANH THU THEO " + tendoanhthu + " " + ten_ngay;
                Danhthu(ten_ngay, B_thongke.Instance.DanhThuDateToDate(ngaybd,ngaykt));
            }
            if(chon=="Fun_ThongKe_Bill_TheoSP" && dieukien=="theongay")
            {
                series1.ChartType = SeriesChartType.Doughnut;
                Random random = new Random();
            
                foreach (Thongke_DTO item in B_thongke.Instance.Thongke(chon, ngaybd, ngaykt))
                {
                    Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    series1.Points.Add(Convert.ToDouble(item.Total));
                    //series1.Points[i].Color=randomColor;
                    series1.Points[i].Label = item.Total.ToString("#,##0");
                    series1.Points[i].AxisLabel = item.Name_type_product;
                    series1.Points[i].LegendText = item.Name_type_product;
                    i++;
                }
                title.Text = "DOANH THU THEO " + tendoanhthu + " " + ten_ngay;
                Danhthu(ten_ngay, B_thongke.Instance.DanhThuDateToDate(ngaybd, ngaykt));
            }
            if (chon == "Fun_ThongKe_Bill_TheoThang")
            {
                foreach (Thongke_DTO item in B_thongke.Instance.Thongke(chon, ngaybd, ngaykt))
                {
                    series1.Points.Add(Convert.ToDouble(item.Total));
                    series1.Points[i].AxisLabel = item.Name_type_product;
                    series1.Points[i].Label = item.Total.ToString("#,##0");
                    i++;
                }
                title.Text = "DOANH THU " + ten_ngay;
            }
            if (chon == "Fun_ThongKe_Bill_TheoSP" && dieukien=="theothang")
            {
                series1.ChartType = SeriesChartType.Doughnut;
                Random random = new Random();

                foreach (Thongke_DTO item in B_thongke.Instance.Thongke(chon, ngaybd, ngaykt))
                {
                    Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    series1.Points.Add(Convert.ToDouble(item.Total));
                    //series1.Points[i].Color=randomColor;
                    series1.Points[i].Label = item.Total.ToString("#,##0");
                    series1.Points[i].AxisLabel = item.Name_type_product;
                    series1.Points[i].LegendText = item.Name_type_product;
                    series1.LabelToolTip = item.Name_type_product;
                    i++;
                }
                title.Text = "DOANH THU THEO " + tendoanhthu + " " + ten_ngay;
                Danhthu(ten_ngay, B_thongke.Instance.DanhThuDateToDate(ngaybd, ngaykt));
            }

            title.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            chart1.Titles.Add(title);
            chart1.Series.Add(series1);
        }
        string dieukien = "";

        private string Chon_Thongke()
        {
            if (cbbChon.Texts == "Ngày")
                return "Fun_ThongKe_Bill_TheoNgay";
            if (cbbChon.Texts== "Sản phẩm")
            {
                dieukien = "theongay";
                return "Fun_ThongKe_Bill_TheoSP";
            }
            return "";
        }
        private string Chon_Thongke_Thang()
        {
            if (cbbChon.Texts == "Ngày")
                return "Fun_ThongKe_Bill_TheoThang";
            if (cbbChon.Texts == "Sản phẩm")
            {
                dieukien = "theothang";
                return "Fun_ThongKe_Bill_TheoSP";
            }
            return "";
        }
        private void btnHomnay_Click(object sender, EventArgs e)
        {
            ThongKe(cbbChon.Texts.ToUpper(), btnHomnay.Text.ToUpper(),Chon_Thongke(),DateTime.Today,DateTime.Today);
        }

        private void btn7ngay_Click(object sender, EventArgs e)
        {
            ThongKe(cbbChon.Texts.ToUpper(), btn7ngay.Text.ToUpper(), Chon_Thongke(), DateTime.Today.AddDays(-6), DateTime.Today);
        }

        private void btn14ngay_Click(object sender, EventArgs e)
        {
            ThongKe(cbbChon.Texts.ToUpper(), btn14ngay.Text.ToUpper(), Chon_Thongke(), DateTime.Today.AddDays(-13), DateTime.Today);
        }

        private void btn30ngay_Click(object sender, EventArgs e)
        {
            ThongKe(cbbChon.Texts.ToUpper(), btn30ngay.Text.ToUpper(), Chon_Thongke(), DateTime.Today.AddDays(-29), DateTime.Today);
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            string tenthongke = "TỪ THÁNG 1 ĐẾN THÁNG " + cbbThang.Texts.Substring(0,2).ToUpper() + " NĂM " + cbbNam.Texts;
            DateTime thoigianbd = DateTime.Parse("01/01/" + cbbNam.Texts);
            DateTime thoigiankt = DateTime.Parse(cbbThang.Texts.Substring(0, 2) + "/01/" + cbbNam.Texts);
            ThongKe(cbbChon.Texts.ToUpper(), tenthongke, Chon_Thongke_Thang(), thoigianbd, thoigiankt);

            string tentk = "THÁNG 1 - " + cbbThang.Texts.Substring(0,2)+"/"+ cbbNam.Texts;
            Danhthu(tentk, B_thongke.Instance.DanhThuDateToDate(thoigianbd, thoigiankt));
        }
    }
}
