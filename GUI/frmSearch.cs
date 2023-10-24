using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.frmMenu;

namespace GUI
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            setflayoutpanel();
        }
        public List<Menu_DTO> imageDataList;
        public event StringEventHandler chonsanpham;
        string idsp="";
        private void setflayoutpanel()
        {
            flowLayoutPanel1.Controls.Clear();

            //imageDataList = B_menu.Instance.Product_Image(type_product);
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
            idsp = label.Name;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            idsp = pictureBox.Name;
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

        private void btnok_Click(object sender, EventArgs e)
        {
            if (idsp == "")
            {
                if(MessageBox.Show("Bạn chưa có chọn sản phẩm, bạn có muốn thoát không?","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    this.Close();
            }
            else
            {
                DataRow dr = B_search.Instance.type_product(idsp).Rows[0];
                if (MessageBox.Show("Bạn chọn sản phẩm: "+ dr["name_product"].ToString(), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                    chonsanpham(idsp);
                }
            }
        }
    }
}
