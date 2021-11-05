
namespace TeacherAssistant
{
    partial class InstructorSelect
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
            this.Show_Semester_Name = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Show_Section = new System.Windows.Forms.ComboBox();
            this.Show_Intake = new System.Windows.Forms.ComboBox();
            this.Show_Department = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Show_Instructor_ID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Show_Instructor_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Submit_Info = new System.Windows.Forms.Button();
            this.Show_Select_Course = new System.Windows.Forms.ComboBox();
            this.aa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Show_Semester_Name
            // 
            this.Show_Semester_Name.FormattingEnabled = true;
            this.Show_Semester_Name.Location = new System.Drawing.Point(11, 448);
            this.Show_Semester_Name.Name = "Show_Semester_Name";
            this.Show_Semester_Name.Size = new System.Drawing.Size(281, 21);
            this.Show_Semester_Name.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(66, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 25);
            this.label10.TabIndex = 38;
            this.label10.Text = "Select Semester";
            // 
            // Show_Section
            // 
            this.Show_Section.FormattingEnabled = true;
            this.Show_Section.Location = new System.Drawing.Point(-6, 263);
            this.Show_Section.Name = "Show_Section";
            this.Show_Section.Size = new System.Drawing.Size(281, 21);
            this.Show_Section.TabIndex = 53;
            // 
            // Show_Intake
            // 
            this.Show_Intake.FormattingEnabled = true;
            this.Show_Intake.Location = new System.Drawing.Point(10, 97);
            this.Show_Intake.Name = "Show_Intake";
            this.Show_Intake.Size = new System.Drawing.Size(281, 21);
            this.Show_Intake.TabIndex = 52;
            this.Show_Intake.SelectedIndexChanged += new System.EventHandler(this.Show_Intake_SelectedIndexChanged);
            // 
            // Show_Department
            // 
            this.Show_Department.FormattingEnabled = true;
            this.Show_Department.Location = new System.Drawing.Point(16, 46);
            this.Show_Department.Name = "Show_Department";
            this.Show_Department.Size = new System.Drawing.Size(281, 21);
            this.Show_Department.TabIndex = 51;
            this.Show_Department.SelectedIndexChanged += new System.EventHandler(this.Show_Department_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 50;
            this.label7.Text = "Select Intake";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Select Section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Select Department  Name";
            // 
            // Show_Instructor_ID
            // 
            this.Show_Instructor_ID.FormattingEnabled = true;
            this.Show_Instructor_ID.Location = new System.Drawing.Point(-4, 363);
            this.Show_Instructor_ID.Name = "Show_Instructor_ID";
            this.Show_Instructor_ID.Size = new System.Drawing.Size(281, 21);
            this.Show_Instructor_ID.TabIndex = 57;
            this.Show_Instructor_ID.SelectedIndexChanged += new System.EventHandler(this.Show_Instructor_ID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "Select Instructor ID";
            // 
            // Show_Instructor_Name
            // 
            this.Show_Instructor_Name.Location = new System.Drawing.Point(323, 263);
            this.Show_Instructor_Name.Name = "Show_Instructor_Name";
            this.Show_Instructor_Name.Size = new System.Drawing.Size(221, 20);
            this.Show_Instructor_Name.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 59;
            this.label3.Text = "Instructor Name";
            // 
            // Submit_Info
            // 
            this.Submit_Info.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Submit_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Submit_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_Info.Location = new System.Drawing.Point(100, 502);
            this.Submit_Info.Name = "Submit_Info";
            this.Submit_Info.Size = new System.Drawing.Size(150, 37);
            this.Submit_Info.TabIndex = 60;
            this.Submit_Info.Text = "Submit";
            this.Submit_Info.UseVisualStyleBackColor = false;
            this.Submit_Info.Click += new System.EventHandler(this.Submit_Info_Click);
            // 
            // Show_Select_Course
            // 
            this.Show_Select_Course.FormattingEnabled = true;
            this.Show_Select_Course.Location = new System.Drawing.Point(21, 174);
            this.Show_Select_Course.Name = "Show_Select_Course";
            this.Show_Select_Course.Size = new System.Drawing.Size(281, 21);
            this.Show_Select_Course.TabIndex = 62;
            // 
            // aa
            // 
            this.aa.AutoSize = true;
            this.aa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aa.Location = new System.Drawing.Point(76, 146);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(160, 25);
            this.aa.TabIndex = 61;
            this.aa.Text = "Select Course";
            // 
            // InstructorSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 597);
            this.Controls.Add(this.Show_Select_Course);
            this.Controls.Add(this.aa);
            this.Controls.Add(this.Submit_Info);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Show_Instructor_Name);
            this.Controls.Add(this.Show_Instructor_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Show_Section);
            this.Controls.Add(this.Show_Intake);
            this.Controls.Add(this.Show_Department);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Show_Semester_Name);
            this.Controls.Add(this.label10);
            this.Name = "InstructorSelect";
            this.Text = "Instructor Select";
            this.Load += new System.EventHandler(this.InstructorSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Show_Semester_Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Show_Section;
        private System.Windows.Forms.ComboBox Show_Intake;
        private System.Windows.Forms.ComboBox Show_Department;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Show_Instructor_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Show_Instructor_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Submit_Info;
        private System.Windows.Forms.ComboBox Show_Select_Course;
        private System.Windows.Forms.Label aa;
    }
}