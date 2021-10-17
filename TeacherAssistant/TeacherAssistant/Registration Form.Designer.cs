
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
            this.Submit = new System.Windows.Forms.Button();
            this.Full_Name = new System.Windows.Forms.Label();
            this.Get_Full_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Get_Password = new System.Windows.Forms.TextBox();
            this.Get_Comfirm_Password = new System.Windows.Forms.TextBox();
            this.Comfirm_Password = new System.Windows.Forms.Label();
            this.Get_Email = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(306, 344);
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
            this.Full_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Full_Name.Location = new System.Drawing.Point(297, 9);
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.Size = new System.Drawing.Size(125, 25);
            this.Full_Name.TabIndex = 5;
            this.Full_Name.Text = "Full Name:";
            // 
            // Get_Full_Name
            // 
            this.Get_Full_Name.Location = new System.Drawing.Point(302, 48);
            this.Get_Full_Name.Name = "Get_Full_Name";
            this.Get_Full_Name.Size = new System.Drawing.Size(190, 20);
            this.Get_Full_Name.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            // 
            // Get_Password
            // 
            this.Get_Password.Location = new System.Drawing.Point(293, 201);
            this.Get_Password.Name = "Get_Password";
            this.Get_Password.Size = new System.Drawing.Size(190, 20);
            this.Get_Password.TabIndex = 12;
            // 
            // Get_Comfirm_Password
            // 
            this.Get_Comfirm_Password.Location = new System.Drawing.Point(293, 262);
            this.Get_Comfirm_Password.Name = "Get_Comfirm_Password";
            this.Get_Comfirm_Password.Size = new System.Drawing.Size(190, 20);
            this.Get_Comfirm_Password.TabIndex = 13;
            // 
            // Comfirm_Password
            // 
            this.Comfirm_Password.AutoSize = true;
            this.Comfirm_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comfirm_Password.Location = new System.Drawing.Point(297, 224);
            this.Comfirm_Password.Name = "Comfirm_Password";
            this.Comfirm_Password.Size = new System.Drawing.Size(214, 25);
            this.Comfirm_Password.TabIndex = 14;
            this.Comfirm_Password.Text = "Comfirm Password:";
            // 
            // Get_Email
            // 
            this.Get_Email.Location = new System.Drawing.Point(302, 127);
            this.Get_Email.Name = "Get_Email";
            this.Get_Email.Size = new System.Drawing.Size(190, 20);
            this.Get_Email.TabIndex = 15;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(301, 87);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(77, 25);
            this.Email.TabIndex = 16;
            this.Email.Text = "Email:";
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}