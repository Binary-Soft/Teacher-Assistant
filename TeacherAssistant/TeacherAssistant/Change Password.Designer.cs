
namespace TeacherAssistant
{
    partial class Change_Password_Form
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
            this.Comfirm_Password = new System.Windows.Forms.Label();
            this.Get_Comfirm_Password = new System.Windows.Forms.TextBox();
            this.Get_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.No_Change = new TeacherAssistant.CustomButton();
            this.Save_Change = new TeacherAssistant.CustomButton();
            this.SuspendLayout();
            // 
            // Comfirm_Password
            // 
            this.Comfirm_Password.AutoSize = true;
            this.Comfirm_Password.BackColor = System.Drawing.Color.Transparent;
            this.Comfirm_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comfirm_Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Comfirm_Password.Location = new System.Drawing.Point(203, 133);
            this.Comfirm_Password.Name = "Comfirm_Password";
            this.Comfirm_Password.Size = new System.Drawing.Size(209, 25);
            this.Comfirm_Password.TabIndex = 18;
            this.Comfirm_Password.Text = "Confirm Password:";
            // 
            // Get_Comfirm_Password
            // 
            this.Get_Comfirm_Password.Location = new System.Drawing.Point(208, 176);
            this.Get_Comfirm_Password.Name = "Get_Comfirm_Password";
            this.Get_Comfirm_Password.Size = new System.Drawing.Size(190, 20);
            this.Get_Comfirm_Password.TabIndex = 17;
            // 
            // Get_Password
            // 
            this.Get_Password.Location = new System.Drawing.Point(208, 86);
            this.Get_Password.Name = "Get_Password";
            this.Get_Password.Size = new System.Drawing.Size(190, 20);
            this.Get_Password.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(243, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password:";
            // 
            // No_Change
            // 
            this.No_Change.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.No_Change.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.No_Change.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.No_Change.BorderRadius = 20;
            this.No_Change.BorderSize = 0;
            this.No_Change.FlatAppearance.BorderSize = 0;
            this.No_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No_Change.ForeColor = System.Drawing.Color.White;
            this.No_Change.Location = new System.Drawing.Point(324, 232);
            this.No_Change.Name = "No_Change";
            this.No_Change.Size = new System.Drawing.Size(106, 40);
            this.No_Change.TabIndex = 117;
            this.No_Change.Text = "No Change";
            this.No_Change.TextColor = System.Drawing.Color.White;
            this.No_Change.UseVisualStyleBackColor = false;
            this.No_Change.Click += new System.EventHandler(this.No_Change_Click);
            // 
            // Save_Change
            // 
            this.Save_Change.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Save_Change.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Save_Change.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Save_Change.BorderRadius = 20;
            this.Save_Change.BorderSize = 0;
            this.Save_Change.FlatAppearance.BorderSize = 0;
            this.Save_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Change.ForeColor = System.Drawing.Color.White;
            this.Save_Change.Location = new System.Drawing.Point(192, 228);
            this.Save_Change.Name = "Save_Change";
            this.Save_Change.Size = new System.Drawing.Size(106, 40);
            this.Save_Change.TabIndex = 115;
            this.Save_Change.Text = "Save Change";
            this.Save_Change.TextColor = System.Drawing.Color.White;
            this.Save_Change.UseVisualStyleBackColor = false;
            this.Save_Change.Click += new System.EventHandler(this.Save_Change_Click);
            // 
            // Change_Password_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.No_Change);
            this.Controls.Add(this.Save_Change);
            this.Controls.Add(this.Comfirm_Password);
            this.Controls.Add(this.Get_Comfirm_Password);
            this.Controls.Add(this.Get_Password);
            this.Controls.Add(this.label3);
            this.Name = "Change_Password_Form";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Comfirm_Password;
        private System.Windows.Forms.TextBox Get_Comfirm_Password;
        private System.Windows.Forms.TextBox Get_Password;
        private System.Windows.Forms.Label label3;
        private CustomButton Save_Change;
        private CustomButton No_Change;
    }
}