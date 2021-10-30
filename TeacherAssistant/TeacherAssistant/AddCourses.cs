using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TeacherAssistant
{
    public partial class AddCourses : Form
    {
        public AddCourses()
        {
            InitializeComponent();
        }


        private void AddCourses_Load(object sender, EventArgs e)
        {
            Get_Department("SELECT DISTINCT department.Dept_Name AS Department FROM department");
        }

        private void Get_Department(string query)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();


            try
            {
                MySqlCommand command = new MySqlCommand(query, connect);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Show_Department.Items.Add(dataReader.GetString("Department"));
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connect.Close();
        }

        private void Submit_New_Course_Click(object sender, EventArgs e)
        {
            string dept_name = Show_Department.Text.Trim();
            string course_id = Get_Course_ID.Text.Trim();
            string course_title = Get_Course_Title.Text.Trim();
            string semester_no = Semester_Number.Text.Trim();

            if (Is_Valid(dept_name, course_id, course_title, semester_no) == true)
            {
                AddNewStudent obj = new AddNewStudent();  //  //  =====>> From AddNewStudent.cs file   <<=====

                string query1 = "SELECT department.ID As Dept_ID FROM department WHERE department.Dept_Name='" + dept_name + "'";
                string Dept_ID = obj.Get_Department_ID(query1);   // <<==== this function exist AddNewStudent.cs file

                string query2 = "INSERT INTO courses (`Course_ID`, `Course_Title`, `Semester_No`, `Dept_ID`) " +
                    "VALUES ('" + course_id + "', '" + course_title + "', '" + semester_no + "', '" + Dept_ID + "')";

                if (obj.Student_Info_Save_To_Database(query2) == true)    // <<==== this function exist AddNewStudent.cs file
                {
                    MessageBox.Show("Course: "+ course_id +" Save Successfully.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset_All();
                }
                else
                {
                    MessageBox.Show("Information Save Failed. Please Try Again.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Reset_All()
        {
            Get_Course_ID.Clear();
            Get_Course_Title.Clear();
        }

        private bool Is_Valid(string dept_name, string course_id, string course_title, string semester_no)
        {
            if (dept_name == string.Empty)
            {
                MessageBox.Show("Please Select Department Name.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (course_id == string.Empty)
            {
                MessageBox.Show("Please Fillup Course ID.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Get_Course_ID.Focus();
                return false;
            }
            else if (course_title == string.Empty)
            {
                MessageBox.Show("Please Fillup Course Title.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Get_Course_Title.Focus();
                return false;
            }
            else if(semester_no == string.Empty)
            {

                MessageBox.Show("Please Fillup Semester Number", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Semester_Number.Focus();
                return false;
            }

            return true;
        }

    }
}
