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
    public partial class AddStudentMarks : Form
    {
        private string STUDENT_ID = string.Empty;
        private string COURSE_ID = string.Empty;
        private string STUDENT_NAME = string.Empty;
        private string SEMESTER = string.Empty;

        public AddStudentMarks()
        {
            InitializeComponent();
        }

        public string PassingStudentId
        {
            get { return STUDENT_ID; }
            set { STUDENT_ID = value; }
        }
        public string passingStudentName
        {
            get { return STUDENT_NAME; }
            set { STUDENT_NAME = value; }
        }
        public string passingCourseId
        {
            get { return COURSE_ID; }
            set { COURSE_ID = value; }
        }
        public string passingSemester
        {
            get { return SEMESTER; }
            set { SEMESTER = value; }
        }


        private void AddStudentMarks_Load(object sender, EventArgs e)
        {
            Show_Student_ID.Text = STUDENT_ID;
            Show_Student_Name.Text = STUDENT_NAME;
            Show_Course_ID.Text = COURSE_ID;

            Display_Student_Marks();
            Display_Marks_Type();
        }

        private void Display_Student_Marks()
        {
            /* // wrong query
             
            string query = "SELECT marks.Assignment_1 AS 'Assignment 1', marks.Class_Test_1 AS 'Class Test 1', marks.Lab_Performance_1 AS 'Lab Performance 1', marks.Mid_Exam AS 'Mid Exam', marks.Assignment_2 AS 'Assignment 2', " +
                "marks.Class_Test_2 AS 'Class Test 2', marks.Lab_Performance_2 AS 'Lab Performance 2', marks.Final_Exam AS 'Final Exam' FROM attendance, marks, course_prefer " +
                "WHERE attendance.Student_ID=marks.Student_ID AND course_prefer.Course_ID=marks.Course_ID AND attendance.Course_ID=marks.Course_ID AND " +
                "marks.Student_ID='" + STUDENT_ID + "' AND marks.Course_ID='" + COURSE_ID + "'";
            */

            string query = "SELECT marks.Assignment_1 AS 'Assignment 1', marks.Class_Test_1 AS 'Class Test 1', marks.Lab_Performance_1 AS 'Lab Performance 1', " +
                "marks.Mid_Exam AS 'Mid Exam', marks.Assignment_2 AS 'Assignment 2', marks.Class_Test_2 AS 'Class Test 2', marks.Lab_Performance_2 AS 'Lab Performance 2', " +
                "marks.Final_Exam AS 'Final Exam', marks.Year AS 'Date' FROM marks WHERE marks.Student_ID='" + STUDENT_ID + "' AND marks.Course_ID='" + COURSE_ID + "';";

            Get_Student_Marks(query);
        }
        private void Display_Marks_Type()
        {
            string []Examtype = { "Assignment 1", "Class Test 1", "Lab Performance 1", "Mid Exam", "Assignment 2", "Class Test 2", "Lab Performance 2", "Final Exam" };

            for (int i=0; i< Examtype.Length; i++)
            {
                Show_Marks_Type.Items.Add(Examtype[i]);
            }
        }

        private void Get_Student_Marks(string query)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();


            try
            {
                MySqlCommand command = new MySqlCommand(query, connect);
                MySqlDataReader dataReader = command.ExecuteReader();
                DataTable data_table = new DataTable();

                data_table.Load(dataReader);
                Show_Student_Marks.DataSource = data_table;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            connect.Close();
        }

        private void Submit_Marks_Click(object sender, EventArgs e)
        {
            string Exam_Type = Show_Marks_Type.Text.Trim();
            string mark = Get_Marks.Text.Trim();

            InstructorSelect obj = new InstructorSelect();
            string year_month_Date = obj.Get_Current_Time();   // Get Current Time (Year-Month-Date)

            string Mark_Table_Att_Name_exam_type = Get_Exam_Type(Exam_Type);

            
            if (is_valid(Exam_Type, mark) == true)
            {
                string query = "INSERT INTO `marks` (`Student_ID`, `Course_ID`, `Year`, `Semester`, `"+ Mark_Table_Att_Name_exam_type + "`) " +
                    "VALUES ('" + STUDENT_ID + "', '" + COURSE_ID + "', '" + year_month_Date + "', '" + SEMESTER + "', '" + mark + "');";
               
                if(is_Mark_Already_Submitted(STUDENT_ID, COURSE_ID, Mark_Table_Att_Name_exam_type) == false)
                {
                    if (Save_Info_To_Database(query) == true)
                    {
                        MessageBox.Show("Saved Successfully.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset_All();
                        Show_Student_Marks.DataSource = null;
                        Display_Student_Marks();
                    }
                    else
                    {
                        MessageBox.Show("Information Saving Failed. Please Try Again.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(Exam_Type + " Marks Can Not be Submitted Twice.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }

        }

        private bool is_Mark_Already_Submitted(string Student_ID, string Course_ID, string Exam_Type)
        {
            InstructorProfile obj = new InstructorProfile();

            string query = "SELECT COUNT(marks.Student_ID) AS Instructor_ID FROM marks WHERE marks.Student_ID='" + Student_ID + "' AND " +
                "marks.Course_ID='"+ Course_ID + "' AND marks."+ Exam_Type + " > 0";

            if(Convert.ToInt32(obj.Get_Instructor_ID(query)) > 0)
            {
                return true;
            }

            return false;
        }

        private void Reset_All()
        {
            Get_Marks.Clear();
            Show_Marks_Type.Items.Clear();
            Display_Marks_Type();
        }

        private string Get_Exam_Type(string exam_type)
        {
            string[] Examtype = { "Assignment 1", "Class Test 1", "Lab Performance 1", "Mid Exam", "Assignment 2", "Class Test 2", "Lab Performance 2", "Final Exam" };

            for(int i=0; i<Examtype.Length; i++)
            {
                if(Examtype[i] == exam_type)
                {
                    return Examtype[i].Replace(' ', '_');
                }
            }
            return string.Empty;
        }


        private bool is_valid(string Exam_Type, string mark)
        {
            if(Exam_Type == string.Empty)
            {
                MessageBox.Show("Please Select Marks Type.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(mark == string.Empty)
            {
                MessageBox.Show("Please Enter Marks.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(mark != string.Empty)
            {
                if (is_Exist_Any_Character(mark) == true)
                {
                    MessageBox.Show("Please Enter Valid Mark.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Get_Marks.Focus();
                    return false;
                }
                else if(Check_Max_Mini_Limit(Exam_Type, mark) == false)
                {
                    MessageBox.Show("Incorrect Number! "+ Get_Error_Message(Exam_Type, mark), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Get_Marks.Focus();
                    return false;
                }
            }

            return true;
        }

        private string Get_Error_Message(string Exam_Type, string mark)
        {
            if(Exam_Type == "Assignment 1" || Exam_Type == "Assignment 2" || Exam_Type == "Class Test 1" || Exam_Type == "Class Test 2")
            {
                return Exam_Type + " Mark Can Not be Negative or More Than 5.0";
            }
            else if (Exam_Type == "Lab Performance 1" || Exam_Type == "Mid Exam")
            {
                return Exam_Type + " Mark Can Not be Negative or More Than 30.0";
            }
            else if (Exam_Type == "Lab Performance 2" || Exam_Type == "Final Exam")
            {
                return Exam_Type + " Marks Can Not be Negative or More Than 40.0";
            }

            return string.Empty;
        }

        private bool is_Exist_Any_Character(string mark)
        {
            for(int i=0; i<mark.Length; i++)
            {
                if((mark[i] >= 'A' && mark[i] <= 'Z') || (mark[i] >= 'a' && mark[i] <= 'z'))
                {
                    return true;
                }
            }

            return false;
        }

        private bool Check_Max_Mini_Limit(string Exam_Type, string mark)
        {
            double number = Convert.ToDouble(mark);

            if ((Exam_Type == "Assignment 1" || Exam_Type == "Assignment 2") && (number >= 0.0 && number <= 5.0))
            {
                return true;
            }
            else if ((Exam_Type == "Class Test 1" || Exam_Type == "Class Test 2") && (number >= 0.0 && number <= 5.0))
            {
                return true;
            }
            else if (Exam_Type == "Mid Exam" && (number >= 0.0 && number <= 30.0))
            {
                return true;
            }
            else if (Exam_Type == "Final Exam" && (number >= 0.0 && number <= 40.0))
            {
                return true;
            }
            else if ((Exam_Type == "Lab Performance 1" && (number >= 0.0 && number <= 30.0)) || (Exam_Type == "Lab Performance 2" && (number >= 0.0 && number <= 40.0)))
            {
                return true;
            }

            return false;
        }

        private void Update_Marks_Click(object sender, EventArgs e)
        {
            string Exam_Type = Show_Marks_Type.Text.Trim();
            string mark = Get_Marks.Text.Trim();
            string Mark_Table_Att_Name_exam_type = Get_Exam_Type(Exam_Type);

            

            if (is_valid(Exam_Type, mark) == true)
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Update " + Exam_Type.Replace('_', ' ') + " Marks?", "Update!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "UPDATE marks SET marks."+ Mark_Table_Att_Name_exam_type + "='"+ mark +"' WHERE marks."+ Mark_Table_Att_Name_exam_type + " !=0";

                    
                    if (Save_Info_To_Database(query) == true)
                    {
                        MessageBox.Show("Save Successfull.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset_All();
                        Show_Student_Marks.DataSource = null;
                        Display_Student_Marks();
                    }
                    else
                    {
                        MessageBox.Show("Information Save Failed. Please Try Again.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }


        private bool Save_Info_To_Database(string query)
        {
            AddNewStudent obj1 = new AddNewStudent();

            return obj1.Student_Info_Save_To_Database(query);
        }

        private void Show_Marks_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get_Marks.Clear();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure?", "Close this Window.", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
