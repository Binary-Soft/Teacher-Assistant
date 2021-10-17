
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
            this.Intake = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDeptName)).BeginInit();
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
            this.AddNewDepart.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditDepartment
            // 
            this.EditDepartment.Location = new System.Drawing.Point(472, 40);
            this.EditDepartment.Name = "EditDepartment";
            this.EditDepartment.Size = new System.Drawing.Size(126, 23);
            this.EditDepartment.TabIndex = 4;
            this.EditDepartment.Text = "Edit Department";
            this.EditDepartment.UseVisualStyleBackColor = true;
            this.EditDepartment.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ShowDeptName
            // 
            this.ShowDeptName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShowDeptName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDeptName.Location = new System.Drawing.Point(72, 84);
            this.ShowDeptName.Name = "ShowDeptName";
            this.ShowDeptName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowDeptName.Size = new System.Drawing.Size(276, 262);
            this.ShowDeptName.TabIndex = 5;
            this.ShowDeptName.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddDeptName
            // 
            this.AddDeptName.Location = new System.Drawing.Point(75, 58);
            this.AddDeptName.Name = "AddDeptName";
            this.AddDeptName.Size = new System.Drawing.Size(237, 20);
            this.AddDeptName.TabIndex = 6;
            // 
            // Intake
            // 
            this.Intake.FormattingEnabled = true;
            this.Intake.Location = new System.Drawing.Point(75, 425);
            this.Intake.Name = "Intake";
            this.Intake.Size = new System.Drawing.Size(121, 21);
            this.Intake.TabIndex = 7;
            this.Intake.SelectedIndexChanged += new System.EventHandler(this.Intake_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Intake";
            // 
            // ManageDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 658);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Intake);
            this.Controls.Add(this.AddDeptName);
            this.Controls.Add(this.ShowDeptName);
            this.Controls.Add(this.EditDepartment);
            this.Controls.Add(this.AddNewDepart);
            this.Controls.Add(this.label1);
            this.Name = "ManageDept";
            this.Text = "Manage Department";
            this.Load += new System.EventHandler(this.ManageDept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowDeptName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNewDepart;
        private System.Windows.Forms.Button EditDepartment;
        private System.Windows.Forms.DataGridView ShowDeptName;
        private System.Windows.Forms.TextBox AddDeptName;
        private System.Windows.Forms.ComboBox Intake;
        private System.Windows.Forms.Label label2;
    }
}