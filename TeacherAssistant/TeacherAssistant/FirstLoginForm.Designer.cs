﻿
namespace TeacherAssistant
{
    partial class FirstLoginForm
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
            this.Instructor_Password_Change = new System.Windows.Forms.Button();
            this.Instructor_confirm_Security_Key = new System.Windows.Forms.TextBox();
            this.Instructor_New_Security_Key = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Instructor_Confirm_Password = new System.Windows.Forms.TextBox();
            this.Instructor_New_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Instructor_Password_Change
            // 
            this.Instructor_Password_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructor_Password_Change.Location = new System.Drawing.Point(493, 321);
            this.Instructor_Password_Change.Name = "Instructor_Password_Change";
            this.Instructor_Password_Change.Size = new System.Drawing.Size(91, 40);
            this.Instructor_Password_Change.TabIndex = 25;
            this.Instructor_Password_Change.Text = "Submit";
            this.Instructor_Password_Change.UseVisualStyleBackColor = true;
            this.Instructor_Password_Change.Click += new System.EventHandler(this.Instructor_Password_Change_Click);
            // 
            // Instructor_confirm_Security_Key
            // 
            this.Instructor_confirm_Security_Key.Location = new System.Drawing.Point(453, 241);
            this.Instructor_confirm_Security_Key.Name = "Instructor_confirm_Security_Key";
            this.Instructor_confirm_Security_Key.Size = new System.Drawing.Size(190, 20);
            this.Instructor_confirm_Security_Key.TabIndex = 24;
            // 
            // Instructor_New_Security_Key
            // 
            this.Instructor_New_Security_Key.Location = new System.Drawing.Point(443, 162);
            this.Instructor_New_Security_Key.Name = "Instructor_New_Security_Key";
            this.Instructor_New_Security_Key.Size = new System.Drawing.Size(190, 20);
            this.Instructor_New_Security_Key.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Confirm Security Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Security Key";
            // 
            // Instructor_Confirm_Password
            // 
            this.Instructor_Confirm_Password.Location = new System.Drawing.Point(168, 201);
            this.Instructor_Confirm_Password.Name = "Instructor_Confirm_Password";
            this.Instructor_Confirm_Password.Size = new System.Drawing.Size(190, 20);
            this.Instructor_Confirm_Password.TabIndex = 20;
            // 
            // Instructor_New_Password
            // 
            this.Instructor_New_Password.Location = new System.Drawing.Point(158, 122);
            this.Instructor_New_Password.Name = "Instructor_New_Password";
            this.Instructor_New_Password.Size = new System.Drawing.Size(190, 20);
            this.Instructor_New_Password.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Confirm New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "New Password";
            // 
            // FirstLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Instructor_Password_Change);
            this.Controls.Add(this.Instructor_confirm_Security_Key);
            this.Controls.Add(this.Instructor_New_Security_Key);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Instructor_Confirm_Password);
            this.Controls.Add(this.Instructor_New_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FirstLoginForm";
            this.Text = "FirstLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Instructor_Password_Change;
        private System.Windows.Forms.TextBox Instructor_confirm_Security_Key;
        private System.Windows.Forms.TextBox Instructor_New_Security_Key;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Instructor_Confirm_Password;
        private System.Windows.Forms.TextBox Instructor_New_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}