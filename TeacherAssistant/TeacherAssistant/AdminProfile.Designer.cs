
namespace TeacherAssistant
{
    partial class Admin_Profile
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
            this.AddDept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddDept
            // 
            this.AddDept.Location = new System.Drawing.Point(243, 32);
            this.AddDept.Name = "AddDept";
            this.AddDept.Size = new System.Drawing.Size(203, 73);
            this.AddDept.TabIndex = 0;
            this.AddDept.Text = "Add Department Name";
            this.AddDept.UseVisualStyleBackColor = true;
            this.AddDept.Click += new System.EventHandler(this.AddDept_Click);
            // 
            // Admin_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddDept);
            this.Name = "Admin_Profile";
            this.Text = "Admin Profile";
            this.Load += new System.EventHandler(this.Admin_Profile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddDept;
    }
}