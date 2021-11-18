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
    public partial class InstructorProfile : Form
    {
        string ins_email = LoginForm.INSTRUCTOR_EMAIL;
        string ins_id = string.Empty;
        private string Total_Class = string.Empty;

        public InstructorProfile()
        {
            InitializeComponent();
        }

        private void InstructorProfile_Load(object sender, EventArgs e)
        {
            InstructorSelect obj = new InstructorSelect();

            Temp_Instructor_Email.Text = Get_Instructor_Name(ins_email);
            Show_Date.Text = obj.Get_Current_Time(); // Get Current Time (Year-Month-Date)

            string query = "SELECT instructor.Ins_ID AS Instructor_ID FROM instructor WHERE instructor.Email='"+ ins_email +"'";
            ins_id = Get_Instructor_ID(query);


            if(ins_id != string.Empty)
            {
                query = "SELECT DISTINCT department.Dept_Name AS Department FROM department, ins_selection " +
                "WHERE department.ID=ins_selection.Dept_ID AND ins_selection.Ins_ID='" + ins_id +"'";

                Get_Department_Name(query, "Show_Department");
                Display_Semester();

            }
        }

        private string Get_Instructor_Name(string inst_email)
        {
            string query = "SELECT instructor.Name AS Instructor_ID FROM instructor WHERE instructor.Email='"+ inst_email + "';";
            return Get_Instructor_ID(query);
        }

        private void Display_Semester()
        {
            InstructorSelect obj = new InstructorSelect();
            string year_month_Date = obj.Get_Current_Time();   // Get Current Time (Year-Month-Date)

            string query = "SELECT DISTINCT ins_selection.Semester AS Semester from ins_selection , instructor " +
                    "WHERE instructor.Ins_ID=ins_selection.Ins_ID AND instructor.Ins_ID='" + ins_id + "' AND ins_selection.Starting_Time<='" + year_month_Date + "' AND" +
                    " ins_selection.Ending_Time>='" + year_month_Date + "'";

            Get_Department_Name(query, "Show_Semester_Name");
        }

        public string Get_Instructor_ID(string query)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(query, connect);
                MySqlDataReader dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                }
                string ins_id = dataReader.GetString("Instructor_ID");
                connect.Close();
                return ins_id;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            connect.Close();
            return string.Empty;
        }


        private void Get_Department_Name(string query, string Function_Name)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();


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
                else if (Function_Name == "Show_Intake")
                {
                    while (dataReader.Read())
                    {
                        Show_Intake.Items.Add(dataReader.GetString("Intake"));
                    }
                }
                else if (Function_Name == "Show_Section")
                {
                    while (dataReader.Read())
                    {
                        Show_Section.Items.Add(dataReader.GetString("Section"));
                    }
                }
                else if (Function_Name == "Show_Select_Course")
                {
                    while (dataReader.Read())
                    {
                        Show_Select_Course.Items.Add(dataReader.GetString("Course"));
                    }
                }
                else if (Function_Name == "Show_Semester_Name")
                {
                    while (dataReader.Read())
                    {
                    }
                    Show_Semester_Name.Text = dataReader.GetString("Semester");

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
            string ins_email = Temp_Instructor_Email.Text.Trim();
            string ins_dept_name = Show_Department.Text.Trim();

            InstructorSelect obj = new InstructorSelect();

            if(obj.is_valid(ins_dept_name) == true)
            {
                
                string query = "SELECT DISTINCT ins_selection.Intake AS Intake FROM department,ins_selection " +
                    "WHERE department.ID=ins_selection.Dept_ID AND ins_selection.Ins_ID='" + ins_id + "' AND department.Dept_Name='" + ins_dept_name + "'" +
                    "ORDER BY ins_selection.Intake";

                Show_Intake.Items.Clear();
                Show_Section.Items.Clear();
                Show_Select_Course.Items.Clear();
                Get_Department_Name(query, "Show_Intake");
            }
            
        }

        private void Show_Intake_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ins_dept_name = Show_Department.Text.Trim();
            string intake = Show_Intake.Text.Trim();

            InstructorSelect obj = new InstructorSelect();

            if(obj.is_valid(ins_dept_name, intake) == true)
            {
                string query = "SELECT DISTINCT ins_selection.Section AS Section FROM instructor, ins_selection " +
                    "WHERE instructor.Ins_ID=ins_selection.Ins_ID AND instructor.Ins_ID='" + ins_id + "' AND ins_selection.Intake='" + intake + "'"+
                    "ORDER BY ins_selection.Section";

                Show_Section.Items.Clear();
                Show_Select_Course.Items.Clear();
                Show_Student.DataSource = null;
                
                Get_Department_Name(query, "Show_Section");
            }

        }

        private void Show_Section_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ins_dept_name = Show_Department.Text.Trim();
            string intake = Show_Intake.Text.Trim();
            string section = Show_Section.Text.Trim();

            InstructorSelect obj = new InstructorSelect();

            if (obj.is_valid(ins_dept_name, intake, section) == true)
            {
                string year_month_Date = obj.Get_Current_Time();   // Get Current Time (Year-Month-Date)
                string query = "SELECT DISTINCT ins_selection.Course_ID AS Course  FROM department, ins_selection WHERE department.ID=ins_selection.Dept_ID AND" +
                    " ins_selection.Ins_ID='" + ins_id + "' AND ins_selection.Intake='" + intake + "' AND ins_selection.Section='" + section + "' AND " +
                    "ins_selection.Starting_Time <= '" + year_month_Date + "' AND ins_selection.Ending_Time >= '" + year_month_Date + "'";

                Show_Student.DataSource = null;
                Show_Select_Course.Items.Clear();
                Get_Department_Name(query, "Show_Select_Course");
            }
        }

        private void Show_Select_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Student.DataSource = null;
            Total_Class = Get_Total_Class(Show_Department.Text.Trim(), Show_Select_Course.Text.Trim());
            Disp_Stu_Info();
        }

        private string Get_Total_Class(string dept_name, string course_id)
        {
            string query = "SELECT courses.Total_Class AS Instructor_ID FROM department, courses WHERE " +
                "department.ID=courses.Dept_ID AND department.Dept_Name='" + dept_name + "' AND courses.Course_ID='" + course_id + "';";

            return Get_Instructor_ID(query);
        }

        private void Disp_Stu_Info()
        {
            string ins_dept_name = Show_Department.Text.Trim();
            string intake = Show_Intake.Text.Trim();
            string section = Show_Section.Text.Trim();
            string course_id = Show_Select_Course.Text.Trim();

            if (is_valid(ins_dept_name, intake, section, course_id) == true)
            {
                /*
                 string query = "SELECT students.Student_ID AS 'Student ID', students.Name, students.Email, " +
                    "students.Phone_No AS 'Phone Number', students.Address FROM students, department " +
                    "WHERE department.ID=students.Dept_ID AND department.Dept_Name='" + ins_dept_name + "' AND" +
                    " students.Intake='" + intake + "' AND students.Section='" + section + "'"; 
               */

                InstructorSelect obj = new InstructorSelect();

                string year_month_Date = obj.Get_Current_Time();   // Get Current Time (Year-Month-Date)

                string query = "SELECT students.Student_ID AS 'Student ID', students.Name, students.Email, students.Phone_No AS 'Phone Number', " +
                    "students.Address , (SELECT CASE WHEN COUNT(attendance.Present_Or_Not) > 0 then 'Yes' else 'No' end from attendance WHERE students.Student_ID=attendance.Student_ID AND attendance.Year='" + year_month_Date + "' AND attendance.Course_ID='" + course_id + "') AS Present " +
                    "FROM students, department " +
                    "WHERE department.ID = students.Dept_ID AND department.Dept_Name='" + ins_dept_name + "' AND students.Intake='" + intake + "' AND students.Section='" + section + "'" +
                    "ORDER BY students.Student_ID;";

                Show_Student.DataSource = null;
                Display_Student_Info(query);
            }
        }

        private bool is_valid(string ins_dept_name, string intake, string section, string course_id)
        {
            InstructorSelect obj = new InstructorSelect();

            if(obj.is_valid(ins_dept_name, intake, section) == false)
            {
                return false;
            }
            else if(course_id == string.Empty)
            {
                MessageBox.Show("Please Select a Course.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Display_Student_Info(string query)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();
 

            try
            {
                MySqlCommand command = new MySqlCommand(query, connect);
                MySqlDataReader dataReader = command.ExecuteReader();
                DataTable data_table = new DataTable();

                data_table.Load(dataReader);
                Show_Student.DataSource = data_table;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

         
            connect.Close();
        }


        private void Show_Student_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = "-1";  // set default value
        }
        private void Show_Student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string student_id = string.Empty;
            try
            {
                student_id = Show_Student.SelectedRows[0].Cells[0].Value.ToString();  // error
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (student_id == "-1")
            {
                MessageBox.Show("Please Select a Student.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Show_Student.DataSource = null;
                Disp_Stu_Info();
            }
        }


        private void Add_Attendance_Click(object sender, EventArgs e)
        {
            string ins_dept_name = Show_Department.Text.Trim();
            string intake = Show_Intake.Text.Trim();
            string section = Show_Section.Text.Trim();
            string course_id = Show_Select_Course.Text.Trim();
            string semester = Show_Semester_Name.Text.Trim();
            
            

            if (is_valid(ins_dept_name, intake, section, course_id) == true)
            {
                string student_id = string.Empty;

                try
                {
                    student_id = Show_Student.SelectedRows[0].Cells[0].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Select a Student.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                InstructorSelect obj = new InstructorSelect();
                string year_month_Date = obj.Get_Current_Time();   // Get Current Time (Year-Month-Date)
                string query = "INSERT INTO `attendance` (`Student_ID`, `Course_ID`, `Present_Or_Not`, `Year`, `Semester`) " +
                    "VALUES ('"+ student_id +"', '" + course_id + "', '1', '" + year_month_Date + "', '" + semester + "');";
                
                AddNewStudent obj1 = new AddNewStudent();

                obj1.Student_Info_Save_To_Database(query);
                Disp_Stu_Info();
            }
        }

        private void Add_Marks_Click(object sender, EventArgs e)
        {
            string ins_dept_name = Show_Department.Text.Trim();
            string intake = Show_Intake.Text.Trim();
            string section = Show_Section.Text.Trim();
            string course_id = Show_Select_Course.Text.Trim();
            string semester = Show_Semester_Name.Text.Trim();

            if (is_valid(ins_dept_name, intake, section, course_id) == true)
            {
                string student_id = string.Empty;

                try
                {
                    student_id = Show_Student.SelectedRows[0].Cells[0].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Select a Student.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                this.Hide();

                AddStudentMarks obj = new AddStudentMarks();
                string StudentName = Show_Student.SelectedRows[0].Cells[1].Value.ToString();

                obj.PassingStudentId = student_id;  // pass value this Windows Form to "AddStudentMarks" Windows Form
                obj.passingCourseId = course_id;  // pass value this Windows Form to "AddStudentMarks" Windows Form
                obj.passingStudentName = StudentName;   // pass value this Windows Form to "AddStudentMarks" Windows Form
                obj.passingSemester = semester;

                obj.Text = StudentName;    // Change the Student Marks Form Title.
                obj.Refresh();

                obj.ShowDialog();
                this.Show();

            }
        }

        private void Show_Student_Details_Click(object sender, EventArgs e)
        {
            string ins_dept_name = Show_Department.Text.Trim();
            string intake = Show_Intake.Text.Trim();
            string section = Show_Section.Text.Trim();
            string course_id = Show_Select_Course.Text.Trim();
            string semester = Show_Semester_Name.Text.Trim();

            if (is_valid(ins_dept_name, intake, section, course_id) == true)
            {
                string student_id = string.Empty;

                try
                {
                    student_id = Show_Student.SelectedRows[0].Cells[0].Value.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select a Student.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                this.Hide();
                StudentDetails obj = new StudentDetails();

                string StudentName = Show_Student.SelectedRows[0].Cells[1].Value.ToString();

                obj.PassingStudentID = student_id;
                obj.PassingStudentName = StudentName;
                obj.PassingCourseID = course_id;
                obj.PassingIntake = intake;
                obj.PassinStudentEmail = Show_Student.SelectedRows[0].Cells[2].Value.ToString();
                obj.PassinStudentPhoneNo = Show_Student.SelectedRows[0].Cells[3].Value.ToString();
                obj.PassinStudentAddress = Show_Student.SelectedRows[0].Cells[4].Value.ToString();
                obj.PassingTotalClass = Total_Class; 

                obj.ShowDialog();
                this.Show();
            }
        }

        private void Exam_Permission_Click(object sender, EventArgs e)
        {
            string ins_dept_name = Show_Department.Text.Trim();
            string intake = Show_Intake.Text.Trim();
            string section = Show_Section.Text.Trim();
            string course_id = Show_Select_Course.Text.Trim();

            if (is_valid(ins_dept_name, intake, section, course_id) == true)
            {
                this.Hide();
                AllStudentExamPermission obj = new AllStudentExamPermission();

                obj.PassingDeptartmentName = ins_dept_name;
                obj.PassingIntake = intake;
                obj.PassingSection = section;
                obj.PassingCourseID = course_id;
                obj.PassingTotalClass = Total_Class;

                obj.ShowDialog();
                this.Show();
            }

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