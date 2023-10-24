using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.RJControls
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public class RJComboBox : UserControl
    {
        //Fields
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;

        //Items
        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;

        //Properties
        [Category("RJ Code - Appearance")]
        public new Color BackColor { get => backColor; set { backColor = value; lblText.BackColor = backColor; btnIcon.BackColor = backColor; } }
        [Category("RJ Code - Appearance")]
        public Color IconColor { get => iconColor; set { iconColor = value; btnIcon.Invalidate(); } }//Redraw icon
        [Category("RJ Code - Appearance")]
        public Color ListBackColor { get => listBackColor; set { listBackColor = value; cmbList.BackColor = listBackColor; } }
        [Category("RJ Code - Appearance")]
        public Color ListTextColor { get => listTextColor; set { listTextColor = value; cmbList.ForeColor = listTextColor; } }
        [Category("RJ Code - Appearance")]
        public Color BorderColor { get => borderColor; set { borderColor = value; base.BackColor = borderColor; } }//Border Color
        [Category("RJ Code - Appearance")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Padding = new Padding(borderSize); AdjustComboBoxDimension(); } }//Border Size
        [Category("RJ Code - Appearance")]
        public override Color ForeColor { get => base.ForeColor; set { base.ForeColor = value; lblText.ForeColor = value; } }
        [Category("RJ Code - Appearance")]
        public override Font Font { get => base.Font; set { base.Font = value; lblText.Font = value; cmbList.Font = value; } }
        [Category("RJ Code - Appearance")]
        public string Texts
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }
        [Category("RJ Code - Appearance")]
        public ComboBoxStyle DropDownStyle
        {
            get { return cmbList.DropDownStyle; }
            set
            {
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }

        // -> Data
        [Category("RJ Code - Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return cmbList.Items; }
        }
        [Category("RJ Code - Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public object DataSource
        {
            get => cmbList.DataSource;
            set => cmbList.DataSource = value;
        }


        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get => cmbList.AutoCompleteCustomSource;
            set => cmbList.AutoCompleteCustomSource = value;
        }


        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get => cmbList.AutoCompleteSource;
            set => cmbList.AutoCompleteSource = value;
        }

        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get => cmbList.AutoCompleteMode;
            set => cmbList.AutoCompleteMode = value;
        }


        [Category("RJ Code - Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get => cmbList.SelectedItem;
            set => cmbList.SelectedItem = value;
        }

        [Category("RJ Code - Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get => cmbList.SelectedIndex;
            set => cmbList.SelectedIndex = value;
        }


        //Event
        public event EventHandler OnSelectedIndexChanged;// Default event
        public RJComboBox()
        {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            //ComboBox: Dropdown list
            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(this.Font.Name, 10F);
            cmbList.ForeColor = listTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);//Default event
            cmbList.TextChanged += new EventHandler(ComboBox_TextChange);//Refresh Text

            //Button 
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);//Open dropdown list
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);//Draw icon

            //Lable : Text
            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);
            lblText.Click += new EventHandler(Surface_Click);//Select combobox

            //User Control
            this.Controls.Add(lblText);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cmbList);
            this.MinimumSize = new Size(150, 30);
            this.Size = new Size(150, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);//Border Size
            base.BackColor = borderColor;//Border Color
            this.ResumeLayout();
            AdjustComboBoxDimension();
        }

        //private methods
        private void AdjustComboBoxDimension()
        {
            cmbList.Width = lblText.Width;
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }
        //Event methods

        // -> Default event
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            //Refresh text
            lblText.Text = cmbList.Text;
        }
        private void Surface_Click(object sender, EventArgs e)
        {
            //Select Combobox
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                cmbList.DroppedDown = true;//Open dropdown list
            }
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            //Fields
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidth) / 2, (btnIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;

            //Draw arrow down icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            //Open dropdown list
            cmbList.Select();
            cmbList.DroppedDown = true;
        }

        private void ComboBox_TextChange(object sender, EventArgs e)
        {
            //Refresh Text
            lblText.Text = cmbList.Text;
        }
    }
}