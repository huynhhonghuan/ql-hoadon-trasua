namespace GUI
{
    partial class frmChinhSuaHoaDon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTenSP = new System.Windows.Forms.ComboBox();
            this.btnLuu = new GUI.RJControls.RJButton();
            this.btnOK = new GUI.RJControls.RJButton();
            this.btnXoa = new GUI.RJControls.RJButton();
            this.btnSua = new GUI.RJControls.RJButton();
            this.btnThem = new GUI.RJControls.RJButton();
            this.txtDongia = new GUI.RJControls.RJTextBox();
            this.txtGiam = new GUI.RJControls.RJTextBox();
            this.txtSL = new GUI.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(576, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(601, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giảm(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(601, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đơn giá";
            // 
            // cbbTenSP
            // 
            this.cbbTenSP.FormattingEnabled = true;
            this.cbbTenSP.Location = new System.Drawing.Point(738, 55);
            this.cbbTenSP.Name = "cbbTenSP";
            this.cbbTenSP.Size = new System.Drawing.Size(200, 24);
            this.cbbTenSP.TabIndex = 14;
            this.cbbTenSP.SelectedValueChanged += new System.EventHandler(this.cbbTenSP_SelectedValueChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLuu.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.BorderRadius = 40;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(831, 331);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(128, 40);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOK.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOK.BorderRadius = 40;
            this.btnOK.BorderSize = 0;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(738, 398);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 40);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.TextColor = System.Drawing.Color.White;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
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
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(831, 285);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 40);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSua.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSua.BorderRadius = 40;
            this.btnSua.BorderSize = 0;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(652, 331);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 40);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 40;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(652, 285);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 40);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDongia
            // 
            this.txtDongia.BackColor = System.Drawing.SystemColors.Window;
            this.txtDongia.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDongia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDongia.BorderRadius = 0;
            this.txtDongia.BorderSize = 2;
            this.txtDongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDongia.ForeColor = System.Drawing.Color.DimGray;
            this.txtDongia.Location = new System.Drawing.Point(738, 217);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDongia.Multiline = false;
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDongia.PasswordChar = false;
            this.txtDongia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDongia.PlaceholderText = "";
            this.txtDongia.Size = new System.Drawing.Size(200, 35);
            this.txtDongia.TabIndex = 4;
            this.txtDongia.Texts = "";
            this.txtDongia.UnderlinedStyle = false;
            // 
            // txtGiam
            // 
            this.txtGiam.BackColor = System.Drawing.SystemColors.Window;
            this.txtGiam.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGiam.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGiam.BorderRadius = 0;
            this.txtGiam.BorderSize = 2;
            this.txtGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiam.ForeColor = System.Drawing.Color.DimGray;
            this.txtGiam.Location = new System.Drawing.Point(738, 158);
            this.txtGiam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiam.Multiline = false;
            this.txtGiam.Name = "txtGiam";
            this.txtGiam.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGiam.PasswordChar = false;
            this.txtGiam.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGiam.PlaceholderText = "";
            this.txtGiam.Size = new System.Drawing.Size(200, 35);
            this.txtGiam.TabIndex = 3;
            this.txtGiam.Texts = "";
            this.txtGiam.UnderlinedStyle = false;
            // 
            // txtSL
            // 
            this.txtSL.BackColor = System.Drawing.SystemColors.Window;
            this.txtSL.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSL.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSL.BorderRadius = 0;
            this.txtSL.BorderSize = 2;
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.ForeColor = System.Drawing.Color.DimGray;
            this.txtSL.Location = new System.Drawing.Point(738, 98);
            this.txtSL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSL.Multiline = false;
            this.txtSL.Name = "txtSL";
            this.txtSL.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSL.PasswordChar = false;
            this.txtSL.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSL.PlaceholderText = "";
            this.txtSL.Size = new System.Drawing.Size(200, 35);
            this.txtSL.TabIndex = 2;
            this.txtSL.Texts = "";
            this.txtSL.UnderlinedStyle = false;
            // 
            // frmChinhSuaHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1007, 450);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbbTenSP);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtGiam);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmChinhSuaHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChinhSuaHoaDon";
            this.Load += new System.EventHandler(this.frmChinhSuaHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RJControls.RJTextBox txtSL;
        private RJControls.RJTextBox txtGiam;
        private RJControls.RJTextBox txtDongia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RJControls.RJButton btnThem;
        private RJControls.RJButton btnSua;
        private RJControls.RJButton btnXoa;
        private RJControls.RJButton btnOK;
        private System.Windows.Forms.ComboBox cbbTenSP;
        private RJControls.RJButton btnLuu;
    }
}