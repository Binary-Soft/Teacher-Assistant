
namespace TeacherAssistant
{
    partial class AddStudentMarks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentMarks));
            this.Show_Student_Name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Show_Student_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Show_Course_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Show_Student_Marks = new System.Windows.Forms.DataGridView();
            this.Show_Marks_Type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Submit_Marks = new System.Windows.Forms.Button();
            this.Get_Marks = new System.Windows.Forms.TextBox();
            this.Update_Marks = new System.Windows.Forms.Button();
            this.Login = new TeacherAssistant.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.Show_Student_Marks)).BeginInit();
            this.SuspendLayout();
            // 
            // Show_Student_Name
            // 
            this.Show_Student_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Student_Name.Location = new System.Drawing.Point(46, 83);
            this.Show_Student_Name.Multiline = true;
            this.Show_Student_Name.Name = "Show_Student_Name";
            this.Show_Student_Name.ReadOnly = true;
            this.Show_Student_Name.Size = new System.Drawing.Size(281, 35);
            this.Show_Student_Name.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(99, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 25);
            this.label10.TabIndex = 88;
            this.label10.Text = "Student Name";
            // 
            // Show_Student_ID
            // 
            this.Show_Student_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Student_ID.Location = new System.Drawing.Point(46, 164);
            this.Show_Student_ID.Multiline = true;
            this.Show_Student_ID.Name = "Show_Student_ID";
            this.Show_Student_ID.ReadOnly = true;
            this.Show_Student_ID.Size = new System.Drawing.Size(281, 35);
            this.Show_Student_ID.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 90;
            this.label1.Text = "Student ID";
            // 
            // Show_Course_ID
            // 
            this.Show_Course_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Course_ID.Location = new System.Drawing.Point(46, 239);
            this.Show_Course_ID.Multiline = true;
            this.Show_Course_ID.Name = "Show_Course_ID";
            this.Show_Course_ID.ReadOnly = true;
            this.Show_Course_ID.Size = new System.Drawing.Size(281, 35);
            this.Show_Course_ID.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 92;
            this.label2.Text = "Course ID";
            // 
            // Show_Student_Marks
            // 
            this.Show_Student_Marks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Show_Student_Marks.Location = new System.Drawing.Point(375, 26);
            this.Show_Student_Marks.Name = "Show_Student_Marks";
            this.Show_Student_Marks.Size = new System.Drawing.Size(754, 508);
            this.Show_Student_Marks.TabIndex = 94;
            // 
            // Show_Marks_Type
            // 
            this.Show_Marks_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Marks_Type.FormattingEnabled = true;
            this.Show_Marks_Type.Location = new System.Drawing.Point(46, 316);
            this.Show_Marks_Type.Name = "Show_Marks_Type";
            this.Show_Marks_Type.Size = new System.Drawing.Size(281, 32);
            this.Show_Marks_Type.TabIndex = 95;
            this.Show_Marks_Type.SelectedIndexChanged += new System.EventHandler(this.Show_Marks_Type_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 96;
            this.label3.Text = "Select Marks Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 97;
            this.label4.Text = "Enter Marks";
            // 
            // Submit_Marks
            // 
            this.Submit_Marks.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Submit_Marks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Submit_Marks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_Marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_Marks.Location = new System.Drawing.Point(46, 491);
            this.Submit_Marks.Name = "Submit_Marks";
            this.Submit_Marks.Size = new System.Drawing.Size(120, 33);
            this.Submit_Marks.TabIndex = 99;
            this.Submit_Marks.Text = "Submit";
            this.Submit_Marks.UseVisualStyleBackColor = false;
            this.Submit_Marks.Click += new System.EventHandler(this.Submit_Marks_Click);
            // 
            // Get_Marks
            // 
            this.Get_Marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get_Marks.Location = new System.Drawing.Point(46, 403);
            this.Get_Marks.Multiline = true;
            this.Get_Marks.Name = "Get_Marks";
            this.Get_Marks.Size = new System.Drawing.Size(281, 35);
            this.Get_Marks.TabIndex = 100;
            // 
            // Update_Marks
            // 
            this.Update_Marks.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Update_Marks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Update_Marks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Marks.Location = new System.Drawing.Point(188, 490);
            this.Update_Marks.Name = "Update_Marks";
            this.Update_Marks.Size = new System.Drawing.Size(149, 34);
            this.Update_Marks.TabIndex = 101;
            this.Update_Marks.Text = "Update Marks";
            this.Update_Marks.UseVisualStyleBackColor = false;
            this.Update_Marks.Click += new System.EventHandler(this.Update_Marks_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Login.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.Login.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Login.BorderRadius = 20;
            this.Login.BorderSize = 0;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(990, 570);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(150, 40);
            this.Login.TabIndex = 110;
            this.Login.Text = "< Back";
            this.Login.TextColor = System.Drawing.Color.White;
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddStudentMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1152, 622);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Update_Marks);
            this.Controls.Add(this.Get_Marks);
            this.Controls.Add(this.Submit_Marks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Show_Marks_Type);
            this.Controls.Add(this.Show_Student_Marks);
            this.Controls.Add(this.Show_Course_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Show_Student_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Show_Student_Name);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStudentMarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student Marks";
            this.Load += new System.EventHandler(this.AddStudentMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Show_Student_Marks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Show_Student_Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Show_Student_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Show_Course_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Show_Student_Marks;
        private System.Windows.Forms.ComboBox Show_Marks_Type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Submit_Marks;
        private System.Windows.Forms.TextBox Get_Marks;
        private System.Windows.Forms.Button Update_Marks;
        private CustomButton Login;
    }
}