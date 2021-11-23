
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Password_Form));
            this.Comfirm_Password = new System.Windows.Forms.Label();
            this.Get_Comfirm_Password = new System.Windows.Forms.TextBox();
            this.Get_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.No_Change = new TeacherAssistant.CustomButton();
            this.Save_Change = new TeacherAssistant.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Show_Password_Visible = new System.Windows.Forms.CheckBox();
            this.Confirm_Password_Visible = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Comfirm_Password
            // 
            this.Comfirm_Password.AutoSize = true;
            this.Comfirm_Password.BackColor = System.Drawing.Color.Transparent;
            this.Comfirm_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comfirm_Password.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Comfirm_Password.Location = new System.Drawing.Point(384, 187);
            this.Comfirm_Password.Name = "Comfirm_Password";
            this.Comfirm_Password.Size = new System.Drawing.Size(209, 25);
            this.Comfirm_Password.TabIndex = 18;
            this.Comfirm_Password.Text = "Confirm Password:";
            // 
            // Get_Comfirm_Password
            // 
            this.Get_Comfirm_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get_Comfirm_Password.Location = new System.Drawing.Point(376, 215);
            this.Get_Comfirm_Password.Name = "Get_Comfirm_Password";
            this.Get_Comfirm_Password.Size = new System.Drawing.Size(218, 29);
            this.Get_Comfirm_Password.TabIndex = 17;
            this.Get_Comfirm_Password.TextChanged += new System.EventHandler(this.Get_Comfirm_Password_TextChanged);
            // 
            // Get_Password
            // 
            this.Get_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get_Password.Location = new System.Drawing.Point(375, 134);
            this.Get_Password.Name = "Get_Password";
            this.Get_Password.Size = new System.Drawing.Size(218, 29);
            this.Get_Password.TabIndex = 16;
            this.Get_Password.TextChanged += new System.EventHandler(this.Get_Password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(393, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "New Password:";
            // 
            // No_Change
            // 
            this.No_Change.BackColor = System.Drawing.SystemColors.HotTrack;
            this.No_Change.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.No_Change.BorderColor = System.Drawing.Color.Gray;
            this.No_Change.BorderRadius = 20;
            this.No_Change.BorderSize = 0;
            this.No_Change.FlatAppearance.BorderSize = 0;
            this.No_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_Change.ForeColor = System.Drawing.Color.White;
            this.No_Change.Location = new System.Drawing.Point(484, 265);
            this.No_Change.Name = "No_Change";
            this.No_Change.Size = new System.Drawing.Size(132, 57);
            this.No_Change.TabIndex = 117;
            this.No_Change.Text = "No Change";
            this.No_Change.TextColor = System.Drawing.Color.White;
            this.No_Change.UseVisualStyleBackColor = false;
            this.No_Change.Click += new System.EventHandler(this.No_Change_Click);
            // 
            // Save_Change
            // 
            this.Save_Change.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Save_Change.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.Save_Change.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Save_Change.BorderRadius = 20;
            this.Save_Change.BorderSize = 0;
            this.Save_Change.FlatAppearance.BorderSize = 0;
            this.Save_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Change.ForeColor = System.Drawing.Color.White;
            this.Save_Change.Location = new System.Drawing.Point(346, 265);
            this.Save_Change.Name = "Save_Change";
            this.Save_Change.Size = new System.Drawing.Size(132, 57);
            this.Save_Change.TabIndex = 115;
            this.Save_Change.Text = "Save Change";
            this.Save_Change.TextColor = System.Drawing.Color.White;
            this.Save_Change.UseVisualStyleBackColor = false;
            this.Save_Change.Click += new System.EventHandler(this.Save_Change_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(2, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 216);
            this.panel1.TabIndex = 118;
            // 
            // Show_Password_Visible
            // 
            this.Show_Password_Visible.AutoSize = true;
            this.Show_Password_Visible.Location = new System.Drawing.Point(599, 146);
            this.Show_Password_Visible.Name = "Show_Password_Visible";
            this.Show_Password_Visible.Size = new System.Drawing.Size(102, 17);
            this.Show_Password_Visible.TabIndex = 119;
            this.Show_Password_Visible.Text = "Show Password";
            this.Show_Password_Visible.UseVisualStyleBackColor = true;
            this.Show_Password_Visible.CheckedChanged += new System.EventHandler(this.Show_Password_Visible_CheckedChanged);
            // 
            // Confirm_Password_Visible
            // 
            this.Confirm_Password_Visible.AutoSize = true;
            this.Confirm_Password_Visible.Location = new System.Drawing.Point(599, 225);
            this.Confirm_Password_Visible.Name = "Confirm_Password_Visible";
            this.Confirm_Password_Visible.Size = new System.Drawing.Size(102, 17);
            this.Confirm_Password_Visible.TabIndex = 120;
            this.Confirm_Password_Visible.Text = "Show Password";
            this.Confirm_Password_Visible.UseVisualStyleBackColor = true;
            this.Confirm_Password_Visible.CheckedChanged += new System.EventHandler(this.Confirm_Password_Visible_CheckedChanged);
            // 
            // Change_Password_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Confirm_Password_Visible);
            this.Controls.Add(this.Show_Password_Visible);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.No_Change);
            this.Controls.Add(this.Save_Change);
            this.Controls.Add(this.Comfirm_Password);
            this.Controls.Add(this.Get_Comfirm_Password);
            this.Controls.Add(this.Get_Password);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Change_Password_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Show_Password_Visible;
        private System.Windows.Forms.CheckBox Confirm_Password_Visible;
    }
}