using System;
using System.Windows.Forms;
using static Reachis.Login;

namespace Reachis
{
    public partial class Form1 : Form
    {
        //public Tasks_Control task;
        string NU_ForForm1;
        public string NumberUserForForm1
        {
            get { return NU_ForForm1; }
            set { NU_ForForm1 = value; }
        }
        public Form1()
        {
            InitializeComponent();
            SidePanel.Top = Task_Button.Top;
            notifyIcon1.Visible = false;
            this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(NotifyIcon1_MouseDoubleClick);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            //task.NumberUser = NumberUserForForm1;
            //tasks_Control1.Controls.Add(task = new Tasks_Control());
            //task.NumberUser = NumberUserForForm1;
            //tasks_Control1.Visible = true;                                              Итог: значение не передается в контрол.
            tasks_Control1.NumberUser = NumberUserForForm1;
            //MessageBox.Show(tasks_Control1.NumberUser);
            tasks_Control1.BringToFront(); 

        }


        private void Profile_Button_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Profile_Button.Height;
            SidePanel.Top = Profile_Button.Top;
            profiles_Control1.BringToFront();
        }

        private void Task_Button_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Task_Button.Height;
            SidePanel.Top = Task_Button.Top;
            tasks_Control1.BringToFront();
        }

        private void Option_Button_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Option_Button.Height;
            SidePanel.Top = Option_Button.Top;
            options_Control1.BringToFront();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Exit_Button.Height;
            SidePanel.Top = Exit_Button.Top;
            this.notifyIcon1.Visible = false;
            Application.Exit();

        }

        private void Calendar_Button_Click(object sender, EventArgs e)
        {
            calendars_Control1.BringToFront();
        }

          private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
          {
              notifyIcon1.Visible = false;
              this.ShowInTaskbar = false;
              WindowState = FormWindowState.Normal;
              this.TopMost = true;
              this.TopMost = false;
          }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }

        }
     
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Calendars_Control1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Options_Control1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Profiles_Control1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Tasks_Control1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
