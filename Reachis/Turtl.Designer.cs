namespace Reachis
{
    partial class Turtl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turtl));
            this.button_25_min = new System.Windows.Forms.Button();
            this.button_35_min = new System.Windows.Forms.Button();
            this.button_45_min = new System.Windows.Forms.Button();
            this.textBox_time_for_pomodoro = new System.Windows.Forms.TextBox();
            this.panel_Pomodoro = new System.Windows.Forms.Panel();
            this.panel_ForTomePomodoro = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Sec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Min = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Pomodoro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_25_min
            // 
            this.button_25_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(85)))), ((int)(((byte)(67)))));
            this.button_25_min.FlatAppearance.BorderSize = 0;
            this.button_25_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_25_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(27)))));
            this.button_25_min.Location = new System.Drawing.Point(15, 84);
            this.button_25_min.Margin = new System.Windows.Forms.Padding(0);
            this.button_25_min.Name = "button_25_min";
            this.button_25_min.Size = new System.Drawing.Size(95, 33);
            this.button_25_min.TabIndex = 1;
            this.button_25_min.Text = "25:00";
            this.button_25_min.UseVisualStyleBackColor = false;
            this.button_25_min.Click += new System.EventHandler(this.Button_25_min_Click);
            // 
            // button_35_min
            // 
            this.button_35_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(85)))), ((int)(((byte)(67)))));
            this.button_35_min.FlatAppearance.BorderSize = 0;
            this.button_35_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_35_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(27)))));
            this.button_35_min.Location = new System.Drawing.Point(15, 115);
            this.button_35_min.Margin = new System.Windows.Forms.Padding(0);
            this.button_35_min.Name = "button_35_min";
            this.button_35_min.Size = new System.Drawing.Size(95, 33);
            this.button_35_min.TabIndex = 2;
            this.button_35_min.Text = "35:00";
            this.button_35_min.UseVisualStyleBackColor = false;
            this.button_35_min.Click += new System.EventHandler(this.Button_35_min_Click);
            // 
            // button_45_min
            // 
            this.button_45_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(85)))), ((int)(((byte)(67)))));
            this.button_45_min.FlatAppearance.BorderSize = 0;
            this.button_45_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_45_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(27)))));
            this.button_45_min.Location = new System.Drawing.Point(15, 146);
            this.button_45_min.Margin = new System.Windows.Forms.Padding(0);
            this.button_45_min.Name = "button_45_min";
            this.button_45_min.Size = new System.Drawing.Size(95, 33);
            this.button_45_min.TabIndex = 3;
            this.button_45_min.Text = "45:00";
            this.button_45_min.UseVisualStyleBackColor = false;
            this.button_45_min.Click += new System.EventHandler(this.Button_45_min_Click);
            // 
            // textBox_time_for_pomodoro
            // 
            this.textBox_time_for_pomodoro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(85)))), ((int)(((byte)(67)))));
            this.textBox_time_for_pomodoro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_time_for_pomodoro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox_time_for_pomodoro.Location = new System.Drawing.Point(15, 179);
            this.textBox_time_for_pomodoro.Multiline = true;
            this.textBox_time_for_pomodoro.Name = "textBox_time_for_pomodoro";
            this.textBox_time_for_pomodoro.Size = new System.Drawing.Size(95, 22);
            this.textBox_time_for_pomodoro.TabIndex = 4;
            this.textBox_time_for_pomodoro.Text = "Минуты";
            this.textBox_time_for_pomodoro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_time_for_pomodoro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_time_for_pomodoro_MouseClick);
            this.textBox_time_for_pomodoro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_time_for_pomodoro_KeyUp);
            // 
            // panel_Pomodoro
            // 
            this.panel_Pomodoro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_Pomodoro.BackgroundImage = global::Reachis.Properties.Resources.Pomodoro;
            this.panel_Pomodoro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_Pomodoro.Controls.Add(this.panel_ForTomePomodoro);
            this.panel_Pomodoro.Controls.Add(this.panel1);
            this.panel_Pomodoro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_Pomodoro.Location = new System.Drawing.Point(0, -2);
            this.panel_Pomodoro.Name = "panel_Pomodoro";
            this.panel_Pomodoro.Size = new System.Drawing.Size(462, 367);
            this.panel_Pomodoro.TabIndex = 5;
            this.panel_Pomodoro.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Panel_Pomodoro_MouseDoubleClick);
            // 
            // panel_ForTomePomodoro
            // 
            this.panel_ForTomePomodoro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_ForTomePomodoro.BackgroundImage = global::Reachis.Properties.Resources.Turtl_3_1;
            this.panel_ForTomePomodoro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_ForTomePomodoro.Location = new System.Drawing.Point(12, 11);
            this.panel_ForTomePomodoro.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ForTomePomodoro.Name = "panel_ForTomePomodoro";
            this.panel_ForTomePomodoro.Size = new System.Drawing.Size(444, 344);
            this.panel_ForTomePomodoro.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.label_Sec);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_Min);
            this.panel1.Location = new System.Drawing.Point(171, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 65);
            this.panel1.TabIndex = 7;
            this.panel1.Click += new System.EventHandler(this.Panel1_Click);
            // 
            // label_Sec
            // 
            this.label_Sec.AutoSize = true;
            this.label_Sec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Sec.Location = new System.Drawing.Point(68, 13);
            this.label_Sec.Name = "label_Sec";
            this.label_Sec.Size = new System.Drawing.Size(53, 38);
            this.label_Sec.TabIndex = 1;
            this.label_Sec.Text = "00";
            this.label_Sec.Click += new System.EventHandler(this.Label_Sec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label_Min
            // 
            this.label_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Min.Location = new System.Drawing.Point(-4, 13);
            this.label_Min.Name = "label_Min";
            this.label_Min.Size = new System.Drawing.Size(70, 39);
            this.label_Min.TabIndex = 0;
            this.label_Min.Text = "00";
            this.label_Min.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Min.Click += new System.EventHandler(this.Label_Min_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Turtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(465, 366);
            this.Controls.Add(this.textBox_time_for_pomodoro);
            this.Controls.Add(this.button_45_min);
            this.Controls.Add(this.button_35_min);
            this.Controls.Add(this.button_25_min);
            this.Controls.Add(this.panel_Pomodoro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Turtl";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Turtl";
            this.Load += new System.EventHandler(this.Turtl_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Turtl_MouseDown);
            this.panel_Pomodoro.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_25_min;
        private System.Windows.Forms.Button button_35_min;
        private System.Windows.Forms.Button button_45_min;
        private System.Windows.Forms.TextBox textBox_time_for_pomodoro;
        private System.Windows.Forms.Panel panel_Pomodoro;
        private System.Windows.Forms.Panel panel_ForTomePomodoro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Sec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Min;
        private System.Windows.Forms.Timer timer1;
    }
}