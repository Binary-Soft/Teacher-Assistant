
namespace TeacherAssistant
{
    partial class Registration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Form));
            this.Submit = new System.Windows.Forms.Button();
            this.Full_Name = new System.Windows.Forms.Label();
            this.Get_Full_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Get_Password = new System.Windows.Forms.TextBox();
            this.Get_Comfirm_Password = new System.Windows.Forms.TextBox();
            this.Comfirm_Password = new System.Windows.Forms.Label();
            this.Get_Email = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(620, 439);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(150, 45);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Full_Name
            // 
            this.Full_Name.AutoSize = true;
            this.Full_Name.BackColor = System.Drawing.Color.Transparent;
            this.Full_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Full_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Full_Name.Location = new System.Drawing.Point(635, 88);
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.Size = new System.Drawing.Size(125, 25);
            this.Full_Name.TabIndex = 5;
            this.Full_Name.Text = "Full Name:";
            // 
            // Get_Full_Name
            // 
            this.Get_Full_Name.Location = new System.Drawing.Point(600, 130);
            this.Get_Full_Name.Name = "Get_Full_Name";
            this.Get_Full_Name.Size = new System.Drawing.Size(190, 20);
            this.Get_Full_Name.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(635, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            // 
            // Get_Password
            // 
            this.Get_Password.Location = new System.Drawing.Point(600, 295);
            this.Get_Password.Name = "Get_Password";
            this.Get_Password.Size = new System.Drawing.Size(190, 20);
            this.Get_Password.TabIndex = 12;
            // 
            // Get_Comfirm_Password
            // 
            this.Get_Comfirm_Password.Location = new System.Drawing.Point(600, 385);
            this.Get_Comfirm_Password.Name = "Get_Comfirm_Password";
            this.Get_Comfirm_Password.Size = new System.Drawing.Size(190, 20);
            this.Get_Comfirm_Password.TabIndex = 13;
            // 
            // Comfirm_Password
            // 
            this.Comfirm_Password.AutoSize = true;
            this.Comfirm_Password.BackColor = System.Drawing.Color.Transparent;
            this.Comfirm_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comfirm_Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Comfirm_Password.Location = new System.Drawing.Point(595, 342);
            this.Comfirm_Password.Name = "Comfirm_Password";
            this.Comfirm_Password.Size = new System.Drawing.Size(209, 25);
            this.Comfirm_Password.TabIndex = 14;
            this.Comfirm_Password.Text = "Confirm Password:";
            // 
            // Get_Email
            // 
            this.Get_Email.Location = new System.Drawing.Point(600, 215);
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
            this.Email.Location = new System.Drawing.Point(664, 175);
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
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1092, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Get_Email);
            this.Controls.Add(this.Comfirm_Password);
            this.Controls.Add(this.Get_Comfirm_Password);
            this.Controls.Add(this.Get_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Get_Full_Name);
            this.Controls.Add(this.Full_Name);
            this.Controls.Add(this.Submit);
            this.Name = "Registration_Form";
            this.Text = "Registration Form";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label Full_Name;
        private System.Windows.Forms.TextBox Get_Full_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Get_Password;
        private System.Windows.Forms.TextBox Get_Comfirm_Password;
        private System.Windows.Forms.Label Comfirm_Password;
        private System.Windows.Forms.TextBox Get_Email;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}