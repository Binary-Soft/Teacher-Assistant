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
        string ins_email = Form1.INSTRUCTOR_EMAIL;
        string ins_id = string.Empty;

        public InstructorProfile()
        {
            InitializeComponent();
        }

        private void InstructorProfile_Load(object sender, EventArgs e)
        {
            
            Temp_Instructor_Email.Text = ins_email;

            string query = "SELECT instructor.Ins_ID AS Instructor_ID FROM instructor WHERE instructor.Email='"+ ins_email +"'";
            ins_id = Get_Instructor_ID(query);


            if(ins_id != string.Empty)
            {
                query = "SELECT DISTINCT department.Dept_Name AS Department FROM department, ins_selection " +
                "WHERE department.ID=ins_selection.Dept_ID AND ins_selection.Ins_ID='" + ins_id +"'";

                Get_Department_Name(query, "Show_Department");
            }
        }

        private string Get_Instructor_ID(string query)
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
                        Show_Semester_Name.Items.Add(dataReader.GetString("Semester"));
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
            string ins_email = Temp_Instructor_Email.Text.Trim();
            string ins_dept_name = Show_Department.Text.Trim();

            InstructorSelect obj = new InstructorSelect();

            if(obj.is_valid(ins_dept_name) == true)
            {
                
                string query = "SELECT DISTINCT ins_selection.Intake AS Intake FROM department,ins_selection " +
                    "WHERE department.ID=ins_selection.Dept_ID AND ins_selection.Ins_ID='" + ins_id + "' AND department.Dept_Name='" + ins_dept_name + "'";

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
                    "WHERE instructor.Ins_ID=ins_selection.Ins_ID AND instructor.Ins_ID='" + ins_id + "' AND ins_selection.Intake='" + intake + "'";

                Show_Section.Items.Clear();
                Show_Select_Course.Items.Clear();

                
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

                Get_Department_Name(query, "Show_Select_Course");
            }
        }


        private void Submit_Info_Click(object sender, EventArgs e)
        {
            
        }
    }
}
