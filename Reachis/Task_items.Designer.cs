namespace Reachis
{
    partial class Task_items
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_del_task = new System.Windows.Forms.Button();
            this.label_add_task = new System.Windows.Forms.Label();
            this.Button_Pomodoro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TimeToday = new System.Windows.Forms.Label();
            this.labelPomo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_del_task
            // 
            this.button_del_task.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.button_del_task.BackgroundImage = global::Reachis.Properties.Resources.lulu_trash;
            this.button_del_task.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_del_task.FlatAppearance.BorderSize = 0;
            this.button_del_task.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_del_task.Location = new System.Drawing.Point(609, 5);
            this.button_del_task.Name = "button_del_task";
            this.button_del_task.Size = new System.Drawing.Size(55, 46);
            this.button_del_task.TabIndex = 1;
            this.button_del_task.UseVisualStyleBackColor = false;
            this.button_del_task.Click += new System.EventHandler(this.Button_del_task_Click);
            // 
            // label_add_task
            // 
            this.label_add_task.AutoSize = true;
            this.label_add_task.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.label_add_task.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_add_task.Font = new System.Drawing.Font("Segoe Script", 12F);
            this.label_add_task.ForeColor = System.Drawing.SystemColors.Control;
            this.label_add_task.Location = new System.Drawing.Point(27, 11);
            this.label_add_task.Name = "label_add_task";
            this.label_add_task.Size = new System.Drawing.Size(81, 32);
            this.label_add_task.TabIndex = 2;
            this.label_add_task.Text = "label1";
            // 
            // Button_Pomodoro
            // 
            this.Button_Pomodoro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.Button_Pomodoro.BackgroundImage = global::Reachis.Properties.Resources.Pomodoro_2;
            this.Button_Pomodoro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Pomodoro.FlatAppearance.BorderSize = 0;
            this.Button_Pomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Pomodoro.Font = new System.Drawing.Font("Mistral", 0.01F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Pomodoro.ForeColor = System.Drawing.Color.Maroon;
            this.Button_Pomodoro.Location = new System.Drawing.Point(560, 6);
            this.Button_Pomodoro.Name = "Button_Pomodoro";
            this.Button_Pomodoro.Size = new System.Drawing.Size(43, 41);
            this.Button_Pomodoro.TabIndex = 5;
            this.Button_Pomodoro.Text = "0";
            this.Button_Pomodoro.UseVisualStyleBackColor = false;
            this.Button_Pomodoro.Click += new System.EventHandler(this.Button_Pomodoro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Rockwell", 7.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(27)))));
            this.label1.Location = new System.Drawing.Point(389, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Потрачено минут:";
            // 
            // label_TimeToday
            // 
            this.label_TimeToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.label_TimeToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_TimeToday.Font = new System.Drawing.Font("Rockwell", 7.8F);
            this.label_TimeToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(27)))));
            this.label_TimeToday.Location = new System.Drawing.Point(389, 27);
            this.label_TimeToday.Name = "label_TimeToday";
            this.label_TimeToday.Size = new System.Drawing.Size(131, 24);
            this.label_TimeToday.TabIndex = 9;
            this.label_TimeToday.Text = "0";
            this.label_TimeToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPomo
            // 
            this.labelPomo.AutoSize = true;
            this.labelPomo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.labelPomo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.labelPomo.Location = new System.Drawing.Point(257, 6);
            this.labelPomo.Name = "labelPomo";
            this.labelPomo.Size = new System.Drawing.Size(0, 17);
            this.labelPomo.TabIndex = 11;
            // 
            // Task_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Reachis.Properties.Resources.BackGr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label_TimeToday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Pomodoro);
            this.Controls.Add(this.label_add_task);
            this.Controls.Add(this.button_del_task);
            this.Controls.Add(this.labelPomo);
            this.DoubleBuffered = true;
            this.Name = "Task_items";
            this.Size = new System.Drawing.Size(681, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button button_del_task;
        public System.Windows.Forms.Label label_add_task;
        private System.Windows.Forms.Button Button_Pomodoro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TimeToday;
        private System.Windows.Forms.Label labelPomo;
    }
}
