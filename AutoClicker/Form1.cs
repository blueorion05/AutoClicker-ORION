using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        private bool isAutoClicking = false;
        private int clickInterval = 100;
        private Keys toggleKey = Keys.F5;
        private MouseButtons mouseButton = MouseButtons.Left;
        private int clickCount = 1;
        private LowLevelKeyboardHook keyboardHook = new LowLevelKeyboardHook();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private Point lastMousePosition = Cursor.Position;
        private List<Control> excludedControls;

        private bool isDragging = false;
        private Point dragStartPoint;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            timer.Tick += Timer_Tick;
            excludedControls = new List<Control>();
            excludedControls.Add(btnStartStop);
            excludedControls.Add(panel1);
            excludedControls.Add(label1);
            excludedControls.Add(button1);
            excludedControls.Add(button2);
            excludedControls.Add(pictureBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.MouseDown += PanelMove_MouseDown;
            panel1.MouseMove += PanelMove_MouseMove;
            panel1.MouseUp += PanelMove_MouseUp;

            label1.MouseDown += PanelMove_MouseDown;
            label1.MouseMove += PanelMove_MouseMove;
            label1.MouseUp += PanelMove_MouseUp;

            pictureBox1.MouseDown += PanelMove_MouseDown;
            pictureBox1.MouseMove += PanelMove_MouseMove;
            pictureBox1.MouseUp += PanelMove_MouseUp;

            keyboardHook.KeyDown += KeyboardHook_KeyDown;
            keyboardHook.Install();
            timer.Interval = clickInterval;
            Activate();
        }

        private void KeyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == toggleKey)
            {
                e.Handled = true;
                ToggleAutoClicker();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.Focused)
            {
                if (e.KeyCode == toggleKey)
                {
                    e.Handled = true;
                    ToggleAutoClicker();
                }
            }
        }

        private void ToggleAutoClicker()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                ClickInterval();
            }
            label1.Focus();
            isDragging = false;
            if (!isAutoClicking)
            {
                isAutoClicking = true;
                btnStartStop.ForeColor = Color.White;
                btnStartStop.Text = "STOP";
                btnStartStop.BackColor = Color.Red;
                DisableControls();
                StartAutoClicker();
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                isAutoClicking = false;
                btnStartStop.ForeColor = Color.Black;
                btnStartStop.Text = "START";
                btnStartStop.BackColor = Color.White;
                EnableControls();
                StopAutoClicker();
            }
        }

        private void StartAutoClicker()
        {
            timer.Start();
        }

        private void StopAutoClicker()
        {
            timer.Stop();
        }

        private bool IsMouseOverForm()
        {
            return Bounds.Contains(PointToClient(lastMousePosition));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Point currentMousePosition = Cursor.Position;

            if (currentMousePosition != lastMousePosition)
            {
                lastMousePosition = currentMousePosition;

                if (!IsMouseOverForm())
                {
                    MouseClick();
                }
            }
        }

        private void MouseClick()
        {
            for (int i = 0; i < clickCount; i++)
            {
                int x = Cursor.Position.X;
                int y = Cursor.Position.Y;
                if (mouseButton == MouseButtons.Left)
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
                }
                else if (mouseButton == MouseButtons.Right)
                {
                    mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, x, y, 0, 0);
                }

                if (clickCount == 2)
                {
                    Thread.Sleep(100);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ClickInterval()
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }
            int h = Convert.ToInt32(textBox1.Text) * 60 * 60 * 1000;
            int m = Convert.ToInt32(textBox2.Text) * 60 * 1000;
            int s = Convert.ToInt32(textBox4.Text) * 1000;
            int ms = Convert.ToInt32(textBox3.Text);
            clickInterval = h + m + s + ms;
            if (clickInterval > 0)
            {
                timer.Interval = clickInterval;
            }
            else
            {
                timer.Interval = 1;
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            ToggleAutoClicker();
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            toggleKey = e.KeyCode;
            textBox5.Text = toggleKey.ToString();
            label1.Focus();
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = toggleKey.ToString();
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Focus();
            if (comboBox1.SelectedIndex == 0)
            {
                mouseButton = MouseButtons.Left;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                mouseButton = MouseButtons.Right;
            }
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            label1.Focus();
            if (comboBox2.SelectedIndex == 0)
            {
                clickCount = 1;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                clickCount = 2;
            }
        }

        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragStartPoint = e.Location;
            }
        }

        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point dragOffset = Point.Subtract(e.Location, new Size(dragStartPoint));
                Location = Point.Add(Location, (Size)dragOffset);
            }
        }

        private void PanelMove_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void EnableControls()
        {
            foreach (Control control in Controls)
            {
                if (!excludedControls.Contains(control))
                {
                    control.Enabled = true;
                }
            }
        }

        private void DisableControls()
        {
            foreach (Control control in Controls)
            {
                if (!excludedControls.Contains(control))
                {
                    control.Enabled = false;
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            ClickInterval();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                label1.Focus();
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void Form1_Click_1(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void groupBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }
    }

    public class LowLevelKeyboardHook
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_SYSKEYDOWN = 0x0104;
        private const int WM_KEYUP = 0x0101;
        private const int WM_SYSKEYUP = 0x0105;

        private LowLevelKeyboardProc _proc;
        private IntPtr _hookID = IntPtr.Zero;

        public event KeyEventHandler KeyDown;

        public LowLevelKeyboardHook()
        {
            _proc = HookCallback;
        }

        public void Install()
        {
            _hookID = SetHook(_proc);
        }

        public void Uninstall()
        {
            UnhookWindowsHookEx(_hookID);
        }

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process currentProcess = Process.GetCurrentProcess())
            using (ProcessModule currentModule = currentProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(currentModule.ModuleName), 0);
            }
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && (wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_SYSKEYDOWN))
            {
                int vkCode = Marshal.ReadInt32(lParam);
                KeyEventArgs args = new KeyEventArgs((Keys)vkCode);
                KeyDown?.Invoke(this, args);
                if (args.Handled)
                {
                    return (IntPtr)1; // Block the key press event
                }
            }

            return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}