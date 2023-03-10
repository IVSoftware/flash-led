Your post states that you're
>trying to change an image of an LED from one colour to another sleep for a second then change back.

Here, in general form, is one way to go about updating a UI element (e.g. to change color or image) at a specific time interval without blocking the UI thread.

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
                Color.DimGray,
            })
            {
                led1.BackColor= color;
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }
    }

[![cycle led][1]][1]

Where:

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
            using (var pen = new Pen(Color.Black, 2)) 
            {
                e.Graphics.DrawEllipse(
                    pen,
                    new RectangleF(
                        new PointF(6, 6),
                        new SizeF(Width - 12, Height - 12)));
            }
        }
    }


  [1]: https://i.stack.imgur.com/dRZ04.png