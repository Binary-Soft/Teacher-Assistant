
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
            this.Back = new System.Windows.Forms.Button();
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
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(815, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(120, 33);
            this.Back.TabIndex = 105;
            this.Back.Text = "< Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AllStudentExamPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 593);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Show_Students_Atd_Per);
            this.Name = "AllStudentExamPermission";
            this.Text = "Student Exam Permission";
            this.Load += new System.EventHandler(this.AllStudentExamPermission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Show_Students_Atd_Per)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Show_Students_Atd_Per;
        private System.Windows.Forms.Button Back;
    }
}