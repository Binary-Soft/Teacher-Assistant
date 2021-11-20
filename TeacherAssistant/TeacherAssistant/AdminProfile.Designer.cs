
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Profile));
            this.AddDept = new System.Windows.Forms.Button();
            this.Add_Course = new System.Windows.Forms.Button();
            this.Course_Select = new System.Windows.Forms.Button();
            this.Instructor_Select = new System.Windows.Forms.Button();
            this.Logout = new TeacherAssistant.CustomButton();
            this.Add_New_Student = new System.Windows.Forms.Button();
            this.Instructor_Registration_Permission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddDept
            // 
            this.AddDept.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDept.Location = new System.Drawing.Point(68, 94);
            this.AddDept.Name = "AddDept";
            this.AddDept.Size = new System.Drawing.Size(198, 158);
            this.AddDept.TabIndex = 0;
            this.AddDept.Text = "Add Department ";
            this.AddDept.UseVisualStyleBackColor = true;
            this.AddDept.Click += new System.EventHandler(this.AddDept_Click);
            // 
            // Add_Course
            // 
            this.Add_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Course.Location = new System.Drawing.Point(382, 309);
            this.Add_Course.Name = "Add_Course";
            this.Add_Course.Size = new System.Drawing.Size(198, 158);
            this.Add_Course.TabIndex = 3;
            this.Add_Course.Text = "Add New Course";
            this.Add_Course.UseVisualStyleBackColor = true;
            this.Add_Course.Click += new System.EventHandler(this.Add_Course_Click);
            // 
            // Course_Select
            // 
            this.Course_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_Select.Location = new System.Drawing.Point(691, 94);
            this.Course_Select.Name = "Course_Select";
            this.Course_Select.Size = new System.Drawing.Size(198, 158);
            this.Course_Select.TabIndex = 7;
            this.Course_Select.Text = "Course Prefer";
            this.Course_Select.UseVisualStyleBackColor = true;
            this.Course_Select.Click += new System.EventHandler(this.Course_Select_Click);
            // 
            // Instructor_Select
            // 
            this.Instructor_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructor_Select.Location = new System.Drawing.Point(691, 309);
            this.Instructor_Select.Name = "Instructor_Select";
            this.Instructor_Select.Size = new System.Drawing.Size(198, 158);
            this.Instructor_Select.TabIndex = 8;
            this.Instructor_Select.Text = "Instructor Selection";
            this.Instructor_Select.UseVisualStyleBackColor = true;
            this.Instructor_Select.Click += new System.EventHandler(this.Instructor_Select_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Logout.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.Logout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Logout.BorderRadius = 20;
            this.Logout.BorderSize = 0;
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(800, 535);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(150, 40);
            this.Logout.TabIndex = 113;
            this.Logout.Text = "Logout";
            this.Logout.TextColor = System.Drawing.Color.White;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Add_New_Student
            // 
            this.Add_New_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_Student.Location = new System.Drawing.Point(382, 94);
            this.Add_New_Student.Name = "Add_New_Student";
            this.Add_New_Student.Size = new System.Drawing.Size(198, 158);
            this.Add_New_Student.TabIndex = 1;
            this.Add_New_Student.Text = "Add Student";
            this.Add_New_Student.UseVisualStyleBackColor = true;
            this.Add_New_Student.Click += new System.EventHandler(this.Add_New_Student_Click);
            // 
            // Instructor_Registration_Permission
            // 
            this.Instructor_Registration_Permission.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructor_Registration_Permission.Location = new System.Drawing.Point(68, 309);
            this.Instructor_Registration_Permission.Name = "Instructor_Registration_Permission";
            this.Instructor_Registration_Permission.Size = new System.Drawing.Size(198, 158);
            this.Instructor_Registration_Permission.TabIndex = 2;
            this.Instructor_Registration_Permission.Text = "Instructor Registration Permission";
            this.Instructor_Registration_Permission.UseVisualStyleBackColor = true;
            this.Instructor_Registration_Permission.Click += new System.EventHandler(this.Instructor_Registration_Permission_Click);
            // 
            // Admin_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 587);
            this.Controls.Add(this.AddDept);
            this.Controls.Add(this.Instructor_Registration_Permission);
            this.Controls.Add(this.Add_New_Student);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Instructor_Select);
            this.Controls.Add(this.Course_Select);
            this.Controls.Add(this.Add_Course);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Profile";
            this.Load += new System.EventHandler(this.Admin_Profile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddDept;
        private System.Windows.Forms.Button Add_Course;
        private System.Windows.Forms.Button Course_Select;
        private System.Windows.Forms.Button Instructor_Select;
        private CustomButton Logout;
        private System.Windows.Forms.Button Add_New_Student;
        private System.Windows.Forms.Button Instructor_Registration_Permission;
    }
}