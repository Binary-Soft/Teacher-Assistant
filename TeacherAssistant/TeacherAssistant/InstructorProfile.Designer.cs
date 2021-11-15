
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
            this.label2 = new System.Windows.Forms.Label();
            this.aa = new System.Windows.Forms.Label();
            this.Show_Section = new System.Windows.Forms.ComboBox();
            this.Show_Intake = new System.Windows.Forms.ComboBox();
            this.Show_Department = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Show_Select_Course = new System.Windows.Forms.ComboBox();
            this.Add_Attendance = new System.Windows.Forms.Button();
            this.Add_Marks = new System.Windows.Forms.Button();
            this.Show_Student = new System.Windows.Forms.DataGridView();
            this.Show_Semester_Name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.Show_Student_Details = new System.Windows.Forms.Button();
            this.Exam_Permission = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Show_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // Temp_Instructor_Email
            // 
            this.Temp_Instructor_Email.Location = new System.Drawing.Point(12, 60);
            this.Temp_Instructor_Email.Name = "Temp_Instructor_Email";
            this.Temp_Instructor_Email.Size = new System.Drawing.Size(160, 20);
            this.Temp_Instructor_Email.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Instructor Name";
            // 
            // aa
            // 
            this.aa.AutoSize = true;
            this.aa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aa.Location = new System.Drawing.Point(87, 339);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(160, 25);
            this.aa.TabIndex = 75;
            this.aa.Text = "Select Course";
            // 
            // Show_Section
            // 
            this.Show_Section.FormattingEnabled = true;
            this.Show_Section.Location = new System.Drawing.Point(31, 290);
            this.Show_Section.Name = "Show_Section";
            this.Show_Section.Size = new System.Drawing.Size(281, 21);
            this.Show_Section.TabIndex = 69;
            this.Show_Section.SelectedIndexChanged += new System.EventHandler(this.Show_Section_SelectedIndexChanged);
            // 
            // Show_Intake
            // 
            this.Show_Intake.FormattingEnabled = true;
            this.Show_Intake.Location = new System.Drawing.Point(46, 212);
            this.Show_Intake.Name = "Show_Intake";
            this.Show_Intake.Size = new System.Drawing.Size(281, 21);
            this.Show_Intake.TabIndex = 68;
            this.Show_Intake.SelectedIndexChanged += new System.EventHandler(this.Show_Intake_SelectedIndexChanged);
            // 
            // Show_Department
            // 
            this.Show_Department.FormattingEnabled = true;
            this.Show_Department.Location = new System.Drawing.Point(52, 161);
            this.Show_Department.Name = "Show_Department";
            this.Show_Department.Size = new System.Drawing.Size(281, 21);
            this.Show_Department.TabIndex = 67;
            this.Show_Department.SelectedIndexChanged += new System.EventHandler(this.Show_Department_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 66;
            this.label7.Text = "Select Intake";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 65;
            this.label6.Text = "Select Section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 25);
            this.label4.TabIndex = 77;
            this.label4.Text = "Select Department  Name";
            // 
            // Show_Select_Course
            // 
            this.Show_Select_Course.FormattingEnabled = true;
            this.Show_Select_Course.Location = new System.Drawing.Point(31, 367);
            this.Show_Select_Course.Name = "Show_Select_Course";
            this.Show_Select_Course.Size = new System.Drawing.Size(281, 21);
            this.Show_Select_Course.TabIndex = 79;
            this.Show_Select_Course.SelectedIndexChanged += new System.EventHandler(this.Show_Select_Course_SelectedIndexChanged);
            // 
            // Add_Attendance
            // 
            this.Add_Attendance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Add_Attendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add_Attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Attendance.Location = new System.Drawing.Point(510, 551);
            this.Add_Attendance.Name = "Add_Attendance";
            this.Add_Attendance.Size = new System.Drawing.Size(211, 37);
            this.Add_Attendance.TabIndex = 82;
            this.Add_Attendance.Text = "Add Attendance";
            this.Add_Attendance.UseVisualStyleBackColor = false;
            this.Add_Attendance.Click += new System.EventHandler(this.Add_Attendance_Click);
            // 
            // Add_Marks
            // 
            this.Add_Marks.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Add_Marks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add_Marks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Marks.Location = new System.Drawing.Point(748, 551);
            this.Add_Marks.Name = "Add_Marks";
            this.Add_Marks.Size = new System.Drawing.Size(150, 37);
            this.Add_Marks.TabIndex = 83;
            this.Add_Marks.Text = "Add Marks";
            this.Add_Marks.UseVisualStyleBackColor = false;
            this.Add_Marks.Click += new System.EventHandler(this.Add_Marks_Click);
            // 
            // Show_Student
            // 
            this.Show_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Show_Student.Location = new System.Drawing.Point(500, 60);
            this.Show_Student.Name = "Show_Student";
            this.Show_Student.Size = new System.Drawing.Size(620, 479);
            this.Show_Student.TabIndex = 84;
            this.Show_Student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Show_Student_CellClick);
            this.Show_Student.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.Show_Student_DefaultValuesNeeded);
            // 
            // Show_Semester_Name
            // 
            this.Show_Semester_Name.Location = new System.Drawing.Point(191, 62);
            this.Show_Semester_Name.Name = "Show_Semester_Name";
            this.Show_Semester_Name.Size = new System.Drawing.Size(230, 20);
            this.Show_Semester_Name.TabIndex = 87;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(237, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 25);
            this.label10.TabIndex = 86;
            this.label10.Text = "Semester";
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(996, 10);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(150, 37);
            this.Logout.TabIndex = 88;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Show_Student_Details
            // 
            this.Show_Student_Details.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Show_Student_Details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Show_Student_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_Student_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Student_Details.Location = new System.Drawing.Point(926, 551);
            this.Show_Student_Details.Name = "Show_Student_Details";
            this.Show_Student_Details.Size = new System.Drawing.Size(184, 37);
            this.Show_Student_Details.TabIndex = 89;
            this.Show_Student_Details.Text = "Student Details";
            this.Show_Student_Details.UseVisualStyleBackColor = false;
            this.Show_Student_Details.Click += new System.EventHandler(this.Show_Student_Details_Click);
            // 
            // Exam_Permission
            // 
            this.Exam_Permission.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Exam_Permission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exam_Permission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exam_Permission.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exam_Permission.Location = new System.Drawing.Point(666, 608);
            this.Exam_Permission.Name = "Exam_Permission";
            this.Exam_Permission.Size = new System.Drawing.Size(211, 37);
            this.Exam_Permission.TabIndex = 90;
            this.Exam_Permission.Text = "Exam Permission";
            this.Exam_Permission.UseVisualStyleBackColor = false;
            this.Exam_Permission.Click += new System.EventHandler(this.Exam_Permission_Click);
            // 
            // InstructorProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 671);
            this.Controls.Add(this.Exam_Permission);
            this.Controls.Add(this.Show_Student_Details);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Show_Semester_Name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Show_Student);
            this.Controls.Add(this.Add_Marks);
            this.Controls.Add(this.Add_Attendance);
            this.Controls.Add(this.Show_Select_Course);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aa);
            this.Controls.Add(this.Show_Section);
            this.Controls.Add(this.Show_Intake);
            this.Controls.Add(this.Show_Department);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Temp_Instructor_Email);
            this.Name = "InstructorProfile";
            this.Text = "Instructor Profile";
            this.Load += new System.EventHandler(this.InstructorProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Show_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Temp_Instructor_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label aa;
        private System.Windows.Forms.ComboBox Show_Section;
        private System.Windows.Forms.ComboBox Show_Intake;
        private System.Windows.Forms.ComboBox Show_Department;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Show_Select_Course;
        private System.Windows.Forms.Button Add_Attendance;
        private System.Windows.Forms.Button Add_Marks;
        private System.Windows.Forms.DataGridView Show_Student;
        private System.Windows.Forms.TextBox Show_Semester_Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Show_Student_Details;
        private System.Windows.Forms.Button Exam_Permission;
    }
}