
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
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Show_Student_Marks)).BeginInit();
            this.SuspendLayout();
            // 
            // Show_Student_Name
            // 
            this.Show_Student_Name.Location = new System.Drawing.Point(7, 45);
            this.Show_Student_Name.Name = "Show_Student_Name";
            this.Show_Student_Name.Size = new System.Drawing.Size(230, 20);
            this.Show_Student_Name.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 25);
            this.label10.TabIndex = 88;
            this.label10.Text = "Student Name";
            // 
            // Show_Student_ID
            // 
            this.Show_Student_ID.Location = new System.Drawing.Point(10, 101);
            this.Show_Student_ID.Name = "Show_Student_ID";
            this.Show_Student_ID.Size = new System.Drawing.Size(230, 20);
            this.Show_Student_ID.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 90;
            this.label1.Text = "Student ID";
            // 
            // Show_Course_ID
            // 
            this.Show_Course_ID.Location = new System.Drawing.Point(10, 157);
            this.Show_Course_ID.Name = "Show_Course_ID";
            this.Show_Course_ID.Size = new System.Drawing.Size(230, 20);
            this.Show_Course_ID.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 92;
            this.label2.Text = "Course ID";
            // 
            // Show_Student_Marks
            // 
            this.Show_Student_Marks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Show_Student_Marks.Location = new System.Drawing.Point(328, 17);
            this.Show_Student_Marks.Name = "Show_Student_Marks";
            this.Show_Student_Marks.Size = new System.Drawing.Size(754, 479);
            this.Show_Student_Marks.TabIndex = 94;
            // 
            // Show_Marks_Type
            // 
            this.Show_Marks_Type.FormattingEnabled = true;
            this.Show_Marks_Type.Location = new System.Drawing.Point(10, 229);
            this.Show_Marks_Type.Name = "Show_Marks_Type";
            this.Show_Marks_Type.Size = new System.Drawing.Size(227, 21);
            this.Show_Marks_Type.TabIndex = 95;
            this.Show_Marks_Type.SelectedIndexChanged += new System.EventHandler(this.Show_Marks_Type_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 96;
            this.label3.Text = "Select Marks Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 281);
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
            this.Submit_Marks.Location = new System.Drawing.Point(12, 348);
            this.Submit_Marks.Name = "Submit_Marks";
            this.Submit_Marks.Size = new System.Drawing.Size(120, 33);
            this.Submit_Marks.TabIndex = 99;
            this.Submit_Marks.Text = "Submit";
            this.Submit_Marks.UseVisualStyleBackColor = false;
            this.Submit_Marks.Click += new System.EventHandler(this.Submit_Marks_Click);
            // 
            // Get_Marks
            // 
            this.Get_Marks.Location = new System.Drawing.Point(10, 309);
            this.Get_Marks.Name = "Get_Marks";
            this.Get_Marks.Size = new System.Drawing.Size(230, 20);
            this.Get_Marks.TabIndex = 100;
            // 
            // Update_Marks
            // 
            this.Update_Marks.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Update_Marks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Update_Marks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Marks.Location = new System.Drawing.Point(154, 347);
            this.Update_Marks.Name = "Update_Marks";
            this.Update_Marks.Size = new System.Drawing.Size(149, 34);
            this.Update_Marks.TabIndex = 101;
            this.Update_Marks.Text = "Update Marks";
            this.Update_Marks.UseVisualStyleBackColor = false;
            this.Update_Marks.Click += new System.EventHandler(this.Update_Marks_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(12, 463);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(120, 33);
            this.Back.TabIndex = 102;
            this.Back.Text = "< Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddStudentMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 567);
            this.Controls.Add(this.Back);
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
            this.Name = "AddStudentMarks";
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
        private System.Windows.Forms.Button Back;
    }
}