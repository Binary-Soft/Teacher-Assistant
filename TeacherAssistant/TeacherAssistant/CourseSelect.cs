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
            Get_Department_Name();
        }


        private void Get_Department_Name()
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();


            string query = "SELECT department.Dept_Name AS Department FROM department";
            try
            {
                MySqlCommand command = new MySqlCommand(query, connect);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Show_Department.Items.Add(dataReader.GetString("Department"));
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

            if(is_valid(dept_name) == true)
            {
                Show_Intake.Items.Clear();
                Show_Section.Items.Clear();
                Select_Course.Items.Clear();
                Show_Course(dept_name);
                string query = query = "SELECT dept_intake.Intake AS Intake FROM department, dept_intake WHERE department.ID=dept_intake.Dept_ID AND" +
                    " department.Dept_Name='" + dept_name + "'";


                Display_Intake_Section(query, "Show_Intake");
            }
        }

        private bool is_valid(string dept_name)
        {
            if(dept_name == string.Empty)
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
                else if(function_name == "Show_Section")
                {
                    while (dataReader.Read())
                    {
                        Show_Section.Items.Add(dataReader.GetString("Section"));
                    }
                }
                else if (function_name == "Show_Course")
                {
                    while (dataReader.Read())
                    {
                        Select_Course.Items.Add(dataReader.GetString("Course_Title") + " (" + dataReader.GetString("Course_ID") + ")");
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

            if(is_valid(dept_name, intake) == true)
            {
                Show_Section.Items.Clear();
                string query = "SELECT dept_intake_section.Section AS Section FROM department, dept_intake, dept_intake_section " +
                    "WHERE department.ID=dept_intake.Dept_ID AND department.ID=dept_intake_section.Dept_ID AND " +
                    "dept_intake.Intake=dept_intake_section.Intake AND department.Dept_Name='" + dept_name + "' AND dept_intake.Intake='" + intake + "'";

                Display_Intake_Section(query, "Show_Section");
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
            if(is_valid(dept_name) == false)
            {
                return false;
            }
            else if(intake == string.Empty)
            {
                MessageBox.Show("Please Select Intake.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


    }
}
