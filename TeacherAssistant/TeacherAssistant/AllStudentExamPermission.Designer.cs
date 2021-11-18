
namespace TeacherAssistant
{
    partial class AllStudentExamPermission
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
            this.Show_Students_Atd_Per = new System.Windows.Forms.DataGridView();
            this.Login = new TeacherAssistant.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.Show_Students_Atd_Per)).BeginInit();
            this.SuspendLayout();
            // 
            // Show_Students_Atd_Per
            // 
            this.Show_Students_Atd_Per.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Show_Students_Atd_Per.Location = new System.Drawing.Point(106, 35);
            this.Show_Students_Atd_Per.Name = "Show_Students_Atd_Per";
            this.Show_Students_Atd_Per.Size = new System.Drawing.Size(620, 479);
            this.Show_Students_Atd_Per.TabIndex = 85;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Login.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Login.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Login.BorderRadius = 20;
            this.Login.BorderSize = 0;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(785, 541);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(150, 40);
            this.Login.TabIndex = 111;
            this.Login.Text = "< Back";
            this.Login.TextColor = System.Drawing.Color.White;
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Back_Click);
            // 
            // AllStudentExamPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(947, 593);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Show_Students_Atd_Per);
            this.Name = "AllStudentExamPermission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Exam Permission";
            this.Load += new System.EventHandler(this.AllStudentExamPermission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Show_Students_Atd_Per)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Show_Students_Atd_Per;
        private CustomButton Login;
    }
}