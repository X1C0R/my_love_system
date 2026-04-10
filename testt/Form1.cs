using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testt
{
    public partial class BBForm : Form
    {
        public BBForm()
        {
            InitializeComponent();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HouseButton.FlatStyle = FlatStyle.Flat;
            HouseButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.FlatAppearance.BorderSize = 0;
            ApplyRoundedToAll(this, 40);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Bitmap bmp = new Bitmap(btn.Width, btn.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, btn.Width, btn.Height),
                Color.PeachPuff,
                Color.LightSalmon,
                LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, 0, 0, btn.Width, btn.Height);
            }

            btn.BackgroundImage = bmp;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void HouseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HousingForm form2 = new HousingForm();
            form2.Show();
        }
        private void HouseButton_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Bitmap bmp = new Bitmap(btn.Width, btn.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, btn.Width, btn.Height),
                Color.PeachPuff,
                Color.LightSalmon,
                LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, 0, 0, btn.Width, btn.Height);
            }

            btn.BackgroundImage = bmp;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void HouseButton_MouseEnter(object sender, EventArgs e)
        {

        }

        private void HouseButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackgroundImage = null;
            btn.BackColor = Color.LightSalmon;

        }
        private void AddButton_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Bitmap bmp = new Bitmap(btn.Width, btn.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, btn.Width, btn.Height),
                Color.PeachPuff,
                Color.LightSalmon,
                LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, 0, 0, btn.Width, btn.Height);
            }

            btn.BackgroundImage = bmp;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackgroundImage = null;
            btn.BackColor = Color.LightSalmon;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
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
        private void Title_Click(object sender, EventArgs e)
        {

        }
        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            gradientShift = (float)e.X / Title.Width;
            Title.Invalidate();
        }
        private void ApplyRoundedToAll(Control parent, int radius)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Button btn)
                {
                    ApplyRounded(btn, radius);

                    // fix resize issue
                    btn.Resize += (s, e) =>
                    {
                        ApplyRounded(btn, radius);
                    };
                }

                if (ctrl.HasChildren)
                {
                    ApplyRoundedToAll(ctrl, radius);
                }
            }
        }
        private void ApplyRounded(Button btn, int radius)
        {
            btn.Region = new Region(GetRoundedRectangle(btn.ClientRectangle, radius));
        }
        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

            path.CloseFigure();
            return path;
        }
        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HelpBox_Click(object sender, EventArgs e)
        {
            Help form3= new Help();
            form3.Show();
        }


    }
}
