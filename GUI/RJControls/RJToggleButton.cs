using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.RJControls
{
    public  class RJToggleButton : CheckBox
    {
        //Fields
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool soliStyle = true;
        //properties
        [Category("RJ Code Advance")]
        public Color OnBackColor { get => onBackColor; set { onBackColor = value; this.Invalidate(); } }
        [Category("RJ Code Advance")]
        public Color OnToggleColor { get => onToggleColor; set { onToggleColor = value; this.Invalidate(); } }
        [Category("RJ Code Advance")]
        public Color OffBackColor { get => offBackColor; set { offBackColor = value; this.Invalidate(); } }
        [Category("RJ Code Advance")]
        public Color OffToggleColor { get => offToggleColor; set { offToggleColor = value; this.Invalidate(); } }
        [Category("RJ Code Advance")]
        [DefaultValue(true)]
        public bool SoliStyle { get => soliStyle; set { soliStyle = value; this.Invalidate(); } }
        public override string Text { get => base.Text; set => base.Text = value; }


        //Constructor
        public RJToggleButton()
        {
            this.MinimumSize = new Size(45, 22);
        }

        //Methods
        private GraphicsPath GetGraphicsPath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked)// ON
            {
                //Draw the control surface
                if (soliStyle)
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetGraphicsPath());
                else
                    pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetGraphicsPath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else //OFF
            {
                //Draw the control surface
                if (soliStyle)
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetGraphicsPath());
                else
                    pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetGraphicsPath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
