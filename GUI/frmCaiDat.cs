using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.frmMain;

namespace GUI
{
    public partial class frmCaiDat : Form
    {
        public frmCaiDat()
        {
            InitializeComponent();
        }
        public event ColorArrayEventHandler ColorsSelected;
        public string Id_staff;

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            Color[] color1 = { rjToggleButton1.OnBackColor, rjToggleButton1.OnToggleColor };
            Color[] color2 = {rjToggleButton1.OffBackColor, rjToggleButton1.OffToggleColor };
            if (rjToggleButton1.Checked)
                ColorsSelected(this, color1);
            else
                ColorsSelected(this, color2);
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if (B_doimatkhau.Instance.DoiMatKhau(Id_staff, txtmkhientai.Texts, txtmkmoi.Texts, txtxacnhanmk.Texts))
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                txtmkhientai.Texts = "";
                txtmkmoi.Texts = "";
                txtxacnhanmk.Texts = "";
            }
                
            else
                MessageBox.Show("Đổi mật khẩu không thành công");

        }

        private void txtmkhientai_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            { 
                txtmkmoi.Focus();
            }
        }

        private void txtmkmoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtxacnhanmk.Focus();
            }
        }

        private void txtxacnhanmk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnxacnhan_Click(sender, e);
            }
        }
    }
}
