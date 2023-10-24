namespace GUI
{
    partial class frmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn30ngay = new GUI.RJControls.RJButton();
            this.btn7ngay = new GUI.RJControls.RJButton();
            this.btn14ngay = new GUI.RJControls.RJButton();
            this.btnHomnay = new GUI.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbldanhthuhomnay = new System.Windows.Forms.Label();
            this.lblDT = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbltongsanpham = new System.Windows.Forms.Label();
            this.lblTSP = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblsoluonghoadon = new System.Windows.Forms.Label();
            this.lblSLHD = new System.Windows.Forms.Label();
            this.btnThongke = new GUI.RJControls.RJButton();
            this.cbbThang = new GUI.RJControls.RJComboBox();
            this.cbbNam = new GUI.RJControls.RJComboBox();
            this.cbbChon = new GUI.RJControls.RJComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea7.BorderColor = System.Drawing.Color.IndianRed;
            chartArea7.Name = "ChartArea1";
            chartArea7.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend7.IsTextAutoFit = false;
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(12, 202);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.IsXValueIndexed = true;
            series7.Legend = "Legend1";
            series7.Name = "Doanh thu";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(1135, 362);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title7.Name = "Title1";
            this.chart1.Titles.Add(title7);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Doanh thu theo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Chọn tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(673, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Chọn năm";
            // 
            // btn30ngay
            // 
            this.btn30ngay.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn30ngay.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn30ngay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn30ngay.BorderRadius = 40;
            this.btn30ngay.BorderSize = 0;
            this.btn30ngay.FlatAppearance.BorderSize = 0;
            this.btn30ngay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn30ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn30ngay.ForeColor = System.Drawing.Color.White;
            this.btn30ngay.Location = new System.Drawing.Point(801, 97);
            this.btn30ngay.Name = "btn30ngay";
            this.btn30ngay.Size = new System.Drawing.Size(163, 40);
            this.btn30ngay.TabIndex = 13;
            this.btn30ngay.Text = "30 ngày gần nhất";
            this.btn30ngay.TextColor = System.Drawing.Color.White;
            this.btn30ngay.UseVisualStyleBackColor = false;
            this.btn30ngay.Click += new System.EventHandler(this.btn30ngay_Click);
            // 
            // btn7ngay
            // 
            this.btn7ngay.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn7ngay.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn7ngay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn7ngay.BorderRadius = 40;
            this.btn7ngay.BorderSize = 0;
            this.btn7ngay.FlatAppearance.BorderSize = 0;
            this.btn7ngay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7ngay.ForeColor = System.Drawing.Color.White;
            this.btn7ngay.Location = new System.Drawing.Point(356, 97);
            this.btn7ngay.Name = "btn7ngay";
            this.btn7ngay.Size = new System.Drawing.Size(163, 40);
            this.btn7ngay.TabIndex = 12;
            this.btn7ngay.Text = "7 ngày gần nhất";
            this.btn7ngay.TextColor = System.Drawing.Color.White;
            this.btn7ngay.UseVisualStyleBackColor = false;
            this.btn7ngay.Click += new System.EventHandler(this.btn7ngay_Click);
            // 
            // btn14ngay
            // 
            this.btn14ngay.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn14ngay.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn14ngay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn14ngay.BorderRadius = 40;
            this.btn14ngay.BorderSize = 0;
            this.btn14ngay.FlatAppearance.BorderSize = 0;
            this.btn14ngay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn14ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn14ngay.ForeColor = System.Drawing.Color.White;
            this.btn14ngay.Location = new System.Drawing.Point(581, 97);
            this.btn14ngay.Name = "btn14ngay";
            this.btn14ngay.Size = new System.Drawing.Size(163, 40);
            this.btn14ngay.TabIndex = 11;
            this.btn14ngay.Text = "14 ngày gần nhất";
            this.btn14ngay.TextColor = System.Drawing.Color.White;
            this.btn14ngay.UseVisualStyleBackColor = false;
            this.btn14ngay.Click += new System.EventHandler(this.btn14ngay_Click);
            // 
            // btnHomnay
            // 
            this.btnHomnay.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHomnay.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHomnay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHomnay.BorderRadius = 40;
            this.btnHomnay.BorderSize = 0;
            this.btnHomnay.FlatAppearance.BorderSize = 0;
            this.btnHomnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomnay.ForeColor = System.Drawing.Color.White;
            this.btnHomnay.Location = new System.Drawing.Point(152, 97);
            this.btnHomnay.Name = "btnHomnay";
            this.btnHomnay.Size = new System.Drawing.Size(163, 40);
            this.btnHomnay.TabIndex = 10;
            this.btnHomnay.Text = "Hôm nay";
            this.btnHomnay.TextColor = System.Drawing.Color.White;
            this.btnHomnay.UseVisualStyleBackColor = false;
            this.btnHomnay.Click += new System.EventHandler(this.btnHomnay_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.lbldanhthuhomnay);
            this.panel1.Controls.Add(this.lblDT);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 79);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::GUI.Properties.Resources.fare;
            this.pictureBox1.Location = new System.Drawing.Point(343, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 61);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lbldanhthuhomnay
            // 
            this.lbldanhthuhomnay.AutoSize = true;
            this.lbldanhthuhomnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldanhthuhomnay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldanhthuhomnay.Location = new System.Drawing.Point(215, 32);
            this.lbldanhthuhomnay.Name = "lbldanhthuhomnay";
            this.lbldanhthuhomnay.Size = new System.Drawing.Size(29, 20);
            this.lbldanhthuhomnay.TabIndex = 1;
            this.lbldanhthuhomnay.Text = "00";
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDT.Location = new System.Drawing.Point(3, 21);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(106, 40);
            this.lblDT.TabIndex = 0;
            this.lblDT.Text = "DANH THU\r\nHÔM NAY";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.lbltongsanpham);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblTSP);
            this.panel2.Location = new System.Drawing.Point(397, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 79);
            this.panel2.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::GUI.Properties.Resources.product;
            this.pictureBox2.Location = new System.Drawing.Point(339, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 58);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // lbltongsanpham
            // 
            this.lbltongsanpham.AutoSize = true;
            this.lbltongsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongsanpham.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltongsanpham.Location = new System.Drawing.Point(286, 32);
            this.lbltongsanpham.Name = "lbltongsanpham";
            this.lbltongsanpham.Size = new System.Drawing.Size(29, 20);
            this.lbltongsanpham.TabIndex = 2;
            this.lbltongsanpham.Text = "00";
            // 
            // lblTSP
            // 
            this.lblTSP.AutoSize = true;
            this.lblTSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTSP.Location = new System.Drawing.Point(3, 21);
            this.lblTSP.Name = "lblTSP";
            this.lblTSP.Size = new System.Drawing.Size(163, 40);
            this.lblTSP.TabIndex = 1;
            this.lblTSP.Text = "TỔNG SẢN PHẨM\r\nBÁN HÔM NAY";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepPink;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lblsoluonghoadon);
            this.panel3.Controls.Add(this.lblSLHD);
            this.panel3.Location = new System.Drawing.Point(775, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 79);
            this.panel3.TabIndex = 21;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::GUI.Properties.Resources.bill1;
            this.pictureBox3.Location = new System.Drawing.Point(339, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 65);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // lblsoluonghoadon
            // 
            this.lblsoluonghoadon.AutoSize = true;
            this.lblsoluonghoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoluonghoadon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsoluonghoadon.Location = new System.Drawing.Point(294, 32);
            this.lblsoluonghoadon.Name = "lblsoluonghoadon";
            this.lblsoluonghoadon.Size = new System.Drawing.Size(29, 20);
            this.lblsoluonghoadon.TabIndex = 2;
            this.lblsoluonghoadon.Text = "00";
            // 
            // lblSLHD
            // 
            this.lblSLHD.AutoSize = true;
            this.lblSLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLHD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSLHD.Location = new System.Drawing.Point(3, 21);
            this.lblSLHD.Name = "lblSLHD";
            this.lblSLHD.Size = new System.Drawing.Size(158, 40);
            this.lblSLHD.TabIndex = 2;
            this.lblSLHD.Text = "SỐ LƯỢNG HOÁ \r\nĐƠN HÔM NAY";
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThongke.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThongke.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThongke.BorderRadius = 40;
            this.btnThongke.BorderSize = 0;
            this.btnThongke.FlatAppearance.BorderSize = 0;
            this.btnThongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.ForeColor = System.Drawing.Color.White;
            this.btnThongke.Image = global::GUI.Properties.Resources.statistacal;
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.Location = new System.Drawing.Point(973, 145);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(150, 40);
            this.btnThongke.TabIndex = 18;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.TextColor = System.Drawing.Color.White;
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // cbbThang
            // 
            this.cbbThang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbThang.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbThang.BorderSize = 1;
            this.cbbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbThang.ForeColor = System.Drawing.Color.DimGray;
            this.cbbThang.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbThang.Items.AddRange(new object[] {
            "3 tháng",
            "6 tháng",
            "9 tháng",
            "12 tháng"});
            this.cbbThang.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbThang.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbThang.Location = new System.Drawing.Point(493, 152);
            this.cbbThang.MinimumSize = new System.Drawing.Size(150, 30);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Padding = new System.Windows.Forms.Padding(1);
            this.cbbThang.Size = new System.Drawing.Size(157, 33);
            this.cbbThang.TabIndex = 22;
            this.cbbThang.Texts = "";
            // 
            // cbbNam
            // 
            this.cbbNam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbNam.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbNam.BorderSize = 1;
            this.cbbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbNam.ForeColor = System.Drawing.Color.DimGray;
            this.cbbNam.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbNam.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbNam.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbNam.Location = new System.Drawing.Point(782, 152);
            this.cbbNam.MinimumSize = new System.Drawing.Size(150, 30);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Padding = new System.Windows.Forms.Padding(1);
            this.cbbNam.Size = new System.Drawing.Size(154, 33);
            this.cbbNam.TabIndex = 23;
            this.cbbNam.Texts = "";
            // 
            // cbbChon
            // 
            this.cbbChon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbChon.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbChon.BorderSize = 1;
            this.cbbChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbChon.ForeColor = System.Drawing.Color.DimGray;
            this.cbbChon.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbChon.Items.AddRange(new object[] {
            "Ngày",
            "Sản phẩm"});
            this.cbbChon.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbChon.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbChon.Location = new System.Drawing.Point(206, 152);
            this.cbbChon.MinimumSize = new System.Drawing.Size(150, 30);
            this.cbbChon.Name = "cbbChon";
            this.cbbChon.Padding = new System.Windows.Forms.Padding(1);
            this.cbbChon.Size = new System.Drawing.Size(161, 33);
            this.cbbChon.TabIndex = 24;
            this.cbbChon.Texts = "";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1159, 576);
            this.Controls.Add(this.cbbChon);
            this.Controls.Add(this.cbbNam);
            this.Controls.Add(this.cbbThang);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn30ngay);
            this.Controls.Add(this.btn7ngay);
            this.Controls.Add(this.btn14ngay);
            this.Controls.Add(this.btnHomnay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private RJControls.RJButton btnHomnay;
        private RJControls.RJButton btn14ngay;
        private RJControls.RJButton btn7ngay;
        private RJControls.RJButton btn30ngay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RJControls.RJButton btnThongke;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTSP;
        private System.Windows.Forms.Label lbldanhthuhomnay;
        private System.Windows.Forms.Label lbltongsanpham;
        private System.Windows.Forms.Label lblsoluonghoadon;
        private System.Windows.Forms.Label lblSLHD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private RJControls.RJComboBox cbbThang;
        private RJControls.RJComboBox cbbNam;
        private RJControls.RJComboBox cbbChon;
    }
}