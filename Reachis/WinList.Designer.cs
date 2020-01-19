namespace Reachis
{
    partial class WinList
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_TaskWL = new System.Windows.Forms.Label();
            this.label_WL_Time = new System.Windows.Forms.Label();
            this.button_Edit_Task = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_TaskWL
            // 
            this.label_TaskWL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.label_TaskWL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_TaskWL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TaskWL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_TaskWL.Location = new System.Drawing.Point(4, 1);
            this.label_TaskWL.Name = "label_TaskWL";
            this.label_TaskWL.Size = new System.Drawing.Size(244, 17);
            this.label_TaskWL.TabIndex = 0;
            this.label_TaskWL.Text = "label1";
            this.label_TaskWL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_WL_Time
            // 
            this.label_WL_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.label_WL_Time.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_WL_Time.Location = new System.Drawing.Point(91, 16);
            this.label_WL_Time.Name = "label_WL_Time";
            this.label_WL_Time.Size = new System.Drawing.Size(65, 19);
            this.label_WL_Time.TabIndex = 1;
            this.label_WL_Time.Text = "0";
            this.label_WL_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Edit_Task
            // 
            this.button_Edit_Task.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.button_Edit_Task.BackgroundImage = global::Reachis.Properties.Resources.document;
            this.button_Edit_Task.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Edit_Task.FlatAppearance.BorderSize = 0;
            this.button_Edit_Task.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit_Task.Location = new System.Drawing.Point(246, 2);
            this.button_Edit_Task.Name = "button_Edit_Task";
            this.button_Edit_Task.Size = new System.Drawing.Size(40, 27);
            this.button_Edit_Task.TabIndex = 4;
            this.button_Edit_Task.UseVisualStyleBackColor = false;
            this.button_Edit_Task.Click += new System.EventHandler(this.Button_Edit_Task_Click);
            // 
            // WinList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reachis.Properties.Resources.BackGr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button_Edit_Task);
            this.Controls.Add(this.label_WL_Time);
            this.Controls.Add(this.label_TaskWL);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WinList";
            this.Size = new System.Drawing.Size(295, 33);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_TaskWL;
        private System.Windows.Forms.Label label_WL_Time;
        private System.Windows.Forms.Button button_Edit_Task;
    }
}
