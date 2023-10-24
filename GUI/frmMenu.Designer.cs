namespace GUI
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblThanhtien = new System.Windows.Forms.Label();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.lblGiam = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.txttim = new GUI.RJControls.RJTextBox();
            this.btnTim = new GUI.RJControls.RJButton();
            this.btnHuy = new GUI.RJControls.RJButton();
            this.btnXoa = new GUI.RJControls.RJButton();
            this.btnThanhtoan = new GUI.RJControls.RJButton();
            this.btnTopping = new GUI.RJControls.RJButton();
            this.btnDaxay = new GUI.RJControls.RJButton();
            this.btnTraicay = new GUI.RJControls.RJButton();
            this.btnNguyenchat = new GUI.RJControls.RJButton();
            this.btnTrasua = new GUI.RJControls.RJButton();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(602, 513);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lblThanhtien);
            this.panel2.Controls.Add(this.lblTongtien);
            this.panel2.Controls.Add(this.lblGiam);
            this.panel2.Controls.Add(this.btnThanhtoan);
            this.panel2.Location = new System.Drawing.Point(620, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 197);
            this.panel2.TabIndex = 7;
            // 
            // lblThanhtien
            // 
            this.lblThanhtien.AutoSize = true;
            this.lblThanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhtien.Location = new System.Drawing.Point(22, 92);
            this.lblThanhtien.Name = "lblThanhtien";
            this.lblThanhtien.Size = new System.Drawing.Size(87, 20);
            this.lblThanhtien.TabIndex = 15;
            this.lblThanhtien.Text = "Thành tiền";
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongtien.Location = new System.Drawing.Point(22, 54);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(78, 20);
            this.lblTongtien.TabIndex = 14;
            this.lblTongtien.Text = "Tổng tiền";
            // 
            // lblGiam
            // 
            this.lblGiam.AutoSize = true;
            this.lblGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiam.Location = new System.Drawing.Point(22, 19);
            this.lblGiam.Name = "lblGiam";
            this.lblGiam.Size = new System.Drawing.Size(49, 20);
            this.lblGiam.TabIndex = 12;
            this.lblGiam.Text = "Giảm";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel2.Controls.Add(this.dgv1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(620, 58);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(537, 310);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(3, 3);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(534, 307);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellValueChanged);
            this.dgv1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv1_DataError);
            this.dgv1.Click += new System.EventHandler(this.dgv1_Click);
            // 
            // txttim
            // 
            this.txttim.BackColor = System.Drawing.SystemColors.Window;
            this.txttim.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txttim.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txttim.BorderRadius = 0;
            this.txttim.BorderSize = 2;
            this.txttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttim.ForeColor = System.Drawing.Color.DimGray;
            this.txttim.Location = new System.Drawing.Point(748, 16);
            this.txttim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttim.Multiline = false;
            this.txttim.Name = "txttim";
            this.txttim.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txttim.PasswordChar = false;
            this.txttim.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txttim.PlaceholderText = "";
            this.txttim.Size = new System.Drawing.Size(296, 35);
            this.txttim.TabIndex = 12;
            this.txttim.Texts = "";
            this.txttim.UnderlinedStyle = false;
            this.txttim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttim_KeyDown);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTim.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTim.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTim.BorderRadius = 32;
            this.btnTim.BorderSize = 0;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(1050, 12);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(107, 39);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextColor = System.Drawing.Color.White;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHuy.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHuy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHuy.BorderRadius = 40;
            this.btnHuy.BorderSize = 0;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Image = global::GUI.Properties.Resources.cancel;
            this.btnHuy.Location = new System.Drawing.Point(1063, 485);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 40);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextColor = System.Drawing.Color.White;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnXoa.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.BorderRadius = 40;
            this.btnXoa.BorderSize = 0;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::GUI.Properties.Resources.delete;
            this.btnXoa.Location = new System.Drawing.Point(1063, 427);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 40);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThanhtoan.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThanhtoan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThanhtoan.BorderRadius = 40;
            this.btnThanhtoan.BorderSize = 0;
            this.btnThanhtoan.FlatAppearance.BorderSize = 0;
            this.btnThanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhtoan.ForeColor = System.Drawing.Color.White;
            this.btnThanhtoan.Image = global::GUI.Properties.Resources.pay;
            this.btnThanhtoan.Location = new System.Drawing.Point(151, 141);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(150, 40);
            this.btnThanhtoan.TabIndex = 11;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.TextColor = System.Drawing.Color.White;
            this.btnThanhtoan.UseVisualStyleBackColor = false;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // btnTopping
            // 
            this.btnTopping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(136)))), ((int)(((byte)(235)))));
            this.btnTopping.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(136)))), ((int)(((byte)(235)))));
            this.btnTopping.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTopping.BorderRadius = 40;
            this.btnTopping.BorderSize = 0;
            this.btnTopping.FlatAppearance.BorderSize = 0;
            this.btnTopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopping.ForeColor = System.Drawing.Color.White;
            this.btnTopping.Location = new System.Drawing.Point(601, 12);
            this.btnTopping.Name = "btnTopping";
            this.btnTopping.Size = new System.Drawing.Size(112, 40);
            this.btnTopping.TabIndex = 4;
            this.btnTopping.Text = "Topping";
            this.btnTopping.TextColor = System.Drawing.Color.White;
            this.btnTopping.UseVisualStyleBackColor = false;
            this.btnTopping.Click += new System.EventHandler(this.btnTopping_Click);
            // 
            // btnDaxay
            // 
            this.btnDaxay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(162)))), ((int)(((byte)(208)))));
            this.btnDaxay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(162)))), ((int)(((byte)(208)))));
            this.btnDaxay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDaxay.BorderRadius = 40;
            this.btnDaxay.BorderSize = 0;
            this.btnDaxay.FlatAppearance.BorderSize = 0;
            this.btnDaxay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaxay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaxay.ForeColor = System.Drawing.Color.White;
            this.btnDaxay.Location = new System.Drawing.Point(473, 12);
            this.btnDaxay.Name = "btnDaxay";
            this.btnDaxay.Size = new System.Drawing.Size(122, 40);
            this.btnDaxay.TabIndex = 3;
            this.btnDaxay.Text = "Đá xây";
            this.btnDaxay.TextColor = System.Drawing.Color.White;
            this.btnDaxay.UseVisualStyleBackColor = false;
            this.btnDaxay.Click += new System.EventHandler(this.btnDaxay_Click);
            // 
            // btnTraicay
            // 
            this.btnTraicay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(164)))));
            this.btnTraicay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(164)))));
            this.btnTraicay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTraicay.BorderRadius = 40;
            this.btnTraicay.BorderSize = 0;
            this.btnTraicay.FlatAppearance.BorderSize = 0;
            this.btnTraicay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraicay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraicay.ForeColor = System.Drawing.Color.White;
            this.btnTraicay.Location = new System.Drawing.Point(325, 12);
            this.btnTraicay.Name = "btnTraicay";
            this.btnTraicay.Size = new System.Drawing.Size(142, 40);
            this.btnTraicay.TabIndex = 2;
            this.btnTraicay.Text = "Trà trái cây";
            this.btnTraicay.TextColor = System.Drawing.Color.White;
            this.btnTraicay.UseVisualStyleBackColor = false;
            this.btnTraicay.Click += new System.EventHandler(this.btnTraicay_Click);
            // 
            // btnNguyenchat
            // 
            this.btnNguyenchat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.btnNguyenchat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.btnNguyenchat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNguyenchat.BorderRadius = 40;
            this.btnNguyenchat.BorderSize = 0;
            this.btnNguyenchat.FlatAppearance.BorderSize = 0;
            this.btnNguyenchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNguyenchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNguyenchat.ForeColor = System.Drawing.Color.White;
            this.btnNguyenchat.Location = new System.Drawing.Point(137, 12);
            this.btnNguyenchat.Name = "btnNguyenchat";
            this.btnNguyenchat.Size = new System.Drawing.Size(182, 40);
            this.btnNguyenchat.TabIndex = 1;
            this.btnNguyenchat.Text = "Trà nguyên chất";
            this.btnNguyenchat.TextColor = System.Drawing.Color.White;
            this.btnNguyenchat.UseVisualStyleBackColor = false;
            this.btnNguyenchat.Click += new System.EventHandler(this.btnNguyenchat_Click);
            // 
            // btnTrasua
            // 
            this.btnTrasua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(126)))), ((int)(((byte)(225)))));
            this.btnTrasua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(126)))), ((int)(((byte)(225)))));
            this.btnTrasua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTrasua.BorderRadius = 40;
            this.btnTrasua.BorderSize = 0;
            this.btnTrasua.FlatAppearance.BorderSize = 0;
            this.btnTrasua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasua.ForeColor = System.Drawing.Color.White;
            this.btnTrasua.Location = new System.Drawing.Point(12, 12);
            this.btnTrasua.Name = "btnTrasua";
            this.btnTrasua.Size = new System.Drawing.Size(119, 40);
            this.btnTrasua.TabIndex = 0;
            this.btnTrasua.Text = "Trà sữa";
            this.btnTrasua.TextColor = System.Drawing.Color.White;
            this.btnTrasua.UseVisualStyleBackColor = false;
            this.btnTrasua.Click += new System.EventHandler(this.btnTrasua_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1169, 576);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnTopping);
            this.Controls.Add(this.btnDaxay);
            this.Controls.Add(this.btnTraicay);
            this.Controls.Add(this.btnNguyenchat);
            this.Controls.Add(this.btnTrasua);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RJControls.RJButton btnTrasua;
        private RJControls.RJButton btnNguyenchat;
        private RJControls.RJButton btnTraicay;
        private RJControls.RJButton btnDaxay;
        private RJControls.RJButton btnTopping;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblThanhtien;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.Label lblGiam;
        private RJControls.RJButton btnThanhtoan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv1;
        private RJControls.RJButton btnXoa;
        private RJControls.RJButton btnHuy;
        private RJControls.RJTextBox txttim;
        private RJControls.RJButton btnTim;
    }
}