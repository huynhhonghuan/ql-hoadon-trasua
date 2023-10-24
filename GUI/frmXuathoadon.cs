using BLL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmXuathoadon : Form
    {
        private int id_bill;
        public frmXuathoadon(int id_bill)
        {
            InitializeComponent();
            this.id_bill = id_bill;
        }

        private void frmXuathoadonForm1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            xuathoadon(id_bill);
        }
        private void xuathoadon(int id_bill)
        {
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.LocalReport.ReportEmbeddedResource = "Report2.rdlc";
            if (B_baocao.Instance.Hoadon(id_bill).Tables["Hoadon"].Rows.Count > 0)
            {
                ReportDataSource rpdts = new ReportDataSource();
                rpdts.Name = "DataSet1";
                rpdts.Value = B_baocao.Instance.Hoadon(id_bill).Tables["Hoadon"];
                reportViewer1.LocalReport.ReportPath = @"D:\HK6\LTQL\Lamdoan\QL_HD_TRA_SUA\GUI\Report2.rdlc";
                //reportViewer1.LocalReport.ReportPath = "Report6.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rpdts);
                reportViewer1.RefreshReport();
            }
            else
            {
                reportViewer1.Show();
                MessageBox.Show("Không có nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
