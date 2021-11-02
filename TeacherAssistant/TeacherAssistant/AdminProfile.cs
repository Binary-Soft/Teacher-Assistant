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
            ManageDept obj = new ManageDept();

            obj.ShowDialog();
        }

        private void Add_New_Student_Click(object sender, EventArgs e)
        {
            AddNewStudent obj = new AddNewStudent();

            obj.ShowDialog();
        }

        private void Instructor_Registration_Permission_Click(object sender, EventArgs e)
        {
            InstructorRegistration obj = new InstructorRegistration();

            obj.ShowDialog();
        }

        private void Add_Course_Click(object sender, EventArgs e)
        {
            AddCourses obj = new AddCourses();

            obj.ShowDialog();
        }

        private void Course_Select_Click(object sender, EventArgs e)
        {
            CourseSelect obj = new CourseSelect();

            obj.ShowDialog();
        }

        private void Instructor_Select_Click(object sender, EventArgs e)
        {
            InstructorSelect obj = new InstructorSelect();

            obj.ShowDialog();
        }
    }
}
