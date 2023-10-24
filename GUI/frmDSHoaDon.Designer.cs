namespace GUI
{
    partial class frmDSHoaDon
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
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHomqua = new GUI.RJControls.RJButton();
            this.btnXoaHD = new GUI.RJControls.RJButton();
            this.btnSua_mua = new GUI.RJControls.RJButton();
            this.btnChon = new GUI.RJControls.RJButton();
            this.btnHomnay = new GUI.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTu
            // 
            this.dtpTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTu.Location = new System.Drawing.Point(408, 17);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(143, 27);
            this.dtpTu.TabIndex = 2;
            // 
            // dtpDen
            // 
            this.dtpDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDen.Location = new System.Drawing.Point(610, 17);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(143, 27);
            this.dtpDen.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(490, 429);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(508, 135);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(639, 429);
            this.dataGridView2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh sách hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(768, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chi tiết hóa đơn mua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "TỪ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "ĐẾN";
            // 
            // btnHomqua
            // 
            this.btnHomqua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHomqua.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHomqua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHomqua.BorderRadius = 40;
            this.btnHomqua.BorderSize = 0;
            this.btnHomqua.FlatAppearance.BorderSize = 0;
            this.btnHomqua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomqua.ForeColor = System.Drawing.Color.White;
            this.btnHomqua.Location = new System.Drawing.Point(181, 12);
            this.btnHomqua.Name = "btnHomqua";
            this.btnHomqua.Size = new System.Drawing.Size(150, 40);
            this.btnHomqua.TabIndex = 16;
            this.btnHomqua.Text = "Hôm qua";
            this.btnHomqua.TextColor = System.Drawing.Color.White;
            this.btnHomqua.UseVisualStyleBackColor = false;
            this.btnHomqua.Click += new System.EventHandler(this.btnHomqua_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnXoaHD.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnXoaHD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaHD.BorderRadius = 40;
            this.btnXoaHD.BorderSize = 0;
            this.btnXoaHD.FlatAppearance.BorderSize = 0;
            this.btnXoaHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHD.ForeColor = System.Drawing.Color.White;
            this.btnXoaHD.Location = new System.Drawing.Point(1009, 68);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(138, 55);
            this.btnXoaHD.TabIndex = 13;
            this.btnXoaHD.Text = "Xóa hóa đơn";
            this.btnXoaHD.TextColor = System.Drawing.Color.White;
            this.btnXoaHD.UseVisualStyleBackColor = false;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // btnSua_mua
            // 
            this.btnSua_mua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSua_mua.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSua_mua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSua_mua.BorderRadius = 40;
            this.btnSua_mua.BorderSize = 0;
            this.btnSua_mua.FlatAppearance.BorderSize = 0;
            this.btnSua_mua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua_mua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_mua.ForeColor = System.Drawing.Color.White;
            this.btnSua_mua.Location = new System.Drawing.Point(1009, 7);
            this.btnSua_mua.Name = "btnSua_mua";
            this.btnSua_mua.Size = new System.Drawing.Size(138, 55);
            this.btnSua_mua.TabIndex = 7;
            this.btnSua_mua.Text = "Sửa hóa đơn mua";
            this.btnSua_mua.TextColor = System.Drawing.Color.White;
            this.btnSua_mua.UseVisualStyleBackColor = false;
            this.btnSua_mua.Click += new System.EventHandler(this.btnSua_mua_Click);
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChon.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChon.BorderRadius = 40;
            this.btnChon.BorderSize = 0;
            this.btnChon.FlatAppearance.BorderSize = 0;
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.ForeColor = System.Drawing.Color.White;
            this.btnChon.Image = global::GUI.Properties.Resources.choose;
            this.btnChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChon.Location = new System.Drawing.Point(759, 12);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(150, 40);
            this.btnChon.TabIndex = 1;
            this.btnChon.Text = "Chọn";
            this.btnChon.TextColor = System.Drawing.Color.White;
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
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
            this.btnHomnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomnay.ForeColor = System.Drawing.Color.White;
            this.btnHomnay.Location = new System.Drawing.Point(25, 12);
            this.btnHomnay.Name = "btnHomnay";
            this.btnHomnay.Size = new System.Drawing.Size(150, 40);
            this.btnHomnay.TabIndex = 0;
            this.btnHomnay.Text = "Hôm nay";
            this.btnHomnay.TextColor = System.Drawing.Color.White;
            this.btnHomnay.UseVisualStyleBackColor = false;
            this.btnHomnay.Click += new System.EventHandler(this.btnHomnay_Click);
            // 
            // frmDSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1159, 576);
            this.Controls.Add(this.btnHomqua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua_mua);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpDen);
            this.Controls.Add(this.dtpTu);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnHomnay);
            this.Name = "frmDSHoaDon";
            this.Text = "frmDSHoaDon";
            this.Load += new System.EventHandler(this.frmDSHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJControls.RJButton btnHomnay;
        private RJControls.RJButton btnChon;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private RJControls.RJButton btnSua_mua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RJControls.RJButton btnXoaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private RJControls.RJButton btnHomqua;
    }
}