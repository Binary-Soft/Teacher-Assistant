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
    public partial class InstructorSelect : Form
    {
        public InstructorSelect()
        {
            InitializeComponent();
        }

        private void InstructorSelect_Load(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT department.Dept_Name AS Department FROM department, dept_intake_section " +
                    "WHERE department.ID=dept_intake_section.Dept_ID";

            
            Get_Department_Name(query, "Show_Department");

            query = "SELECT semesters.Semester AS Semester FROM semesters";
            Get_Department_Name(query, "Show_Semester_Name");
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
                else if(Function_Name == "Show_Semester_Name")
                {
                    while (dataReader.Read())
                    {
                        Show_Semester_Name.Items.Add(dataReader.GetString("Semester"));
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
                else if(Function_Name == "Show_Instructor_ID")
                {
                    while (dataReader.Read())
                    {
                        Show_Instructor_ID.Items.Add(dataReader.GetString("Instructor_ID"));
                    }
                }
                else if(Function_Name == "Show_Select_Course")
                {
                    while(dataReader.Read())
                    {
                        Show_Select_Course.Items.Add(dataReader.GetString("Course"));
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
                Show_Sectuin_Course.DataSource = null;

                string query = "SELECT DISTINCT course_prefer.Intake AS Intake " +
                    "FROM department, course_prefer ,dept_intake_section " +
                    "WHERE department.ID=course_prefer.Dept_ID AND " +
                    "course_prefer.Dept_ID=dept_intake_section.Dept_ID AND department.Dept_Name='"+ dept_name +"'";

                Show_Intake.Items.Clear();
                Show_Section.Items.Clear();
                Show_Instructor_ID.Items.Clear();
                Show_Select_Course.Items.Clear();
                Show_Instructor_Name.Clear();

                Get_Department_Name(query, "Show_Intake");

                query = "SELECT DISTINCT instructor.Ins_ID AS Instructor_ID FROM department, instructor " +
                    "WHERE department.ID=instructor.Dept_ID AND department.Dept_Name='" + dept_name + "'";

                Get_Department_Name(query, "Show_Instructor_ID");
            }
        }

        private void Show_Intake_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dept_name = Show_Department.Text.Trim();
            string intake = Show_Intake.Text.Trim();


            if (is_valid(dept_name, intake) == true)
            {
                Show_Sectuin_Course.DataSource = null;
                Show_Select_Course.Items.Clear();
                Show_Section.Items.Clear();
                Show_Instructor_Name.Clear();

                string query = "SELECT DISTINCT course_prefer.Course_ID AS Course FROM department, course_prefer " +
                    "WHERE department.ID=course_prefer.Dept_ID AND department.Dept_Name='" + dept_name + "' AND course_prefer.Intake='" + intake + "'";
                Get_Department_Name(query, "Show_Select_Course");


                query = "SELECT DISTINCT dept_intake_section.Section AS Section FROM department, dept_intake_section " +
                    "WHERE department.ID=dept_intake_section.Dept_ID AND department.Dept_Name='" + dept_name + "' AND dept_intake_section.Intake='" + intake + "'";
                Get_Department_Name(query, "Show_Section");
            }
        }

        public bool is_valid(string DepartName)
        {
            if(DepartName == string.Empty)
            {
                MessageBox.Show("Please Select Department Name", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public bool is_valid(string DepartName, string intake)
        {
            if (is_valid(DepartName) == false)
            {
                return false;
            }
            else if(intake == string.Empty)
            {
                MessageBox.Show("Please Select Intake", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public bool is_valid(string DepartName, string intake, string section)
        {
            if(is_valid(DepartName, intake) == false)
            {
                return false;
            }
            else if(section == string.Empty)
            {
                MessageBox.Show("Please Select Section.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Show_Instructor_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string instructor_id = Show_Instructor_ID.Text.Trim();

            if(instructor_id != string.Empty)
            {
                Show_Instructor_Name.Text = Get_Instructor_Name(instructor_id);
            }
            else
            {
                MessageBox.Show("Please Select Instructor ID.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string Get_Instructor_Name(string instructor_id)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();

            string query = "SELECT instructor.Name AS Instructor_Name FROM instructor WHERE instructor.Ins_ID='" + instructor_id + "'";


            try
            {
                MySqlCommand command = new MySqlCommand(query, connect);
                MySqlDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                }

                string name = dataReader.GetString("Instructor_Name");
                connect.Close();
                return name;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            connect.Close();
            return String.Empty;
        }

        private void Submit_Info_Click(object sender, EventArgs e)
        {
            string dept_name = Show_Department.Text.Trim();
            string intake = Show_Intake.Text.Trim();
            string section = Show_Section.Text.Trim();
            string course_id = Show_Select_Course.Text.Trim();
            string ins_id = Show_Instructor_ID.Text.Trim();
            string semester = Show_Semester_Name.Text.Trim();
            

            if(is_valid(dept_name, intake, section, ins_id, semester, course_id) == true)
            {
                Save_To_DataBase(dept_name, intake, section, ins_id, semester, course_id);
                Show_Sectuin_Course.DataSource = null;
                Show_Prefer_Courses();

            }
        }

        private void Save_To_DataBase(string dept_name, string intake, string section, string ins_id, string semester, string course_id)
        {
            AddNewStudent obj = new AddNewStudent();  //  //  =====>> From AddNewStudent.cs file   <<=====

            string dept_id = obj.Get_Department_ID("SELECT department.ID AS Dept_ID  FROM department WHERE department.Dept_Name='" + dept_name + "'");

            string currentTime = Get_Current_Time();
            string endingTime = Get_Ending_Time();

            string query = "INSERT INTO `ins_selection` (`Dept_ID`, `Intake`, `Section`, `Course_ID`, `Ins_ID`, `Semester`, `Starting_Time`, `Ending_Time`) " +
                "VALUES ('" + dept_id + "', '" + intake + "', '" + section + "', '" + course_id + "', '" + ins_id + "', '" + semester + "', '" + currentTime + "', '" + endingTime + "')";

            if (obj.Student_Info_Save_To_Database(query) == true)    // <<==== this function exist AddNewStudent.cs file
            {
                MessageBox.Show("Saved Successfully.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Information Saving Failed. Please Try Again.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string Get_Current_Time()
        {
            string year_month_Date = DateTime.Now.ToString("yyy/MM/dd").Replace('/', '-');

            return year_month_Date;
        }

        private string Get_Ending_Time()
        {
            DateTime DT = new DateTime();

            DT = DateTime.Now.AddMonths(4);

            string year = Convert.ToString(DT.Year);
            string month = Convert.ToString(DT.Month);
            string date = Convert.ToString(DT.Day);


            return year + "-" + month + "-" + date;
        }

        private bool is_valid(string dept_name, string intake, string section, string ins_id, string semester, string course_id)
        {
            if(is_valid(dept_name, intake, section) == false)
            {
                return false;
            }
            else if(ins_id == string.Empty)
            {
                MessageBox.Show("Please Select Instructor ID.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(semester == string.Empty)
            {
                MessageBox.Show("Please Select Semester.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(course_id == string.Empty)
            {
                MessageBox.Show("Please Select Course ID.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure?", "Close this Window.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Show_Section_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Prefer_Courses();
        }


        private void Show_Prefer_Courses()
        {
            string dept_name = Show_Department.Text.Trim();
            string intake = Show_Intake.Text.Trim();
            string section = Show_Section.Text.Trim();

            if(is_valid(dept_name, intake, section) == true)
            {
                string current_time = Get_Current_Time();
                string query = "SELECT ins_selection.Course_ID As 'Course ID', ins_selection.Ins_ID AS 'Instructor ID' " +
                    "FROM ins_selection, department WHERE ins_selection.Dept_ID=department.ID AND department.Dept_Name='" + dept_name + "' " +
                    "AND ins_selection.Intake='" + intake + "' AND ins_selection.Section='" + section + "' AND ins_selection.Starting_Time <= '" + current_time + "'" +
                    " AND ins_selection.Ending_Time >='" + current_time + "';";

                MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
                connect.Open();


                try
                {
                    MySqlCommand command = new MySqlCommand(query, connect);
                    MySqlDataReader dataReader = command.ExecuteReader();
                    DataTable data_table = new DataTable();

                    data_table.Load(dataReader);
                    Show_Sectuin_Course.DataSource = data_table;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                connect.Close();
            }
        }
    }
}
