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
    public partial class AllStudentExamPermission : Form
    {
        private string Student_Dept_Name = string.Empty;
        private string INTAKE = string.Empty;
        private string SECTION = string.Empty;
        private string COURSE_ID = string.Empty;
        private string TOTAL_CLASS = string.Empty;


        public AllStudentExamPermission()
        {
            InitializeComponent();
        }

        private void AllStudentExamPermission_Load(object sender, EventArgs e)
        {
            Show_Student_Info();
        }

        public string PassingDeptartmentName
        {
            set { Student_Dept_Name = value; }
            get { return Student_Dept_Name; }
        }
        public string PassingIntake
        {
            set { INTAKE = value; }
            get { return INTAKE; }
        }
        public string PassingSection
        {
            set { SECTION = value; }
            get { return SECTION; }
        }
        public string PassingCourseID
        {
            set { COURSE_ID = value; }
            get { return COURSE_ID; }
        }
        public string PassingTotalClass
        {
            set { TOTAL_CLASS = value; }
            get { return TOTAL_CLASS; }
        }


        private void Show_Student_Info()
        {
            string query = "with AllStuTotalAtt(Stu_Name ,Stu_ID, Total_Attendance) AS (SELECT students.Name, students.Student_ID, " +
                 "(SELECT COUNT(attendance.Present_Or_Not) from attendance WHERE students.Student_ID=attendance.Student_ID AND ins_selection.Course_ID=attendance.Course_ID) as 'Total' " +
                 "from department, students, ins_selection WHERE department.ID=students.Dept_ID AND students.Dept_ID=ins_selection.Dept_ID AND students.Intake=ins_selection.Intake AND " +
                 "students.Section=ins_selection.Section  AND ins_selection.Course_ID='" + COURSE_ID + "' AND department.Dept_Name='" + Student_Dept_Name + "' AND ins_selection.Intake='" + INTAKE + "' AND ins_selection.Section='" + SECTION + "') " +
                 "SELECT AllStuTotalAtt.Stu_Name AS 'Student Name', AllStuTotalAtt.Stu_ID AS 'Student ID', AllStuTotalAtt.Total_Attendance 'Total Attendance', (100*AllStuTotalAtt.Total_Attendance)/"+ TOTAL_CLASS + " AS 'Percentage (Attendance)'," +
                 "(CASE WHEN (100*AllStuTotalAtt.Total_Attendance)/" + TOTAL_CLASS + " >= 70.00 THEN 'Final Exam' WHEN (100*AllStuTotalAtt.Total_Attendance)/("+ TOTAL_CLASS + "/2) >= 70.00 THEN 'Mid Exam' ELSE 'No' END) AS 'Mid Or Final' from AllStuTotalAtt;";

            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();


            try
            {
                MySqlCommand command = new MySqlCommand(query, connect);
                MySqlDataReader dataReader = command.ExecuteReader();
                DataTable data_table = new DataTable();

                data_table.Load(dataReader);
                Show_Students_Atd_Per.DataSource = data_table;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            connect.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure?", "Close this Window.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
