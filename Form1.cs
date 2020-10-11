using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace MouseRecorder1
{
    public partial class Form1 : Form
    {
        ListViewItem ActionList;
        int PlayFromList, RecToList;
        string lmc = "L_CLICK";
        string rmc = "R_CLICK";

        bool lastM1down = false;
        bool lastM2down = false;

        bool playHotkey = false;
        bool recHotkey = false;
        bool stopHotkey = false;

        int playRepeatValue;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(UInt16 virtualKeyCode);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        public const int MOUSEEVENTF_RIGHTUP = 0x0010;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_rec_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlayFromList = 0;
            RecToList = 0;
            timer_hotkeys.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActionList = new ListViewItem(Cursor.Position.X.ToString());
            ActionList.SubItems.Add(Cursor.Position.Y.ToString());

            if (Control.MouseButtons == MouseButtons.Left)
            {
                ActionList.SubItems.Add(lmc.ToString());
            }
            else if (Control.MouseButtons == MouseButtons.Right)
            {
                ActionList.SubItems.Add(rmc.ToString());
            }
            else
            {
                ActionList.SubItems.Add("move".ToString());
            }

            listView1.Items.Add(ActionList);
            RecToList++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = Decimal.ToInt32(playSPEED.Value);

            if (PlayFromList != RecToList)
            {
                int X = int.Parse(listView1.Items[PlayFromList].SubItems[0].Text);
                int Y = int.Parse(listView1.Items[PlayFromList].SubItems[1].Text);
                uint dX = uint.Parse(listView1.Items[PlayFromList].SubItems[0].Text);
                uint dY = uint.Parse(listView1.Items[PlayFromList].SubItems[1].Text);

                Cursor.Position = new Point(X, Y);

                if (lastM1down == false)
                {
                    if (listView1.Items[PlayFromList].SubItems[2].Text == lmc)
                    {
                        mouse_event(MOUSEEVENTF_LEFTDOWN, dX, dY, 0, 0);
                        lastM1down = true;
                    }
                }
                else if (lastM1down == true)
                {
                    if (listView1.Items[PlayFromList].SubItems[2].Text == lmc)
                    {
                        lastM1down = true;
                    }
                    if(listView1.Items[PlayFromList].SubItems[2].Text == "move")
                    {
                        mouse_event(MOUSEEVENTF_LEFTUP, dX, dY, 0, 0);
                        lastM1down = false;
                    }
                }

                if (lastM2down == false)
                {
                    if (listView1.Items[PlayFromList].SubItems[2].Text == rmc)
                    {
                        mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, dX, dY, 0, 0);
                        lastM1down = true;
                    }
                }
                else if (lastM2down == true)
                {
                    if (listView1.Items[PlayFromList].SubItems[2].Text == rmc)
                    {
                        lastM2down = true;
                    }
                    if (listView1.Items[PlayFromList].SubItems[2].Text == "move")
                    {
                        mouse_event(MOUSEEVENTF_RIGHTUP, dX, dY, 0, 0);
                        lastM2down = false;
                    }
                }

                PlayFromList++;
            }

            if (PlayFromList == RecToList)
            {
                playRepeatValue--;

                if (playRepeatValue == 0)
                {
                    timer2.Stop();
                }

                PlayFromList = 0;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            PlayFromList = 0;
            RecToList = 0;
            timer1.Stop();
            timer2.Stop();
            listView1.Items.Clear();
        }

        private void timer_hotkeys_Tick(object sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Alt)
            {
                if (playHotkey == false)
                {
                    playHotkey = true;
                }
                else
                {
                    playHotkey = false;
                }

                Thread.Sleep(50);

            }

            if (ModifierKeys == Keys.Control)
            {
                if (recHotkey == false)
                {
                    recHotkey = true;
                }
                else
                {
                    recHotkey = false;
                }

                Thread.Sleep(50);

            }

            if (ModifierKeys == Keys.Shift)
            {
                if (stopHotkey == false)
                {
                    stopHotkey = true;
                }
                else
                {
                    stopHotkey = false;
                }

                Thread.Sleep(50);

            }

            if (playHotkey == true)
            {
                playRepeatValue = decimal.ToInt32(playRepeat.Value);
                PlayFromList = 0;
                timer1.Stop();
                timer2.Start();

                playHotkey = false;
                recHotkey = false;
                stopHotkey = false;

                Thread.Sleep(50);
            }

            if (recHotkey == true)
            {
                timer1.Start();
                timer2.Stop();

                playHotkey = false;
                recHotkey = false;
                stopHotkey = false;

                Thread.Sleep(50);
            }

            if (stopHotkey == true)
            {
                timer1.Stop();
                timer2.Stop();

                playHotkey = false;
                recHotkey = false;
                stopHotkey = false;

                Thread.Sleep(50);
            }

        }

        private void button_play_Click(object sender, EventArgs e)
        {
            playRepeatValue = decimal.ToInt32(playRepeat.Value);
            PlayFromList = 0;
            timer2.Start();
        }
    }
}