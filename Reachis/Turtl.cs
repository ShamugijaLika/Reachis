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
using System.Data.SqlClient;
using static Reachis.Task_items;

namespace Reachis
{
    public partial class Turtl : Form
    {
        string TO;
        public string Mylabel
        {
            set { TO = value; }
        }

        public Turtl()
        {
            InitializeComponent();
            TransparencyKey = BackColor;

        }

        String dbPathMyDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        static extern bool SetWindowPos(int hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

        public int width = Screen.PrimaryScreen.WorkingArea.Width;
        public int height = Screen.PrimaryScreen.WorkingArea.Height;

        public int TimeOver;

        private void Turtl_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            SetWindowPos(this.Handle.ToInt32(), -1, this.Left, this.Top, this.Width, this.Height, 0x0010);
            this.Location = new System.Drawing.Point(width - this.Size.Width, height - this.Size.Height);
        }

        private void Turtl_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }


        private void Button_35_min_Click(object sender, EventArgs e)
        {
            int time = 35;
            StartPomodoro(time);
        }

        private void Button_45_min_Click(object sender, EventArgs e)
        {
            int time = 45;
            StartPomodoro(time);
        }
        int m, s;
        public int mMax;
        public void StartPomodoro(int minute)
        {

            panel_Pomodoro.BringToFront();
            panel_ForTomePomodoro.Size = MinimumSize;
            timer1.Interval = 1000;

            m = minute;
            mMax = minute;
            s = 0;
            if (m < 10)
            {
                label_Min.Text = "0" + m.ToString();
            }
            else label_Min.Text = m.ToString();
            label_Sec.Text = "0" + s.ToString();

        }

        private void TextBox_time_for_pomodoro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                StartPomodoro(Convert.ToInt32(textBox_time_for_pomodoro.Text));
            }
        }

        private void Button_25_min_Click(object sender, EventArgs e)
        {
            int time = 25;
            StartPomodoro(time);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (s == 0)
            {
                if (m > 0)
                {
                    m--;
                    s = 59;
                    if (m < 10)
                    {
                        label_Min.Text = "0" + m.ToString();
                    }
                    else
                    {
                        label_Min.Text = m.ToString();
                    }
                    label_Sec.Text = s.ToString();
                }
                else
                {
                    timer1.Stop();
                    TimeOver = mMax;
                    UpdateTime();
                }
            }
            else
            {
                if (s <= 10)
                {
                    s--;
                    label_Sec.Text = "0" + s.ToString();
                }
                else
                {
                    s--;
                    label_Sec.Text = s.ToString();
                }
            }
        }

        private void Label_Min_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
            else timer1.Enabled = true;
        }

        private void Label_Sec_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
            else timer1.Enabled = true;

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
            else timer1.Enabled = true;
        }

        private void Panel_Pomodoro_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form1 form1 = new Form1
            {
                WindowState = FormWindowState.Normal,
            };
            form1.TopMost = false;
            form1.Show();
            form1.notifyIcon1.Visible = false;
            form1.ShowInTaskbar = false;
            this.Close();
        }

        private void TextBox_time_for_pomodoro_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_time_for_pomodoro.Clear();
            this.textBox_time_for_pomodoro.ForeColor = System.Drawing.Color.DarkOrange;
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
            else timer1.Enabled = true;
        }



        public void UpdateTime()
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbPathMyDocs + "\\" + "DatabaseL.mdf;Integrated Security=True");

            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("UPDATE TaskTabl Set TaskTimeToday=TaskTimeToday+'" + TimeOver + "' WHERE TaskID='" + Convert.ToInt32(TO) + "'", SQL);
                command.ExecuteReader();
                SQL.Close();
            }
        }

    }
}

