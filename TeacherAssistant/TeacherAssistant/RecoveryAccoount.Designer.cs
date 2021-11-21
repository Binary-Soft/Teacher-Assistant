
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
            this.Get_Security_Key = new System.Windows.Forms.TextBox();
            this.Security = new System.Windows.Forms.Label();
            this.Submit = new TeacherAssistant.CustomButton();
            this.Back = new TeacherAssistant.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Get_Email
            // 
            this.Get_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get_Email.Location = new System.Drawing.Point(597, 248);
            this.Get_Email.Name = "Get_Email";
            this.Get_Email.Size = new System.Drawing.Size(190, 29);
            this.Get_Email.TabIndex = 15;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Email.Location = new System.Drawing.Point(657, 220);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(77, 25);
            this.Email.TabIndex = 16;
            this.Email.Text = "Email:";
            // 
            // Get_Security_Key
            // 
            this.Get_Security_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get_Security_Key.Location = new System.Drawing.Point(597, 338);
            this.Get_Security_Key.Name = "Get_Security_Key";
            this.Get_Security_Key.Size = new System.Drawing.Size(190, 29);
            this.Get_Security_Key.TabIndex = 116;
            // 
            // Security
            // 
            this.Security.AutoSize = true;
            this.Security.BackColor = System.Drawing.Color.Transparent;
            this.Security.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Security.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Security.Location = new System.Drawing.Point(592, 310);
            this.Security.Name = "Security";
            this.Security.Size = new System.Drawing.Size(208, 25);
            this.Security.TabIndex = 115;
            this.Security.Text = "Enter Security Key";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Submit.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.Submit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Submit.BorderRadius = 20;
            this.Submit.BorderSize = 0;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(612, 387);
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
            this.Back.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Back.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.Back.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Back.BorderRadius = 20;
            this.Back.BorderSize = 0;
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(930, 589);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(150, 40);
            this.Back.TabIndex = 113;
            this.Back.Text = "< Back";
            this.Back.TextColor = System.Drawing.Color.White;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 420);
            this.panel1.TabIndex = 117;
            // 
            // RecoveryAccoount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1092, 641);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Get_Security_Key);
            this.Controls.Add(this.Security);
            this.Controls.Add(this.Get_Email);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Email);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecoveryAccoount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recovery Account";
            this.Load += new System.EventHandler(this.RecoveryAccoount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Get_Email;
        private System.Windows.Forms.Label Email;
        private CustomButton Back;
        private CustomButton Submit;
        private System.Windows.Forms.TextBox Get_Security_Key;
        private System.Windows.Forms.Label Security;
        private System.Windows.Forms.Panel panel1;
    }
}