using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.RJControls
{
    [DefaultEvent("TextChanged")]
    public partial class RJTextBox : UserControl
    {
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;

        private int borderRadius = 0;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;
        //event 
        public event EventHandler _TextChanged;
        public RJTextBox()
        {
            InitializeComponent();
        }
        [Category("RJ Code Advance")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        [Category("RJ Code Advance")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        [Category("RJ Code Advance")]
        public bool UnderlinedStyle { get => underlinedStyle; set { underlinedStyle = value; this.Invalidate(); } }
        [Category("RJ Code Advance")]
        public bool PasswordChar
        {
            get { return isPasswordChar; }
            set
            {
                isPasswordChar = value;
                textBox1.UseSystemPasswordChar = value;
            }
        }
        [Category("RJ Code Advance")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        [Category("RJ Code Advance")]
        public override Color BackColor { get => base.BackColor; set { base.BackColor = value; textBox1.BackColor = value; } }
        [Category("RJ Code Advance")]
        public override Color ForeColor { get => base.ForeColor; set { base.ForeColor = value; textBox1.ForeColor = value; } }
        [Category("RJ Code Advance")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }
        [Category("RJ Code Advance")]
        public string Texts
        {
            get
            {
                if (isPlaceholder) return "";
                else return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
                SetPlaceholder();
            }
        }
        [Category("RJ Code Advance")]
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }
        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();//Redraw Control
                }
            }
        }
        [Category("RJ Code Advance")]
        public Color PlaceholderColor
        {
            get => placeholderColor;
            set
            {
                placeholderColor = value;
                if (isPasswordChar)
                    textBox1.ForeColor = value;
            }
        }
        [Category("RJ Code Advance")]
        public string PlaceholderText
        {
            get => placeholderText;
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceholder();
            }
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = false;
            }
        }
        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;

            if (borderRadius > 1)//Rounded TextBox
            {
                //Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetGraphicsPath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetGraphicsPath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                    if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of Textbox component
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle)//Line Style
                    {
                        //Draw border smoothing
                        graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graphics.SmoothingMode = SmoothingMode.None;
                        graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else//Normal Style
                    {
                        //Draw border smoothing
                        graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else//Square / Normal TextBox
            {
                //Draw border
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle)//Line Style
                        graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else//Normal Style
                        graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }

        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetGraphicsPath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetGraphicsPath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
        }

        /*
protected override void OnPaint(PaintEventArgs e)
{
   base.OnPaint(e);
   Graphics graphics = e.Graphics;

   using(Pen penBorder =new Pen(borderColor, borderSize))
   {
       penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

       if (!isFocused)
       {
           if (underlinedStyle)//Line Style
               graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
           else//Normal Style
               graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
       }
       else
       {
           penBorder.Color = borderFocusColor;
           if (underlinedStyle)//Line Style
               graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
           else//Normal Style
               graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
       }
   }
}
*/
        private GraphicsPath GetGraphicsPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnResize(EventArgs e)//Khi thay đổi kích thước
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e) //Khi load
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        //Private methods
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
            // còn thiếu xét chọn password
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Escape)
                e.Handled = true;   // stop annoying beep

            // call base handler...
            base.OnKeyPress(e);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }
    }
}
