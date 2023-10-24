namespace GUI
{
    partial class frmBaoCao
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnChon = new GUI.RJControls.RJButton();
            this.CbbThang = new GUI.RJControls.RJComboBox();
            this.CbbNam = new GUI.RJControls.RJComboBox();
            this.rjButton1 = new GUI.RJControls.RJButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Năm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbbThang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CbbNam);
            this.groupBox1.Controls.Add(this.rjButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 168);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DOANH THU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "ĐẾN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "TỪ";
            // 
            // dtpDen
            // 
            this.dtpDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDen.Location = new System.Drawing.Point(61, 72);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(131, 27);
            this.dtpDen.TabIndex = 18;
            // 
            // dtpTu
            // 
            this.dtpTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTu.Location = new System.Drawing.Point(61, 39);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(131, 27);
            this.dtpTu.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(421, 233);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpDen);
            this.groupBox2.Controls.Add(this.dtpTu);
            this.groupBox2.Controls.Add(this.btnChon);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 378);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HÓA ĐƠN";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(458, 18);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(689, 546);
            this.reportViewer1.TabIndex = 24;
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
            this.btnChon.Location = new System.Drawing.Point(242, 55);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(150, 40);
            this.btnChon.TabIndex = 16;
            this.btnChon.Text = "Chọn";
            this.btnChon.TextColor = System.Drawing.Color.White;
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // CbbThang
            // 
            this.CbbThang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CbbThang.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CbbThang.BorderSize = 1;
            this.CbbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbbThang.ForeColor = System.Drawing.Color.DimGray;
            this.CbbThang.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CbbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CbbThang.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CbbThang.ListTextColor = System.Drawing.Color.DimGray;
            this.CbbThang.Location = new System.Drawing.Point(114, 21);
            this.CbbThang.MinimumSize = new System.Drawing.Size(200, 30);
            this.CbbThang.Name = "CbbThang";
            this.CbbThang.Padding = new System.Windows.Forms.Padding(1);
            this.CbbThang.Size = new System.Drawing.Size(200, 36);
            this.CbbThang.TabIndex = 6;
            this.CbbThang.Texts = "";
            // 
            // CbbNam
            // 
            this.CbbNam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CbbNam.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CbbNam.BorderSize = 1;
            this.CbbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbbNam.ForeColor = System.Drawing.Color.DimGray;
            this.CbbNam.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CbbNam.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CbbNam.ListTextColor = System.Drawing.Color.DimGray;
            this.CbbNam.Location = new System.Drawing.Point(114, 63);
            this.CbbNam.MinimumSize = new System.Drawing.Size(200, 30);
            this.CbbNam.Name = "CbbNam";
            this.CbbNam.Padding = new System.Windows.Forms.Padding(1);
            this.CbbNam.Size = new System.Drawing.Size(200, 36);
            this.CbbNam.TabIndex = 3;
            this.CbbNam.Texts = "";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 32;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = global::GUI.Properties.Resources.report;
            this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton1.Location = new System.Drawing.Point(138, 105);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 42);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.Text = "Xuất";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1159, 576);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBaoCao";
            this.Text = "frmBaoCao";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RJControls.RJButton rjButton1;
        private RJControls.RJComboBox CbbNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RJControls.RJComboBox CbbThang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private RJControls.RJButton btnChon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}