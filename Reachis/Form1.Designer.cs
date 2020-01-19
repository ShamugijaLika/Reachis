namespace Reachis
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.Calendar_Button = new System.Windows.Forms.Button();
            this.Profile_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Option_Button = new System.Windows.Forms.Button();
            this.Task_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.calendars_Control1 = new Reachis.Calendars_Control();
            this.options_Control1 = new Reachis.Options_Control();
            this.profiles_Control1 = new Reachis.Profiles_Control();
            this.tasks_Control1 = new Reachis.Tasks_Control();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.Calendar_Button);
            this.panel1.Controls.Add(this.Profile_Button);
            this.panel1.Controls.Add(this.Exit_Button);
            this.panel1.Controls.Add(this.Option_Button);
            this.panel1.Controls.Add(this.Task_Button);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 595);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Orange;
            this.SidePanel.Location = new System.Drawing.Point(0, 206);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(19, 79);
            this.SidePanel.TabIndex = 7;
            // 
            // Calendar_Button
            // 
            this.Calendar_Button.FlatAppearance.BorderSize = 0;
            this.Calendar_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calendar_Button.Image = global::Reachis.Properties.Resources.calendar_1;
            this.Calendar_Button.Location = new System.Drawing.Point(147, 524);
            this.Calendar_Button.Name = "Calendar_Button";
            this.Calendar_Button.Size = new System.Drawing.Size(62, 54);
            this.Calendar_Button.TabIndex = 6;
            this.Calendar_Button.UseVisualStyleBackColor = true;
            this.Calendar_Button.Click += new System.EventHandler(this.Calendar_Button_Click);
            // 
            // Profile_Button
            // 
            this.Profile_Button.FlatAppearance.BorderSize = 0;
            this.Profile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile_Button.Font = new System.Drawing.Font("Rockwell", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile_Button.ForeColor = System.Drawing.Color.Orange;
            this.Profile_Button.Image = global::Reachis.Properties.Resources.Profile_1;
            this.Profile_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile_Button.Location = new System.Drawing.Point(23, 206);
            this.Profile_Button.Name = "Profile_Button";
            this.Profile_Button.Size = new System.Drawing.Size(199, 79);
            this.Profile_Button.TabIndex = 5;
            this.Profile_Button.Text = "     Профиль";
            this.Profile_Button.UseVisualStyleBackColor = true;
            this.Profile_Button.Click += new System.EventHandler(this.Profile_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Rockwell", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.ForeColor = System.Drawing.Color.Orange;
            this.Exit_Button.Image = global::Reachis.Properties.Resources.Exit_1;
            this.Exit_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_Button.Location = new System.Drawing.Point(23, 430);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(199, 79);
            this.Exit_Button.TabIndex = 4;
            this.Exit_Button.Text = "      Выход";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Option_Button
            // 
            this.Option_Button.FlatAppearance.BorderSize = 0;
            this.Option_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option_Button.Font = new System.Drawing.Font("Rockwell", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option_Button.ForeColor = System.Drawing.Color.Orange;
            this.Option_Button.Image = global::Reachis.Properties.Resources.Щзешщты_1;
            this.Option_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Option_Button.Location = new System.Drawing.Point(23, 357);
            this.Option_Button.Name = "Option_Button";
            this.Option_Button.Size = new System.Drawing.Size(199, 79);
            this.Option_Button.TabIndex = 3;
            this.Option_Button.Text = "     Опции";
            this.Option_Button.UseVisualStyleBackColor = true;
            this.Option_Button.Click += new System.EventHandler(this.Option_Button_Click);
            // 
            // Task_Button
            // 
            this.Task_Button.FlatAppearance.BorderSize = 0;
            this.Task_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Task_Button.Font = new System.Drawing.Font("Rockwell", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task_Button.ForeColor = System.Drawing.Color.Orange;
            this.Task_Button.Image = global::Reachis.Properties.Resources.Task_1;
            this.Task_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Task_Button.Location = new System.Drawing.Point(23, 282);
            this.Task_Button.Name = "Task_Button";
            this.Task_Button.Size = new System.Drawing.Size(199, 79);
            this.Task_Button.TabIndex = 2;
            this.Task_Button.Text = "     Задачи";
            this.Task_Button.UseVisualStyleBackColor = true;
            this.Task_Button.Click += new System.EventHandler(this.Task_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TDList";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // calendars_Control1
            // 
            this.calendars_Control1.Location = new System.Drawing.Point(222, 0);
            this.calendars_Control1.Name = "calendars_Control1";
            this.calendars_Control1.Size = new System.Drawing.Size(718, 590);
            this.calendars_Control1.TabIndex = 4;
            this.calendars_Control1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Calendars_Control1_MouseDown);
            // 
            // options_Control1
            // 
            this.options_Control1.Location = new System.Drawing.Point(222, 0);
            this.options_Control1.Name = "options_Control1";
            this.options_Control1.Size = new System.Drawing.Size(718, 585);
            this.options_Control1.TabIndex = 3;
            this.options_Control1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Options_Control1_MouseDown);
            // 
            // profiles_Control1
            // 
            this.profiles_Control1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.profiles_Control1.Location = new System.Drawing.Point(222, 0);
            this.profiles_Control1.Name = "profiles_Control1";
            this.profiles_Control1.Size = new System.Drawing.Size(723, 585);
            this.profiles_Control1.TabIndex = 2;
            this.profiles_Control1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Profiles_Control1_MouseDown);
            // 
            // tasks_Control1
            // 
            this.tasks_Control1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tasks_Control1.Location = new System.Drawing.Point(222, 0);
            this.tasks_Control1.Name = "tasks_Control1";
            this.tasks_Control1.NumberUser = null;
            this.tasks_Control1.Size = new System.Drawing.Size(718, 582);
            this.tasks_Control1.TabIndex = 1;
            this.tasks_Control1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tasks_Control1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 589);
            this.Controls.Add(this.calendars_Control1);
            this.Controls.Add(this.options_Control1);
            this.Controls.Add(this.profiles_Control1);
            this.Controls.Add(this.tasks_Control1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Profile_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Option_Button;
        private System.Windows.Forms.Button Task_Button;
        private System.Windows.Forms.Button Calendar_Button;
        private System.Windows.Forms.Panel SidePanel;
        private Tasks_Control tasks_Control1;
        private Profiles_Control profiles_Control1;
        private Options_Control options_Control1;
        private Calendars_Control calendars_Control1;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

