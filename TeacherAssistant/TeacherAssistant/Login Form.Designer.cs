
namespace TeacherAssistant
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.login_As = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Show_Password = new System.Windows.Forms.CheckBox();
            this.Login = new TeacherAssistant.CustomButton();
            this.Forget_Password = new TeacherAssistant.CustomButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(471, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            // 
            // login_As
            // 
            this.login_As.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_As.FormattingEnabled = true;
            this.login_As.Location = new System.Drawing.Point(435, 188);
            this.login_As.Name = "login_As";
            this.login_As.Size = new System.Drawing.Size(249, 32);
            this.login_As.TabIndex = 1;
            this.login_As.SelectedIndexChanged += new System.EventHandler(this.login_As_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(527, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(509, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(435, 263);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(249, 29);
            this.Email.TabIndex = 9;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(435, 338);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(249, 29);
            this.Password.TabIndex = 10;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(503, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "User Type:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(54, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 292);
            this.panel3.TabIndex = 13;
            // 
            // Show_Password
            // 
            this.Show_Password.AutoSize = true;
            this.Show_Password.Location = new System.Drawing.Point(690, 348);
            this.Show_Password.Name = "Show_Password";
            this.Show_Password.Size = new System.Drawing.Size(115, 17);
            this.Show_Password.TabIndex = 14;
            this.Show_Password.Text = "Show Password";
            this.Show_Password.UseVisualStyleBackColor = true;
            this.Show_Password.CheckedChanged += new System.EventHandler(this.Show_Password_CheckedChanged);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Login.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.Login.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Login.BorderRadius = 20;
            this.Login.BorderSize = 0;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(490, 384);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(150, 43);
            this.Login.TabIndex = 15;
            this.Login.Text = "Login";
            this.Login.TextColor = System.Drawing.Color.White;
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Forget_Password
            // 
            this.Forget_Password.BackColor = System.Drawing.SystemColors.Highlight;
            this.Forget_Password.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.Forget_Password.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Forget_Password.BorderRadius = 20;
            this.Forget_Password.BorderSize = 0;
            this.Forget_Password.FlatAppearance.BorderSize = 0;
            this.Forget_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Forget_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forget_Password.ForeColor = System.Drawing.Color.White;
            this.Forget_Password.Location = new System.Drawing.Point(490, 443);
            this.Forget_Password.Name = "Forget_Password";
            this.Forget_Password.Size = new System.Drawing.Size(150, 46);
            this.Forget_Password.TabIndex = 16;
            this.Forget_Password.Text = "Forget Password?";
            this.Forget_Password.TextColor = System.Drawing.Color.White;
            this.Forget_Password.UseVisualStyleBackColor = false;
            this.Forget_Password.Click += new System.EventHandler(this.Forget_Password_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1008, 607);
            this.Controls.Add(this.Forget_Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Show_Password);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_As);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox login_As;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox Show_Password;
        private CustomButton Login;
        private CustomButton Forget_Password;
    }
}

