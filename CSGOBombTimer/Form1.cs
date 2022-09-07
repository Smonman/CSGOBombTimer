using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSGOBombTimer
{
    public partial class Form_Main : Form
    {
        public const int WM_HOTKEY_MSG_ID = 0x0312;

        private KeyHandler keyHandler;
        private Timer timer;
        private int startTimeSec = 40;
        private int defuseTimeSec = 10;
        private int defuseTimeKitSec = 5;
        private int counter;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            keyHandler = new KeyHandler(Keys.F1, this);
            _ = keyHandler.Register();

            timer = new Timer();

            InitTimer();
        }

        private void InitTimer()
        {
            timer.Stop();
            timer.Tick -= Timer_Tick;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            counter = startTimeSec;
            UpdateLabel(counter);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            counter--;
            UpdateLabel(counter);
            if (counter <= 0)
            {
                InitTimer();
            }
        }

        private void UpdateLabel(int counter)
        {
            string seperator = ":";
            Color c;

            if (counter > defuseTimeSec)
            {
                c = Color.Transparent;
            }
            else
            {
                c = counter > defuseTimeKitSec ? Color.Orange : Color.Red;
            }
            label_timer.BackColor = c;

            label_timer.Text = "00" + seperator + counter.ToString("D2");
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Dispose();
            _ = keyHandler.Unregister();
        }

        private void HandleHotkey()
        {
            InitTimer();
            timer.Start();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }
    }
}
