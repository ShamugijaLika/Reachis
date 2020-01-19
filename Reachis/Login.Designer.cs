namespace Reachis
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Sign = new System.Windows.Forms.Button();
            this.button_Registr = new System.Windows.Forms.Button();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.pictureBox1.BackgroundImage = global::Reachis.Properties.Resources.BackLog;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 415);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            // 
            // button_Sign
            // 
            this.button_Sign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(27)))));
            this.button_Sign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Sign.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(27)))));
            this.button_Sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.button_Sign.Location = new System.Drawing.Point(79, 265);
            this.button_Sign.Name = "button_Sign";
            this.button_Sign.Size = new System.Drawing.Size(211, 48);
            this.button_Sign.TabIndex = 1;
            this.button_Sign.Text = "Вход";
            this.button_Sign.UseVisualStyleBackColor = false;
            this.button_Sign.Click += new System.EventHandler(this.Button_Sign_Click);
            // 
            // button_Registr
            // 
            this.button_Registr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.button_Registr.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Registr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Registr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Registr.Location = new System.Drawing.Point(79, 323);
            this.button_Registr.Name = "button_Registr";
            this.button_Registr.Size = new System.Drawing.Size(211, 48);
            this.button_Registr.TabIndex = 2;
            this.button_Registr.Text = "Регистрация";
            this.button_Registr.UseVisualStyleBackColor = false;
            this.button_Registr.Click += new System.EventHandler(this.Button_Registr_Click);
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.textBox_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(27)))));
            this.textBox_UserName.Location = new System.Drawing.Point(79, 88);
            this.textBox_UserName.Multiline = true;
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(211, 34);
            this.textBox_UserName.TabIndex = 3;
            this.textBox_UserName.Text = "Логин";
            this.textBox_UserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_UserName_MouseClick);
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_email.Location = new System.Drawing.Point(79, 200);
            this.textBox_email.Multiline = true;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(211, 34);
            this.textBox_email.TabIndex = 4;
            this.textBox_email.Text = "E-mail";
            this.textBox_email.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_email_MouseClick);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(27)))));
            this.textBox_Password.Location = new System.Drawing.Point(79, 146);
            this.textBox_Password.Multiline = true;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(211, 34);
            this.textBox_Password.TabIndex = 5;
            this.textBox_Password.Text = "Пароль";
            this.textBox_Password.UseSystemPasswordChar = true;
            this.textBox_Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_Password_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(27)))));
            this.panel1.Location = new System.Drawing.Point(79, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 3);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(27)))));
            this.panel2.Location = new System.Drawing.Point(79, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 3);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(79, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 3);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.button_Registr);
            this.Controls.Add(this.button_Sign);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Sign;
        private System.Windows.Forms.Button button_Registr;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}