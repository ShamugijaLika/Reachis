namespace Reachis
{
    partial class Tasks_Control
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_Tasks = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_add_tasks = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_add_task = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(27)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(3, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 497);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel_Tasks
            // 
            this.flowLayoutPanel_Tasks.AutoScroll = true;
            this.flowLayoutPanel_Tasks.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel_Tasks.Location = new System.Drawing.Point(26, 21);
            this.flowLayoutPanel_Tasks.Name = "flowLayoutPanel_Tasks";
            this.flowLayoutPanel_Tasks.Size = new System.Drawing.Size(688, 497);
            this.flowLayoutPanel_Tasks.TabIndex = 3;
            // 
            // textBox_add_tasks
            // 
            this.textBox_add_tasks.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_add_tasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_add_tasks.Location = new System.Drawing.Point(43, 533);
            this.textBox_add_tasks.Multiline = true;
            this.textBox_add_tasks.Name = "textBox_add_tasks";
            this.textBox_add_tasks.Size = new System.Drawing.Size(546, 28);
            this.textBox_add_tasks.TabIndex = 6;
            this.textBox_add_tasks.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_add_tasks_KeyUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.panel3.Location = new System.Drawing.Point(43, 561);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(546, 2);
            this.panel3.TabIndex = 7;
            // 
            // button_add_task
            // 
            this.button_add_task.BackgroundImage = global::Reachis.Properties.Resources.Add;
            this.button_add_task.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_add_task.FlatAppearance.BorderSize = 0;
            this.button_add_task.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_task.Location = new System.Drawing.Point(636, 524);
            this.button_add_task.Name = "button_add_task";
            this.button_add_task.Size = new System.Drawing.Size(57, 47);
            this.button_add_task.TabIndex = 5;
            this.button_add_task.UseVisualStyleBackColor = true;
            this.button_add_task.Click += new System.EventHandler(this.Button_add_task_Click);
            // 
            // Tasks_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox_add_tasks);
            this.Controls.Add(this.button_add_task);
            this.Controls.Add(this.flowLayoutPanel_Tasks);
            this.Controls.Add(this.panel1);
            this.Name = "Tasks_Control";
            this.Size = new System.Drawing.Size(717, 585);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Tasks;
        private System.Windows.Forms.Button button_add_task;
        private System.Windows.Forms.TextBox textBox_add_tasks;
        private System.Windows.Forms.Panel panel3;
    }
}
