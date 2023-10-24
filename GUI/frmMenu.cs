using BLL;
using DTO;
using GUI.RJControls;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMenu : Form
    {
        private string manv;
        public frmMenu(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }
        List<Menu_DTO> imageDataList;
        private void setflayoutpanel(string type_product)
        {
            flowLayoutPanel1.Controls.Clear();

            imageDataList = B_menu.Instance.Product_Image(type_product);
            foreach (Menu_DTO imageData in imageDataList)
            {
                Panel flp = new Panel();
                flp.Width = 135;
                flp.Height = 150;
                flp.BackColor = Color.DarkGray;
                flp.Name = imageData.Id;
                //flp.Click += new EventHandler(FlayOutPanel_Click);

                Image image = GetImageFromByteArray(imageData.Image);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = image;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = flp.Width;
                pictureBox.Height = flp.Height - 30;

                pictureBox.Name = imageData.Id;//gán mã sản phẩm
                pictureBox.Click += new EventHandler(PictureBox_Click);

                string sotien = string.Format("{0:#.##}K", imageData.Sotien / 1000);

                Label label = new Label();
                label.Text = sotien;
                label.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular);
                label.ForeColor = Color.White;
                label.BackColor = Color.FromArgb(192, 198, 136, 235); // Độ trong suốt của Label
                label.TextAlign = ContentAlignment.TopLeft;
                label.Location = new Point(0, 0);
                label.Size = new Size(pictureBox.Width / 4, 20);

                label.Name = imageData.Id;//gán mã sản phẩm
                label.Click += new EventHandler(Label_Click);

                Label label1 = new Label();
                label1.Text = imageData.Tensp.ToString();
                label1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular);
                label1.ForeColor = Color.White;
                //label1.BackColor = Color.FromArgb(192, 198, 136, 235); // Độ trong suốt của Label
                label1.TextAlign = ContentAlignment.TopLeft;
                label1.Location = new Point(0, 125);
                label1.Size = new Size(pictureBox.Width, 20);

                label1.Name = imageData.Id;//gán mã sản phẩm
                label1.Click += new EventHandler(Label_Click);

                pictureBox.Controls.Add(label);
                flp.Controls.Add(pictureBox);
                flp.Controls.Add(label1);

                flowLayoutPanel1.Controls.Add(flp);

            }
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            //MessageBox.Show(label.Name);
            //Set_flayoutpanel_bill(label.Name);
            set_detail_bill(label.Name);
            Tien();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            //MessageBox.Show(pictureBox.Name);
            //Set_flayoutpanel_bill(pictureBox.Name);
            set_detail_bill(pictureBox.Name);
            Tien();
        }
        public Image GetImageFromByteArray(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream(imageData))
            {
                return Image.FromStream(ms);
            }
        }

        public bool set_values_bill()
        {
            if (dt_detail_bill.Rows.Count > 0)
            {
                Menu_DTO mn = new Menu_DTO(DateTime.Now, manv, 0);
                return B_menu.Instance.Insert_bill(mn);
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm để thêm hóa đơn");
                return false;
            }
        }

        DataTable dt_detail_bill;
        public void set_detail_bill(string id_product)
        {
            foreach (Menu_DTO MN in imageDataList)
            {
                if (MN.Id == id_product && TrungSanPham(id_product))
                {
                    DataRow dr = dt_detail_bill.NewRow();
                    dr["id_product"] = MN.Id;
                    dr["name_product"] = MN.Tensp;
                    dr["quantity"] = 1;
                    dr["id_discount"] = 0;
                    dr["total"] = MN.Sotien;
                    dt_detail_bill.Rows.Add(dr);

                }
            }
            Load_values_dgv();
        }
        public bool TrungSanPham(string id_product)
        {
            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                DataGridViewRow drr = dgv1.Rows[i];
                //MessageBox.Show(drr.Cells[0].ToString());
                if (drr.Cells["id_product"].Value.ToString() == id_product)
                {
                    MessageBox.Show("Đã có rồi! Hãy chỉnh số lượng!");
                    return false;
                }
            }
            return true;
        }
        List<Menu_DTO> list_menu = new List<Menu_DTO>();
        public void set_values_detail_bill()
        {
            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                DataGridViewRow dr = dgv1.Rows[i];
                //MessageBox.Show(dr.Cells["id_product"].Value.ToString() + dr.Cells["quantity"].Value.ToString() + dr.Cells["id_discount"].Value.ToString() + dr.Cells["total"].Value.ToString());
                Menu_DTO mn = new Menu_DTO(dr.Cells["id_product"].Value.ToString(), int.Parse(dr.Cells["quantity"].Value.ToString()), int.Parse(dr.Cells["id_discount"].Value.ToString()), decimal.Parse(dr.Cells["total"].Value.ToString()));
                list_menu.Add(mn);
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            setflayoutpanel("TS");
            Load_dt_detail_bill();
            Load_values_dgv();
        }
        private void Load_dt_detail_bill()
        {
            dt_detail_bill = new DataTable();
            dt_detail_bill.Columns.Add("id_product", typeof(string));
            dt_detail_bill.Columns.Add("name_product", typeof(string));
            dt_detail_bill.Columns.Add("quantity", typeof(string));
            dt_detail_bill.Columns.Add("id_discount", typeof(int));
            dt_detail_bill.Columns.Add("total", typeof(decimal));
        }
        private void Load_values_dgv()
        {
            list_menu.Clear();

            dgv1.DataSource = dt_detail_bill;
            dgv1.Columns["id_product"].Visible = false;
            dgv1.Columns["name_product"].HeaderText = "Sản phẩm";
            dgv1.Columns["name_product"].Width = 200;
            dgv1.Columns["quantity"].HeaderText = "SL";
            dgv1.Columns["quantity"].Width = 40;
            dgv1.Columns["id_discount"].HeaderText = "Giảm(%)";
            dgv1.Columns["id_discount"].Width = 80;
            dgv1.Columns["total"].HeaderText = "Đơn giá";
            dgv1.Columns["total"].Width = 80;
        }

        private void btnTrasua_Click(object sender, EventArgs e)
        {
            setflayoutpanel("TS");
        }

        private void btnNguyenchat_Click(object sender, EventArgs e)
        {
            setflayoutpanel("NC");
        }

        private void btnTraicay_Click(object sender, EventArgs e)
        {
            setflayoutpanel("TC");
        }

        private void btnDaxay_Click(object sender, EventArgs e)
        {
            setflayoutpanel("DX");
        }

        private void btnTopping_Click(object sender, EventArgs e)
        {
            setflayoutpanel("TP");
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            /*            if (set_values_bill() == true)
                            MessageBox.Show("Bill OK");
                        else
                            MessageBox.Show("Bill NO");
                        set_values_detail_bill();
                        if (B_menu.Instance.Insert_detail_bill(list_menu))
                        {
                            MessageBox.Show("Detail Bill OK");
                            Load_dt_detail_bill();
                            Load_values_dgv();
                            Tien();
                        }
                        else
                            MessageBox.Show("Detail Bill NO");*/
            if (set_values_bill() == true)
            {
                set_values_detail_bill();
                if (B_menu.Instance.Insert_detail_bill(list_menu))
                {
                    MessageBox.Show("Tạo hóa đơn thành công");
                    Load_dt_detail_bill();
                    Load_values_dgv();
                    Tien();
                    Clear();
                    frmXuathoadon frm = new frmXuathoadon(B_menu.Instance.id_bill());
                    frm.Show();
                }
                else
                    MessageBox.Show("Tạo hóa đơn không thành công!");
            }
            else
                MessageBox.Show("Tạo hóa đơn không thành công!");

        }

        int vitri;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (vitri != dgv1.Rows.Count)
                dgv1.Rows.RemoveAt(vitri);
            Tien();
        }
        private void dgv1_Click(object sender, EventArgs e)
        {
            if (dgv1.Rows.Count > 0)
                vitri = dgv1.CurrentRow.Index;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Load_dt_detail_bill();
            Load_values_dgv();
            Tien();
            Clear();
        }
        private bool Kiemtra(DataGridView dt)
        {
            if (dt.Rows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = dt.Rows[vitri];
                string s = @"^\d+$";
                if (Regex.IsMatch(dataGridViewRow.Cells["quantity"].Value.ToString(), s))
                {
                    if (int.Parse(dataGridViewRow.Cells["quantity"].Value.ToString()) < 1)
                    {
                        MessageBox.Show("Nhập số lượng từ phải từ 1!");
                        dataGridViewRow.Cells["quantity"].Value = 1;
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Nhập dữ liệu là số!");
                    dataGridViewRow.Cells["quantity"].Value = 1;
                    return false;
                }
/*                if (!Regex.IsMatch(dataGridViewRow.Cells["id_discount"].Value.ToString(), s))
                {
                    if (int.Parse(dataGridViewRow.Cells["id_discount"].Value.ToString()) < 0 || int.Parse(dataGridViewRow.Cells["id_discount"].Value.ToString()) > 100)
                    {
                        MessageBox.Show("Nhập giá giảm từ khoảng 0 - 100!");
                        dataGridViewRow.Cells["id_discount"].Value = 0;
                        return false;
                    }
                    else if (int.Parse(dataGridViewRow.Cells["id_discount"].Value.ToString()) == 0)
                    {
                        MessageBox.Show("Nhập dữ liệu là số! huan");
                        dataGridViewRow.Cells["id_discount"].Value = 0;
                        return false;
                    }
                }
                else if(int.Parse(dataGridViewRow.Cells["id_discount"].Value.ToString()) != 0) MessageBox.Show("Huan");*/
            }
            else
            { return false; }
            return true;
        }
        private void dgv1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Tien();
            Kiemtra(dgv1);
        }
        private void Tien()
        {
            if (Kiemtra(dgv1))
            {
                float giam = 0, tongtien = 0, thanhtien = 0;
                for (int i = 0; i < dgv1.Rows.Count; i++)
                {
                    DataGridViewRow dr = dgv1.Rows[i];
                    giam += (float.Parse(dr.Cells["id_discount"].Value.ToString()) * float.Parse(dr.Cells["total"].Value.ToString()) / (float)100) * float.Parse(dr.Cells["quantity"].Value.ToString());
                    tongtien += float.Parse(dr.Cells["total"].Value.ToString()) * float.Parse(dr.Cells["quantity"].Value.ToString());
                }
                thanhtien = tongtien - giam;
                lblGiam.Text = "Giảm                        " + giam.ToString() + " VND";
                lblTongtien.Text = "Tổng tiền                 " + tongtien.ToString() + " VND";
                lblThanhtien.Text = "Thành tiền               " + thanhtien.ToString() + " VND";
            }
        }
        public delegate void StringEventHandler(string idsanpham);
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (B_search.Instance.Search(txttim.Texts).Count > 0)
            {
                frmSearch frmSearch = new frmSearch();
                frmSearch.imageDataList = B_search.Instance.Search(txttim.Texts.Trim());
                frmSearch.chonsanpham += new StringEventHandler(chonsanpham);
                frmSearch.ShowDialog();
            }
            else
                MessageBox.Show("Không tìm thấy sản phẩm");
        }

        private void chonsanpham(string idsanpham)
        {
            if (B_search.Instance.type_product(idsanpham).Rows.Count > 0)
            {
                DataRow dr1 = B_search.Instance.type_product(idsanpham).Rows[0];
                foreach (Menu_DTO MN in B_menu.Instance.Product_Image(dr1["id_type_product"].ToString()))
                {
                    if (MN.Id == idsanpham && TrungSanPham(idsanpham))
                    {
                        DataRow dr = dt_detail_bill.NewRow();
                        dr["id_product"] = MN.Id;
                        dr["name_product"] = MN.Tensp;
                        dr["quantity"] = 1;
                        dr["id_discount"] = 0;
                        dr["total"] = MN.Sotien;
                        dt_detail_bill.Rows.Add(dr);
                    }
                }
                txttim.Texts = "";
                Load_values_dgv();
                Tien();
            }
            else
                MessageBox.Show("Bạn chưa có chọn sản phẩm!");
        }

        private void txttim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTim_Click(sender, e);
            }
        }

        private void dgv1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Nhập số từ 0 - 100!");
            e.Cancel = true;
        }

        private void Clear()
        {
            lblGiam.Text = "Giảm";
            lblThanhtien.Text = "Thành tiền";
            lblTongtien.Text = "Tổng tiền";
        }
    }
}
