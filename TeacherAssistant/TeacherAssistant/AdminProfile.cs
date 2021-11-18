using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherAssistant
{
    public partial class Admin_Profile : Form
    {
        public Admin_Profile()
        {
            InitializeComponent();
        }
        private void Admin_Profile_Load(object sender, EventArgs e)
        {

        }

        private void AddDept_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageDept obj = new ManageDept();

            obj.ShowDialog();
            this.Show();
        }

        private void Add_New_Student_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewStudent obj = new AddNewStudent();

            obj.ShowDialog();
            this.Show();
        }

        private void Instructor_Registration_Permission_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorRegistration obj = new InstructorRegistration();

            obj.ShowDialog();
            this.Show();
        }

        private void Add_Course_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCourses obj = new AddCourses();

            obj.ShowDialog();
            this.Show();
        }

        private void Course_Select_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseSelect obj = new CourseSelect();

            obj.ShowDialog();
            this.Show();
        }

        private void Instructor_Select_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorSelect obj = new InstructorSelect();

            obj.ShowDialog();
            this.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Logout?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
