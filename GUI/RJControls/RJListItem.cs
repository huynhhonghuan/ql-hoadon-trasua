using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.RJControls
{
    public partial class RJListItem : UserControl
    {
        public RJListItem()
        {
            InitializeComponent();
        }
        [Category("RJ Code Advance")]
        public string Label1
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        [Category("RJ Code Advance")]
        public string Numberic
        {
            get
            {
                return numericUpDown1.Value.ToString();
            }
            set
            {
                numericUpDown1.Value = int.Parse(value);
            }
        }
        [Category("RJ Code Advance")]
        public string TextBox2
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }
        [Category("RJ Code Advance")]
        public string TextBox3
        {
            get { return textBox3.Text; }
            set
            {
                textBox3.Text = value;
            }
        }
    }
}
