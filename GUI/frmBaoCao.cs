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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            Load_Combobox_Nam();
            btnChon_Click(sender, e);
            this.reportViewer1.RefreshReport();
        }
        private void Load_RV(DataSet ds)
        {
            //reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            //reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.LocalReport.ReportEmbeddedResource = "Report1.rdlc";
            if (ds.Tables["Bill"].Rows.Count > 0)
            {
                ReportDataSource rpdts = new ReportDataSource();
                rpdts.Name = "DataSet1";
                rpdts.Value = ds.Tables["Bill"];
                reportViewer1.LocalReport.ReportPath = @"D:\HK6\LTQL\Lamdoan\QL_HD_TRA_SUA\GUI\Report1.rdlc";
                //reportViewer1.LocalReport.ReportPath = "Report6.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rpdts);
                reportViewer1.RefreshReport();
            }
            else
            {
                reportViewer1.Show();
                MessageBox.Show("Không có doanh thu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Load_Combobox_Nam()
        {
            for (int i = 2010; i <= DateTime.Now.Year; i++)
            {
                CbbNam.Items.Add(i.ToString());
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (CbbThang.Texts != "" && CbbNam.Texts != "")
            {
                DateTime bd = DateTime.Parse(CbbThang.Texts + "/01/" + CbbNam.Texts);
                DateTime kt = DateTime.Parse(CbbThang.Texts + "/30/" + CbbNam.Texts);
                Load_RV(B_baocao.Instance.Doanhthu(bd, kt));
            }
            else
                MessageBox.Show("Hãy chọn ngày tháng để report dữ liệu!");
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = B_baocao.Instance.Table_bill_daytoday(dtpTu.Value, dtpDen.Value);
            dataGridView1.Columns["id_bill"].Visible = false;
            dataGridView1.Columns["stt"].HeaderText = "STT";
            dataGridView1.Columns["Date_bill"].HeaderText = "Ngày lập biêu";
            dataGridView1.Columns["Id_staff"].Visible = false;
            //dataGridView1.Columns["Name_staff"].HeaderText = "t nhân viên";
            dataGridView1.Columns["total"].HeaderText = "Tổng tiền";
        }
        int id_bill;

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int i=dataGridView1.CurrentRow.Index;
                id_bill = int.Parse(dataGridView1.Rows[i].Cells["id_bill"].Value.ToString());


                //reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                //reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
