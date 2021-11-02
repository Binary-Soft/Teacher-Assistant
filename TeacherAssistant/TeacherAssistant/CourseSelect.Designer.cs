
namespace TeacherAssistant
{
    partial class CourseSelect
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
            this.label10 = new System.Windows.Forms.Label();
            this.Select_Course = new System.Windows.Forms.ComboBox();
            this.Show_Intake = new System.Windows.Forms.ComboBox();
            this.Show_Department = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Subbit_Student_Info = new System.Windows.Forms.Button();
            this.Show_Semester = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Show_Years = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(66, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Select Course";
            // 
            // Select_Course
            // 
            this.Select_Course.FormattingEnabled = true;
            this.Select_Course.Location = new System.Drawing.Point(19, 306);
            this.Select_Course.Name = "Select_Course";
            this.Select_Course.Size = new System.Drawing.Size(281, 21);
            this.Select_Course.TabIndex = 31;
            // 
            // Show_Intake
            // 
            this.Show_Intake.FormattingEnabled = true;
            this.Show_Intake.Location = new System.Drawing.Point(35, 110);
            this.Show_Intake.Name = "Show_Intake";
            this.Show_Intake.Size = new System.Drawing.Size(281, 21);
            this.Show_Intake.TabIndex = 37;
            this.Show_Intake.SelectedIndexChanged += new System.EventHandler(this.Show_Intake_SelectedIndexChanged);
            // 
            // Show_Department
            // 
            this.Show_Department.FormattingEnabled = true;
            this.Show_Department.Location = new System.Drawing.Point(41, 59);
            this.Show_Department.Name = "Show_Department";
            this.Show_Department.Size = new System.Drawing.Size(281, 21);
            this.Show_Department.TabIndex = 36;
            this.Show_Department.SelectedIndexChanged += new System.EventHandler(this.Show_Department_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(101, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Select Intake";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Select Department  Name";
            // 
            // Subbit_Student_Info
            // 
            this.Subbit_Student_Info.Location = new System.Drawing.Point(35, 348);
            this.Subbit_Student_Info.Name = "Subbit_Student_Info";
            this.Subbit_Student_Info.Size = new System.Drawing.Size(203, 73);
            this.Subbit_Student_Info.TabIndex = 39;
            this.Subbit_Student_Info.Text = "Submit";
            this.Subbit_Student_Info.UseVisualStyleBackColor = true;
            this.Subbit_Student_Info.Click += new System.EventHandler(this.Subbit_Student_Info_Click);
            // 
            // Show_Semester
            // 
            this.Show_Semester.FormattingEnabled = true;
            this.Show_Semester.Location = new System.Drawing.Point(19, 174);
            this.Show_Semester.Name = "Show_Semester";
            this.Show_Semester.Size = new System.Drawing.Size(281, 21);
            this.Show_Semester.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Select Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Enter Year";
            // 
            // Show_Years
            // 
            this.Show_Years.FormattingEnabled = true;
            this.Show_Years.Location = new System.Drawing.Point(19, 249);
            this.Show_Years.Name = "Show_Years";
            this.Show_Years.Size = new System.Drawing.Size(281, 21);
            this.Show_Years.TabIndex = 44;
            // 
            // CourseSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Show_Years);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Show_Semester);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Subbit_Student_Info);
            this.Controls.Add(this.Show_Intake);
            this.Controls.Add(this.Show_Department);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Select_Course);
            this.Controls.Add(this.label10);
            this.Name = "CourseSelect";
            this.Text = "Course Select";
            this.Load += new System.EventHandler(this.CourseSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Select_Course;
        private System.Windows.Forms.ComboBox Show_Intake;
        private System.Windows.Forms.ComboBox Show_Department;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Subbit_Student_Info;
        private System.Windows.Forms.ComboBox Show_Semester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Show_Years;
    }
}