using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDSHoaDon : Form
    {
        private string id_bill="";
        private int vitri_button = -1;
        public frmDSHoaDon()
        {
            InitializeComponent();
        }

        private void frmDSHoaDon_Load(object sender, EventArgs e)
        {
            btnHomnay_Click(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            {
                int i = dataGridView1.CurrentRow.Index;
                DataGridViewRow dr = dataGridView1.Rows[i];
                id_bill = dr.Cells["id_bill"].Value.ToString();

                dataGridView2.DataSource = B_hoadon.Instance.Table_detail_bill(id_bill);
                SetColumndgv(dataGridView2);
            }
        }
        private void SetColumndgv(DataGridView dr)
        {
            dr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dr.Columns["Id_bill"].Visible = false;
            dr.Columns["Id_detail_bill"].Visible=false;
            dr.Columns["STT"].Width=30;
            dr.Columns["Name_product"].HeaderText="Tên sản phẩm";
            dr.Columns["Quantity"].HeaderText="Số lượng";
            dr.Columns["Id_discount"].HeaderText="Giảm giá(%)";
            dr.Columns["Total"].HeaderText="Đơn giá";
        }
        private void btnHomnay_Click(object sender, EventArgs e)
        {
            
            vitri_button = 1;
            BTN_chon(vitri_button);
        }

        private void btnHomqua_Click(object sender, EventArgs e)
        {
            
            vitri_button = 2;
            BTN_chon(vitri_button);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
           
            vitri_button = 3;
            BTN_chon(vitri_button);
        }
        private void set_column_dataGridView1()
        {
            dataGridView1.Columns["id_bill"].Visible = false;
            dataGridView1.Columns["stt"].HeaderText = "STT";
            dataGridView1.Columns["stt"].Width = 30;
            dataGridView1.Columns["Date_bill"].HeaderText = "Ngày lập biêu";
            dataGridView1.Columns["Name_staff"].HeaderText = "Tên nhân viên";
            dataGridView1.Columns["total"].HeaderText = "Tổng tiền";
        }
        private void BTN_chon(int vitri)
        {
            if (vitri == 1)
            {
                dataGridView1.DataSource = B_hoadon.Instance.Table(DateTime.Today);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                set_column_dataGridView1();
            }
            else if(vitri == 2)
            {
                dataGridView1.DataSource = B_hoadon.Instance.Table(DateTime.Today.AddDays(-1));
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                set_column_dataGridView1();
            }
            else if(vitri == 3)
            {
                dataGridView1.DataSource = B_hoadon.Instance.Table_bill_daytoday(dtpTu.Value, dtpDen.Value);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                set_column_dataGridView1();
            }
        }
        private void btnSua_mua_Click(object sender, EventArgs e)
        {
            if (id_bill != "")
            {
                frmChinhSuaHoaDon frm = new frmChinhSuaHoaDon("id_detail_bill",id_bill, "detail_bill");
                frm.Show();
                frm.OK_Click += OK_Click;
            }
        }
        private void OK_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = B_hoadon.Instance.Table_detail_bill(id_bill);
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa hóa đơn vừa chọn không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (id_bill != "" && B_hoadon.Instance.Delete(id_bill))
                {
                    MessageBox.Show("Xóa hóa đơn thành công");
                    BTN_chon(vitri_button);
                    dataGridView2.DataSource = null;
                }
                else
                    MessageBox.Show("Xóa hóa đơn thất bại!");
            }
        }
    }
}
