namespace GUI
{
    partial class frmSearch
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnok = new GUI.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(950, 562);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnok.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnok.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnok.BorderRadius = 40;
            this.btnok.BorderSize = 0;
            this.btnok.FlatAppearance.BorderSize = 0;
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.Location = new System.Drawing.Point(408, 580);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(150, 40);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "OK";
            this.btnok.TextColor = System.Drawing.Color.White;
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(976, 632);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearch";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RJControls.RJButton btnok;
    }
}