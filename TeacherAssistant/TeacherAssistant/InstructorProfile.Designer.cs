
namespace TeacherAssistant
{
    partial class InstructorProfile
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
            this.Temp_Instructor_Email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Temp_Instructor_Email
            // 
            this.Temp_Instructor_Email.Location = new System.Drawing.Point(350, 215);
            this.Temp_Instructor_Email.Name = "Temp_Instructor_Email";
            this.Temp_Instructor_Email.Size = new System.Drawing.Size(100, 20);
            this.Temp_Instructor_Email.TabIndex = 1;
            // 
            // InstructorProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Temp_Instructor_Email);
            this.Name = "InstructorProfile";
            this.Text = "InstructorProfile";
            this.Load += new System.EventHandler(this.InstructorProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Temp_Instructor_Email;
    }
}