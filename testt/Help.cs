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

namespace testt
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }
        private void Question1_Click(object sender, EventArgs e)
        {
        }
        private void Information1_Click(object sender, EventArgs e)
        {

        }
        private float gradientShift = 0;
        private void Title_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
               Title.ClientRectangle,
               Color.White,
               Color.Black,
               LinearGradientMode.Horizontal))
            {
                ColorBlend blend = new ColorBlend();
                blend.Colors = new Color[]
                {
                  Color.LightBlue,
                  Color.SeaShell,
                  Color.Pink
                };

                blend.Positions = new float[]
                {
                 0f,
                 gradientShift,
                 1f
                };

                brush.InterpolationColors = blend;

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                e.Graphics.DrawString(
                    Title.Text,
                    Title.Font,
                    brush,
                    new PointF(0, 0));
            }
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            gradientShift = (float)e.X / Title.Width;
            Title.Invalidate();
        }
    }
}
