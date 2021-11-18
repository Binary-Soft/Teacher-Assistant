
namespace TeacherAssistant
{
    partial class RecoveryAccoount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoveryAccoount));
            this.Get_Email = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Get_Security_Key = new System.Windows.Forms.TextBox();
            this.Security = new System.Windows.Forms.Label();
            this.Submit = new TeacherAssistant.CustomButton();
            this.Back = new TeacherAssistant.CustomButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Get_Email
            // 
            this.Get_Email.Location = new System.Drawing.Point(576, 188);
            this.Get_Email.Name = "Get_Email";
            this.Get_Email.Size = new System.Drawing.Size(190, 20);
            this.Get_Email.TabIndex = 15;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Email.Location = new System.Drawing.Point(640, 148);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(77, 25);
            this.Email.TabIndex = 16;
            this.Email.Text = "Email:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 650);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(39, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 303);
            this.panel2.TabIndex = 0;
            // 
            // Get_Security_Key
            // 
            this.Get_Security_Key.Location = new System.Drawing.Point(566, 277);
            this.Get_Security_Key.Name = "Get_Security_Key";
            this.Get_Security_Key.Size = new System.Drawing.Size(190, 20);
            this.Get_Security_Key.TabIndex = 116;
            // 
            // Security
            // 
            this.Security.AutoSize = true;
            this.Security.BackColor = System.Drawing.Color.Transparent;
            this.Security.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Security.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Security.Location = new System.Drawing.Point(571, 237);
            this.Security.Name = "Security";
            this.Security.Size = new System.Drawing.Size(208, 25);
            this.Security.TabIndex = 115;
            this.Security.Text = "Enter Security Key";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Submit.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Submit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Submit.BorderRadius = 20;
            this.Submit.BorderSize = 0;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(585, 348);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(150, 40);
            this.Submit.TabIndex = 114;
            this.Submit.Text = "Submit";
            this.Submit.TextColor = System.Drawing.Color.White;
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Back.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Back.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Back.BorderRadius = 20;
            this.Back.BorderSize = 0;
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(917, 32);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(150, 40);
            this.Back.TabIndex = 113;
            this.Back.Text = "< Back";
            this.Back.TextColor = System.Drawing.Color.White;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // RecoveryAccoount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1092, 641);
            this.Controls.Add(this.Get_Security_Key);
            this.Controls.Add(this.Security);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Get_Email);
            this.Name = "RecoveryAccoount";
            this.Text = "Recovery Account";
            this.Load += new System.EventHandler(this.RecoveryAccoount_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Get_Email;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CustomButton Back;
        private CustomButton Submit;
        private System.Windows.Forms.TextBox Get_Security_Key;
        private System.Windows.Forms.Label Security;
    }
}