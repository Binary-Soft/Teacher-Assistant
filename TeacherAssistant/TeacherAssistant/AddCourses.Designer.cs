
namespace TeacherAssistant
{
    partial class AddCourses
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Submit_New_Course = new System.Windows.Forms.Button();
            this.Show_Department = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Get_Course_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Get_Course_Title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Semester_Number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, -21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Select Department  Name";
            // 
            // Submit_New_Course
            // 
            this.Submit_New_Course.Location = new System.Drawing.Point(611, 356);
            this.Submit_New_Course.Name = "Submit_New_Course";
            this.Submit_New_Course.Size = new System.Drawing.Size(203, 73);
            this.Submit_New_Course.TabIndex = 50;
            this.Submit_New_Course.Text = "Submit";
            this.Submit_New_Course.UseVisualStyleBackColor = true;
            this.Submit_New_Course.Click += new System.EventHandler(this.Submit_New_Course_Click);
            // 
            // Show_Department
            // 
            this.Show_Department.FormattingEnabled = true;
            this.Show_Department.Location = new System.Drawing.Point(68, 104);
            this.Show_Department.Name = "Show_Department";
            this.Show_Department.Size = new System.Drawing.Size(281, 21);
            this.Show_Department.TabIndex = 46;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(196, 601);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(190, 20);
            this.Year.TabIndex = 43;
            // 
            // Get_Course_ID
            // 
            this.Get_Course_ID.Location = new System.Drawing.Point(108, 202);
            this.Get_Course_ID.Name = "Get_Course_ID";
            this.Get_Course_ID.Size = new System.Drawing.Size(190, 20);
            this.Get_Course_ID.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Course ID";
            // 
            // Get_Course_Title
            // 
            this.Get_Course_Title.Location = new System.Drawing.Point(108, 321);
            this.Get_Course_Title.Name = "Get_Course_Title";
            this.Get_Course_Title.Size = new System.Drawing.Size(190, 20);
            this.Get_Course_Title.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Course Title";
            // 
            // Semester_Number
            // 
            this.Semester_Number.Location = new System.Drawing.Point(395, 241);
            this.Semester_Number.Name = "Semester_Number";
            this.Semester_Number.Size = new System.Drawing.Size(190, 20);
            this.Semester_Number.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(404, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "Semester Number";
            // 
            // AddCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 601);
            this.Controls.Add(this.Semester_Number);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Get_Course_Title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Get_Course_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit_New_Course);
            this.Controls.Add(this.Show_Department);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "AddCourses";
            this.Text = "Add Courses";
            this.Load += new System.EventHandler(this.AddCourses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Submit_New_Course;
        private System.Windows.Forms.ComboBox Show_Department;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Get_Course_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Get_Course_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Semester_Number;
        private System.Windows.Forms.Label label5;
    }
}