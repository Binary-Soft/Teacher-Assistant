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
    public partial class CourseSelect : Form
    {
        public CourseSelect()
        {
            InitializeComponent();
        }

        private void CourseSelect_Load(object sender, EventArgs e)
        {
            Get_Department_Name("Show_Department");
            Get_Department_Name("Show_Semester");
            Get_Department_Name("Show_Years");
        }


        private void Get_Department_Name(string Function_Name)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();

            string query = string.Empty;

            if (Function_Name == "Show_Department")
            {
                query = "SELECT DISTINCT department.Dept_Name AS Department FROM dept_intake_section, department " +
                    "WHERE dept_intake_section.Dept_ID=department.ID";
            }
            else if (Function_Name == "Show_Semester")
            {
                query = "SELECT semesters.Semester As Semester FROM semesters";
            }
            else if (Function_Name == "Show_Years")
            {
                query = "SELECT years.Year AS Years FROM years";
            }

            try
            {
                MySqlCommand command = new MySqlCommand(query, connect);
                MySqlDataReader dataReader = command.ExecuteReader();

                if (Function_Name == "Show_Department")
                {
                    while (dataReader.Read())
                    {
                        Show_Department.Items.Add(dataReader.GetString("Department"));
                    }
                }
                else if (Function_Name == "Show_Semester")
                {
                    while (dataReader.Read())
                    {
                        Show_Semester.Items.Add(dataReader.GetString("Semester"));
                    }
                }
                else if (Function_Name == "Show_Years")
                {
                    while (dataReader.Read())
                    {
                        Show_Years.Items.Add(dataReader.GetString("Years"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            connect.Close();
        }



        private void Show_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dept_name = Show_Department.Text.Trim();

            if (is_valid(dept_name) == true)
            {
                Show_Intake.Items.Clear();
                //   Show_Section.Items.Clear();
                Select_Course.Items.Clear();
                string query = "SELECT DISTINCT dept_intake_section.Intake AS Intake FROM dept_intake_section, department " +
                    "WHERE dept_intake_section.Dept_ID=department.ID and department.Dept_Name='" + dept_name + "'";


                Display_Intake_Section(query, "Show_Intake");
            }
        }

        private bool is_valid(string dept_name)
        {
            if (dept_name == string.Empty)
            {
                MessageBox.Show("Please Select Department Name.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void Display_Intake_Section(string query, string function_name)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(query, connect);
                MySqlDataReader dataReader = command.ExecuteReader();

                if (function_name == "Show_Intake")
                {
                    while (dataReader.Read())
                    {
                        Show_Intake.Items.Add(dataReader.GetString("Intake"));
                    }
                }
                else if (function_name == "Show_Section")
                {
                    while (dataReader.Read())
                    {
                        //  Show_Section.Items.Add(dataReader.GetString("Section"));
                    }
                }
                else if (function_name == "Show_Course")
                {
                    while (dataReader.Read())
                    {
                        Select_Course.Items.Add(dataReader.GetString("Course_ID"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            connect.Close();
        }

        private void Show_Intake_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dept_name = Show_Department.Text.Trim();
            string intake = Show_Intake.Text.Trim();

            if (is_valid(dept_name, intake) == true)
            {
                string query = "SELECT dept_intake_section.Section AS Section FROM department, dept_intake, dept_intake_section " +
                    "WHERE department.ID=dept_intake.Dept_ID AND department.ID=dept_intake_section.Dept_ID AND " +
                    "dept_intake.Intake=dept_intake_section.Intake AND department.Dept_Name='" + dept_name + "' AND dept_intake.Intake='" + intake + "'";

                // Display_Intake_Section(query, "Show_Section");
                Show_Course(dept_name);
            }
        }

        private void Show_Course(string dept_name)
        {
            string query = "SELECT courses.Course_ID, courses.Course_Title FROM department, courses " +
                "WHERE department.ID=courses.Dept_ID AND department.Dept_Name='" + dept_name + "'";

            Display_Intake_Section(query, "Show_Course");
        }

        private bool is_valid(string dept_name, string intake)
        {
            if (is_valid(dept_name) == false)
            {
                return false;
            }
            else if (intake == string.Empty)
            {
                MessageBox.Show("Please Select Intake.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void Subbit_Student_Info_Click(object sender, EventArgs e)
        {
            string dept_name = Show_Department.Text.Trim();
            string intake = Show_Intake.Text.Trim();
            string semester = Show_Semester.Text.Trim();
            string year = Show_Years.Text.Trim();
            string course_ID = Select_Course.Text.Trim();

            if (is_valid(dept_name, intake, semester, year, course_ID) == true)
            {
                AddNewStudent obj = new AddNewStudent();  //  //  =====>> From AddNewStudent.cs file   <<=====

                string dept_Id = obj.Get_Department_ID("SELECT department.ID As Dept_ID FROM department WHERE department.Dept_Name='" + dept_name + "'");
                string query = "INSERT INTO course_prefer (`Dept_ID`, `Intake`, `Course_ID`, `Year`, `Semester`, `Is_Complete`) " +
                    "VALUES ('" + dept_Id + "', '" + intake + "', '" + course_ID + "', '" + year + "', '" + semester + "', '0');";


                if (obj.Student_Info_Save_To_Database(query) == true)  // <<==== this function exist AddNewStudent.cs file 
                {
                    MessageBox.Show(course_ID + " Added Successfully.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course: " + course_ID + " Save Failed. Please Try Again.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private bool is_valid(string dept_name, string intake, string semester, string year, string course)
        {
            if(is_valid(dept_name, intake) == false)
            {
                return false;
            }
            else if(semester == string.Empty)
            {
                MessageBox.Show("Please Select Semester.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(year == string.Empty)
            {
                MessageBox.Show("Please Select Year.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(course == string.Empty)
            {
                MessageBox.Show("Please Select Course ID.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        
    }
}
