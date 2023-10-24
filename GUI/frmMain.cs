using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public static frmMain _instance;
        public static frmMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMain();
                return _instance;
            }
        }
        public int quyen=0;
        public event EventHandler LogOut;
        public event EventHandler Exit;
        public bool isThoat = true;
        private string id_staff;
        private string name_staff;
        private DateTime thoigian;

        public string Id_staff { get => id_staff; set => id_staff = value; }
        public string Name_staff { get => name_staff; set => name_staff = value; }
        public DateTime Thoigian { get => thoigian; set => thoigian = value; }

        private Form Form_hientai;
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblNguoidung.Text = "NHÂN VIÊN: "+name_staff.ToUpper();
            lblThoigian.Text = "THỜI GIAN: "+ thoigian.ToString();
            HienThiMain();
        }
        private void HienThiMain()
        {
            switch(quyen)
            {
                case 2:
                    tHỐNGKÊToolStripMenuItem.Visible = false;
                    bÁOCÁOToolStripMenuItem.Visible = false;
                    btnsaoluu.Visible = false;
                    btnphuchoi.Visible = false;
                    break;
                default:
                    break;
            }
        }
        private void OpenChildFrom(Form childFrom)
        {
            if (Form_hientai != null)
                Form_hientai.Hide();
            Form_hientai = childFrom;
            childFrom.TopLevel = false;//
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;// lấy đầy panel lun
            panelMain.Controls.Add(childFrom);
            panelMain.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }

        private void tHỰCĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new frmMenu(Id_staff));
        }

        private void HoaDontoolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new frmDSHoaDon());
        }

        private void tHỐNGKÊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new frmThongKe());
        }
        private void bÁOCÁOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new frmBaoCao());
        }
        private void TroGiuptoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new frmTroGiup());
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit(this,new EventArgs());
        }
        public delegate void ColorArrayEventHandler(object sender, Color[] colors);
        public void HandleColorsSelected(object sender, Color[] colors)
        {
            panel1.BackColor= colors[0];
            menuStrip1.BackColor= colors[1];
        }
        private void CaiDattoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmCaiDat frm=new frmCaiDat();
            frm.ColorsSelected += new ColorArrayEventHandler(HandleColorsSelected);
            frm.Id_staff = Id_staff;
            OpenChildFrom(frm);
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            LogOut(this, new EventArgs());
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnsaoluu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saoluu;
            string saoluu1 = "";
            saoluu = new FolderBrowserDialog();
            saoluu.Description = "Chọn thư mục lưu trữ";
            if (saoluu.ShowDialog() == DialogResult.OK)
            {
                saoluu1 = saoluu.SelectedPath;
            }
            if (saoluu1 != "")
            {
                if (MessageBox.Show("Bạn có muốn sao lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    if (B_SaoLuuPhucHoi.Instance.Backup("QLHD", saoluu.SelectedPath))
                        MessageBox.Show("Sao lưu thành công");
                    else
                        MessageBox.Show("Sao lưu không thành công");
            }
            else
                MessageBox.Show("Chọn vị trí lưu!");
        }

        private void btnphuchoi_Click(object sender, EventArgs e)
        {
            OpenFileDialog open;
            string open1 = "";
            open = new OpenFileDialog();
            open.Filter = "SQL server database backup files|*.bak";
            open.Title = "Chọn tập tin phục hồi(.bak)";
            if (open.ShowDialog() == DialogResult.OK && open.CheckFileExists == true)
            {
                open1 = open.FileName;
            }
            if (open1 != "")
            {
                if (MessageBox.Show("Bạn có muốn phục hồi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    if (B_SaoLuuPhucHoi.Instance.Restore("QLHD", open.FileName))
                        MessageBox.Show("Phục hồi thành công");
                    else
                        MessageBox.Show("Phục hồi không thành công");
            }
            else
                MessageBox.Show("Chọn file phục hồi!");
        }
    }
}
