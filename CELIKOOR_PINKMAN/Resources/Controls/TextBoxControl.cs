using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CELIKOOR_PINKMAN.Resources.Controls
{
    public partial class TextBoxControl : UserControl
    {
        private Color borderColor = Color.LightSeaGreen;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        public TextBoxControl()
        {
            InitializeComponent();
        }
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        public bool UnderlinedStyle
        {
            get => underlinedStyle;
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;

            using (Pen pen = new Pen(borderColor, borderSize))
            {
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (underlinedStyle)
                {
                    graphics.DrawLine(pen, 0, this.Height - 1, this.Width, this.Height - 1);
                }
                else
                {
                    graphics.DrawRectangle(pen, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                }
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                UpdateHeight();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateHeight();
        }
        private void UpdateHeight()
        {
            if (textBoxDesign.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBoxDesign.Multiline = true;
                textBoxDesign.MinimumSize = new Size(0, txtHeight);
                textBoxDesign.Multiline = false;

                this.Height = textBoxDesign.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
    }
}
