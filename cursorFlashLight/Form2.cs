using Microsoft.VisualBasic.Devices;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace cursorFlashLight
{
    public partial class FormPlayState : Form
    {
        private Point mouseLocation;
        private int radius;
        public bool isActuveFlashlight = false;
        public bool isReadyToClose = false;
        public FormPlayState(string message, int radius)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.MouseMove += FormPlayState_MouseMove;
            this.Paint += FormPlayState_Paint;
            this.MouseDoubleClick += SwitchFlashlightState;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            lblHiddenMessage.Text = message;
            this.radius = radius;
            Random random = new Random();
            int x = random.Next(0, this.Width - lblHiddenMessage.Width);
            int y = random.Next(0, this.Height - lblHiddenMessage.Height);
            lblHiddenMessage.Location = new Point(x, y);
            Cursor.Hide();
        }

        private void SwitchFlashlightState(object sender, MouseEventArgs e)
        {
            isActuveFlashlight = !isActuveFlashlight;
        }

        private void FormPlayState_MouseMove(object sender, MouseEventArgs e)
        {
            mouseLocation = e.Location;
            this.Invalidate();
        }

        private void FormPlayState_Paint(object sender, PaintEventArgs e)
        {
            if (isActuveFlashlight)
            {
                Graphics g = e.Graphics;

                g.FillRectangle(Brushes.Black, this.ClientRectangle);
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(mouseLocation.X - radius, mouseLocation.Y - radius, radius * 2, radius * 2);

                PathGradientBrush pgb = null;
                try
                {
                    pgb = new PathGradientBrush(path);
                    pgb.CenterColor = Color.FromArgb(200, Color.White);
                    pgb.SurroundColors = [Color.FromArgb(10, Color.White)];
                    g.FillEllipse(pgb, mouseLocation.X - radius, mouseLocation.Y - radius, radius * 2, radius * 2);
                }
                finally
                {
                    if (pgb != null)
                        pgb.Dispose();
                }
            }
            else
            {
                Graphics g = e.Graphics;

                g.FillRectangle(Brushes.Black, this.ClientRectangle);
            }
        }
    }
}