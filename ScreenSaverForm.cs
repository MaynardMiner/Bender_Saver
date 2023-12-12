using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bender_Saver
{
    public partial class ScreensaverForm
    {
        private Point mouseLocation;
        private bool previewMode = false;
        private const int BOUNCE_SPEED = 1;
        private const int BOUNCE_LIMIT = 10;
        private int _xVelocity = BOUNCE_SPEED;
        private int _yVelocity = BOUNCE_SPEED;
        private string video = @"C:\bender.mp4";

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        public ScreensaverForm(Rectangle Bounds)
        {
            InitializeComponent();
            this.Size = new Size(Bounds.Width, Bounds.Height);
        }

        public ScreensaverForm(IntPtr PreviewWndHandle)
        {
            InitializeComponent();

            // Set the preview window as the parent of this window
            SetParent(this.Handle, PreviewWndHandle);

            // Make this a child window so it will close when the parent dialog closes
            // GWL_STYLE = -16, WS_CHILD = 0x40000000
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            // Place our window inside the parent
            Rectangle ParentRect;
            GetClientRect(PreviewWndHandle, out ParentRect);
            Size = ParentRect.Size;
            Location = new Point(0, 0);
            previewMode = true;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void ScreensaverForm_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = video;
            axWindowsMediaPlayer1.stretchToFit = true;
            Cursor.Hide();
            TopMost = true;
            moveTimer.Interval = 30;
            moveTimer.Tick += new EventHandler(moveTimer_Tick);
            moveTimer.Start();
        }

        private void ScreensaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseLocation.IsEmpty)
            {
                // Terminate if mouse is moved a significant distance
                if (Math.Abs(mouseLocation.X - e.X) > 5 ||
                    Math.Abs(mouseLocation.Y - e.Y) > 5)
                    Application.Exit();
            }

            // Update current mouse location
            mouseLocation = e.Location;
        }

        private void ScreensaverForm_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void ScreensaverForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            Rectangle pictureRect = axWindowsMediaPlayer1.Bounds;

            int newX = axWindowsMediaPlayer1.Location.X + _xVelocity;
            int newY = axWindowsMediaPlayer1.Location.Y + _yVelocity;

            if (newX <= 0 || newX + pictureRect.Width >= Size.Width)
            {
                _xVelocity *= -1;
            }
            if (newY <= 0 || newY + pictureRect.Height >= Size.Height)
            {
                _yVelocity *= -1;
            }

            axWindowsMediaPlayer1.Location = new Point(newX, newY);
        }
    }
}
