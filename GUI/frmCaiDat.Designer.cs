namespace GUI
{
    partial class frmCaiDat
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
            this.label1 = new System.Windows.Forms.Label();
            this.rjToggleButton1 = new GUI.RJControls.RJToggleButton();
            this.txtxacnhanmk = new GUI.RJControls.RJTextBox();
            this.txtmkmoi = new GUI.RJControls.RJTextBox();
            this.txtmkhientai = new GUI.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmkhientai = new System.Windows.Forms.Label();
            this.btnxacnhan = new GUI.RJControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(796, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đổi màu giao diện";
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.Location = new System.Drawing.Point(802, 232);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(162)))), ((int)(((byte)(208)))));
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(164)))));
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.DarkGray;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.Size = new System.Drawing.Size(237, 89);
            this.rjToggleButton1.TabIndex = 0;
            this.rjToggleButton1.Text = "rjToggleButton1";
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            this.rjToggleButton1.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // txtxacnhanmk
            // 
            this.txtxacnhanmk.BackColor = System.Drawing.SystemColors.Window;
            this.txtxacnhanmk.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtxacnhanmk.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtxacnhanmk.BorderRadius = 0;
            this.txtxacnhanmk.BorderSize = 2;
            this.txtxacnhanmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxacnhanmk.ForeColor = System.Drawing.Color.DimGray;
            this.txtxacnhanmk.Location = new System.Drawing.Point(250, 175);
            this.txtxacnhanmk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtxacnhanmk.Multiline = false;
            this.txtxacnhanmk.Name = "txtxacnhanmk";
            this.txtxacnhanmk.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtxacnhanmk.PasswordChar = true;
            this.txtxacnhanmk.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtxacnhanmk.PlaceholderText = "";
            this.txtxacnhanmk.Size = new System.Drawing.Size(258, 35);
            this.txtxacnhanmk.TabIndex = 21;
            this.txtxacnhanmk.Texts = "";
            this.txtxacnhanmk.UnderlinedStyle = false;
            this.txtxacnhanmk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtxacnhanmk_KeyDown);
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.BackColor = System.Drawing.SystemColors.Window;
            this.txtmkmoi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtmkmoi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtmkmoi.BorderRadius = 0;
            this.txtmkmoi.BorderSize = 2;
            this.txtmkmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkmoi.ForeColor = System.Drawing.Color.DimGray;
            this.txtmkmoi.Location = new System.Drawing.Point(250, 127);
            this.txtmkmoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmkmoi.Multiline = false;
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtmkmoi.PasswordChar = true;
            this.txtmkmoi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtmkmoi.PlaceholderText = "";
            this.txtmkmoi.Size = new System.Drawing.Size(258, 35);
            this.txtmkmoi.TabIndex = 20;
            this.txtmkmoi.Texts = "";
            this.txtmkmoi.UnderlinedStyle = false;
            this.txtmkmoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmkmoi_KeyDown);
            // 
            // txtmkhientai
            // 
            this.txtmkhientai.BackColor = System.Drawing.SystemColors.Window;
            this.txtmkhientai.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtmkhientai.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtmkhientai.BorderRadius = 0;
            this.txtmkhientai.BorderSize = 2;
            this.txtmkhientai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkhientai.ForeColor = System.Drawing.Color.DimGray;
            this.txtmkhientai.Location = new System.Drawing.Point(250, 84);
            this.txtmkhientai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmkhientai.Multiline = false;
            this.txtmkhientai.Name = "txtmkhientai";
            this.txtmkhientai.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtmkhientai.PasswordChar = true;
            this.txtmkhientai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtmkhientai.PlaceholderText = "";
            this.txtmkhientai.Size = new System.Drawing.Size(258, 35);
            this.txtmkhientai.TabIndex = 19;
            this.txtmkhientai.Texts = "";
            this.txtmkhientai.UnderlinedStyle = false;
            this.txtmkhientai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmkhientai_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Xác nhận mật khẩu mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // lblmkhientai
            // 
            this.lblmkhientai.AutoSize = true;
            this.lblmkhientai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmkhientai.Location = new System.Drawing.Point(26, 99);
            this.lblmkhientai.Name = "lblmkhientai";
            this.lblmkhientai.Size = new System.Drawing.Size(141, 20);
            this.lblmkhientai.TabIndex = 15;
            this.lblmkhientai.Text = "Mật khẩu hiện tại:";
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnxacnhan.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnxacnhan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnxacnhan.BorderRadius = 40;
            this.btnxacnhan.BorderSize = 0;
            this.btnxacnhan.FlatAppearance.BorderSize = 0;
            this.btnxacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxacnhan.ForeColor = System.Drawing.Color.White;
            this.btnxacnhan.Location = new System.Drawing.Point(193, 236);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(170, 40);
            this.btnxacnhan.TabIndex = 14;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.TextColor = System.Drawing.Color.White;
            this.btnxacnhan.UseVisualStyleBackColor = false;
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(179, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "ĐỔI MẬT KHẨU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtxacnhanmk);
            this.groupBox1.Controls.Add(this.txtmkmoi);
            this.groupBox1.Controls.Add(this.txtmkhientai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblmkhientai);
            this.groupBox1.Controls.Add(this.btnxacnhan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(67, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 314);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // frmCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1159, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjToggleButton1);
            this.Name = "frmCaiDat";
            this.Text = "frmCaiDat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJControls.RJToggleButton rjToggleButton1;
        private System.Windows.Forms.Label label1;
        private RJControls.RJTextBox txtxacnhanmk;
        private RJControls.RJTextBox txtmkmoi;
        private RJControls.RJTextBox txtmkhientai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmkhientai;
        private RJControls.RJButton btnxacnhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}