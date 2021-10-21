
namespace TeacherAssistant
{
    partial class ManageDept
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddNewDepart = new System.Windows.Forms.Button();
            this.EditDepartment = new System.Windows.Forms.Button();
            this.ShowDeptName = new System.Windows.Forms.DataGridView();
            this.AddDeptName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_New_Intake_Number_bottom = new System.Windows.Forms.Button();
            this.Reset_All = new System.Windows.Forms.Button();
            this.Intake = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDeptName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intake)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department Name";
            // 
            // AddNewDepart
            // 
            this.AddNewDepart.Location = new System.Drawing.Point(340, 40);
            this.AddNewDepart.Name = "AddNewDepart";
            this.AddNewDepart.Size = new System.Drawing.Size(126, 23);
            this.AddNewDepart.TabIndex = 3;
            this.AddNewDepart.Text = "Add New Department";
            this.AddNewDepart.UseVisualStyleBackColor = true;
            this.AddNewDepart.Click += new System.EventHandler(this.AddNewDepart_Click);
            // 
            // EditDepartment
            // 
            this.EditDepartment.Location = new System.Drawing.Point(472, 40);
            this.EditDepartment.Name = "EditDepartment";
            this.EditDepartment.Size = new System.Drawing.Size(126, 23);
            this.EditDepartment.TabIndex = 4;
            this.EditDepartment.Text = "Edit Department";
            this.EditDepartment.UseVisualStyleBackColor = true;
            this.EditDepartment.Click += new System.EventHandler(this.EditDepartment_Click);
            // 
            // ShowDeptName
            // 
            this.ShowDeptName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShowDeptName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDeptName.Location = new System.Drawing.Point(72, 84);
            this.ShowDeptName.Name = "ShowDeptName";
            this.ShowDeptName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowDeptName.Size = new System.Drawing.Size(276, 221);
            this.ShowDeptName.TabIndex = 5;
            this.ShowDeptName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowDeptName_CellClick);
            this.ShowDeptName.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.ShowDeptName_DefaultValuesNeeded);
            // 
            // AddDeptName
            // 
            this.AddDeptName.Location = new System.Drawing.Point(75, 58);
            this.AddDeptName.Name = "AddDeptName";
            this.AddDeptName.Size = new System.Drawing.Size(237, 20);
            this.AddDeptName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Intake No";
            // 
            // Add_New_Intake_Number_bottom
            // 
            this.Add_New_Intake_Number_bottom.Location = new System.Drawing.Point(206, 332);
            this.Add_New_Intake_Number_bottom.Name = "Add_New_Intake_Number_bottom";
            this.Add_New_Intake_Number_bottom.Size = new System.Drawing.Size(175, 23);
            this.Add_New_Intake_Number_bottom.TabIndex = 10;
            this.Add_New_Intake_Number_bottom.Text = "Add New Intake Number";
            this.Add_New_Intake_Number_bottom.UseVisualStyleBackColor = true;
            this.Add_New_Intake_Number_bottom.Click += new System.EventHandler(this.Add_New_Intake_Number_bottom_Click);
            // 
            // Reset_All
            // 
            this.Reset_All.Location = new System.Drawing.Point(604, 40);
            this.Reset_All.Name = "Reset_All";
            this.Reset_All.Size = new System.Drawing.Size(75, 23);
            this.Reset_All.TabIndex = 11;
            this.Reset_All.Text = "Reset";
            this.Reset_All.UseVisualStyleBackColor = true;
            this.Reset_All.Click += new System.EventHandler(this.Reset_All_Click);
            // 
            // Intake
            // 
            this.Intake.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Intake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Intake.Location = new System.Drawing.Point(75, 370);
            this.Intake.Name = "Intake";
            this.Intake.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Intake.Size = new System.Drawing.Size(276, 150);
            this.Intake.TabIndex = 14;
            this.Intake.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Intake_CellClick);
            // 
            // ManageDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 658);
            this.Controls.Add(this.Intake);
            this.Controls.Add(this.Reset_All);
            this.Controls.Add(this.Add_New_Intake_Number_bottom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddDeptName);
            this.Controls.Add(this.ShowDeptName);
            this.Controls.Add(this.EditDepartment);
            this.Controls.Add(this.AddNewDepart);
            this.Controls.Add(this.label1);
            this.Name = "ManageDept";
            this.Text = "Manage Department";
            this.Load += new System.EventHandler(this.ManageDept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowDeptName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNewDepart;
        private System.Windows.Forms.Button EditDepartment;
        private System.Windows.Forms.DataGridView ShowDeptName;
        private System.Windows.Forms.TextBox AddDeptName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_New_Intake_Number_bottom;
        private System.Windows.Forms.Button Reset_All;
        private System.Windows.Forms.DataGridView Intake;
    }
}