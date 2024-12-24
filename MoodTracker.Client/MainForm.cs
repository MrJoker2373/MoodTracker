namespace MoodTracker.Client
{
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private Padding _normalPadding;
        private Padding _maximizedPadding;

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public MainForm()
        {
            _normalPadding = Padding;
            _maximizedPadding = new Padding(Padding.Left, Padding.Top + 8, Padding.Right + 8, Padding.Bottom);
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void controlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
                return;
            base.WndProc(ref m);
        }

        protected override void OnResize(EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                Padding = _maximizedPadding;
            else if (WindowState == FormWindowState.Normal)
                Padding = _normalPadding;
            base.OnResize(e);
        }
    }
}