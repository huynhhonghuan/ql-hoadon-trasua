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

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txttaikhoan.Focus();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            DataTable dt = B_dangnhap.Instance.Login(txttaikhoan.Texts.Trim(), txtmatkhau.Texts.Trim());
            if (dt != null)
            {
                DataRow dr = dt.Rows[0];
                if (dr["account_name"].ToString() == "quanly")
                {
                    frmMain frm = new frmMain();
                    frm.quyen = 1;
                    frm.Id_staff = dr["id_staff"].ToString();
                    //MessageBox.Show(dr["id_staff"].ToString());
                    frm.Name_staff = dr["name_staff"].ToString();
                    frm.Thoigian = DateTime.Now;
                    frm.Show();
                    this.Hide();
                    frm.LogOut += FormMain_LogOut;
                    frm.Exit += from_Closed;
                    cleartext();
                }
                else
                {
                    frmMain frm = new frmMain();
                    frm.quyen = 2;
                    frm.Id_staff = dr["id_staff"].ToString();
                    //MessageBox.Show(dr["id_staff"].ToString());
                    frm.Name_staff = dr["name_staff"].ToString();
                    frm.Thoigian = DateTime.Now;
                    frm.Show();
                    this.Hide();
                    frm.LogOut += FormMain_LogOut;
                    frm.Exit += from_Closed;
                    cleartext();
                }
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập");
            }
        }

        private void FormMain_LogOut(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                (sender as frmMain).Show();// as: hiểu là tương tự tại frmGiaoDienChinh thì sẽ được .Show() lên
                this.Hide();// ẩn form đăng nhập
            }
            else
            {
                (sender as frmMain).isThoat = false; // nếu k đăng nhập thì biến isThoat nhận giá trị là false
                (sender as frmMain).Hide();// ẩn frmGiaoDienChinh
                this.Show(); // hiện lại form đăng nhập
            }
        }

        private void from_Closed(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát không bạn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát không bạn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if(chkmatkhau.Checked)
                txtmatkhau.PasswordChar = false;
            else
                txtmatkhau.PasswordChar=true;
        }

        private void txttaikhoan_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Enter)
            {
                txtmatkhau.Focus();
            }
        }

        private void txtmatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Enter)
            {
                btndangnhap_Click(sender, e);
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var confirmation = MessageBox.Show("Bạn có muốn thoát ra khỏi ứng dụng?", "Xác nhận", MessageBoxButtons.OKCancel);
                if (confirmation != DialogResult.OK)
                {
                    e.Cancel = true; // Hủy việc đóng form nếu người dùng không xác nhận thoát.
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        private void cleartext()
        {
            txttaikhoan.Texts = string.Empty;
            txtmatkhau.Texts= string.Empty;
            txttaikhoan.Focus();
        }


    }
}
