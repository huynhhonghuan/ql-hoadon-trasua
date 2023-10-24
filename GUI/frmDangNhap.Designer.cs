namespace GUI
{
    partial class frmDangNhap
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
            this.txtmatkhau = new GUI.RJControls.RJTextBox();
            this.txttaikhoan = new GUI.RJControls.RJTextBox();
            this.btnthoat = new GUI.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.chkmatkhau = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndangnhap = new GUI.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtmatkhau.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtmatkhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtmatkhau.BorderRadius = 20;
            this.txtmatkhau.BorderSize = 2;
            this.txtmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.ForeColor = System.Drawing.Color.DimGray;
            this.txtmatkhau.Location = new System.Drawing.Point(106, 232);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmatkhau.Multiline = false;
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtmatkhau.PasswordChar = true;
            this.txtmatkhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtmatkhau.PlaceholderText = "Mật khẩu";
            this.txtmatkhau.Size = new System.Drawing.Size(331, 35);
            this.txtmatkhau.TabIndex = 13;
            this.txtmatkhau.Texts = "";
            this.txtmatkhau.UnderlinedStyle = false;
            this.txtmatkhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmatkhau_KeyDown);
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txttaikhoan.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txttaikhoan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txttaikhoan.BorderRadius = 20;
            this.txttaikhoan.BorderSize = 2;
            this.txttaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaikhoan.ForeColor = System.Drawing.Color.DimGray;
            this.txttaikhoan.Location = new System.Drawing.Point(106, 173);
            this.txttaikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttaikhoan.Multiline = false;
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txttaikhoan.PasswordChar = false;
            this.txttaikhoan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txttaikhoan.PlaceholderText = "Tài khoản";
            this.txttaikhoan.Size = new System.Drawing.Size(331, 35);
            this.txttaikhoan.TabIndex = 12;
            this.txttaikhoan.Texts = "";
            this.txttaikhoan.UnderlinedStyle = false;
            this.txttaikhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttaikhoan_KeyDown);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnthoat.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnthoat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnthoat.BorderRadius = 32;
            this.btnthoat.BorderSize = 0;
            this.btnthoat.FlatAppearance.BorderSize = 0;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.White;
            this.btnthoat.Image = global::GUI.Properties.Resources.exit;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(276, 321);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(149, 39);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextColor = System.Drawing.Color.White;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Thương hiệu độc quyền của 3H";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(112, 281);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 16);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu?";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(371, 281);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(56, 16);
            this.linkLabel2.TabIndex = 18;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Đăng ký";
            // 
            // chkmatkhau
            // 
            this.chkmatkhau.AutoSize = true;
            this.chkmatkhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkmatkhau.Location = new System.Drawing.Point(407, 241);
            this.chkmatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkmatkhau.Name = "chkmatkhau";
            this.chkmatkhau.Size = new System.Drawing.Size(18, 17);
            this.chkmatkhau.TabIndex = 11;
            this.chkmatkhau.UseVisualStyleBackColor = true;
            this.chkmatkhau.CheckedChanged += new System.EventHandler(this.chkmatkhau_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(199, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btndangnhap.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btndangnhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btndangnhap.BorderRadius = 32;
            this.btndangnhap.BorderSize = 0;
            this.btndangnhap.FlatAppearance.BorderSize = 0;
            this.btndangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.ForeColor = System.Drawing.Color.White;
            this.btndangnhap.Image = global::GUI.Properties.Resources.login;
            this.btndangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndangnhap.Location = new System.Drawing.Point(106, 321);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(149, 39);
            this.btndangnhap.TabIndex = 9;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.TextColor = System.Drawing.Color.White;
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(544, 427);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkmatkhau);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndangnhap);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJControls.RJTextBox txtmatkhau;
        private RJControls.RJTextBox txttaikhoan;
        private System.Windows.Forms.CheckBox chkmatkhau;
        private RJControls.RJButton btnthoat;
        private RJControls.RJButton btndangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}