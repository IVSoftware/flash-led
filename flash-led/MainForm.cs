using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flash_led
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonFlash.Click += onClickFlash;
        }

        private void onClickFlash(object sender, EventArgs e)
        {
            _ = ChangeCalled();
        }

        private async Task ChangeCalled()
        {
            foreach (var color in new Color[] 
            {
                Color.LightGreen,
                Color.CornflowerBlue,
                Color.Goldenrod,
            })
            {
                led1.BackColor= color;
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
            led1.BackColor = Color.DimGray;
        }
    }
    class LED : Label
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            var region = new Region(new Rectangle(Point.Empty, ClientSize));
            Bitmap bitmap = new Bitmap(Width, Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillEllipse(
                Brushes.LimeGreen,
                new RectangleF(
                    new PointF(4, 4),
                    new SizeF(bitmap.Width - 8, bitmap.Height - 8)));
            for (int x = 0; x < bitmap.Width; x++) for (int y = 0; y < bitmap.Height; y++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    if (pixel.ToArgb() != Color.LimeGreen.ToArgb())
                    {
                        region.Exclude(new Rectangle(x, y, 1, 1));
                    }
                }
            Region = region;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var pen = new Pen(Color.White, 2)) 
            {
                e.Graphics.DrawEllipse(
                    pen,
                    new RectangleF(
                        new PointF(6, 6),
                        new SizeF(Width - 12, Height - 12)));
            }
        }
    }
}
