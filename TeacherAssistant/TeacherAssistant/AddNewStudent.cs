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
    public partial class AddNewStudent : Form
    {
        public AddNewStudent()
        {
            InitializeComponent();
        }


        private void AddNewStudent_Load(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT department.Dept_Name AS Department FROM department, dept_intake_section " +
                "WHERE department.ID=dept_intake_section.Dept_ID";
            Get_Department_Intake_Section_Semester_Record(query, "Show_Department");
            Get_Department_Intake_Section_Semester_Record("SELECT semesters.Semester AS Semester FROM  semesters", "Semester_Name");
            Student_Name.Focus();
        }

        private void Get_Department_Intake_Section_Semester_Record(string query, string add_function_name)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();


            try
            {
                MySqlCommand command = new MySqlCommand(query, connect);
                MySqlDataReader dataReader = command.ExecuteReader();

                if(add_function_name == "Show_Department")
                {
                    while (dataReader.Read())
                    {
                        Show_Department.Items.Add(dataReader.GetString("Department"));
                    }
                }
                else if(add_function_name == "Semester_Name")
                {
                    while (dataReader.Read())
                    {
                        Semester_Name.Items.Add(dataReader.GetString("Semester"));
                    }
                }
                else if(add_function_name == "Show_Intake")
                {
                    while (dataReader.Read())
                    {
                        Show_Intake.Items.Add(dataReader.GetString("Intake"));
                    }
                }
                else if(add_function_name == "Show_Section")
                {
                    while (dataReader.Read())
                    {
                        Show_Section.Items.Add(dataReader.GetString("Section"));
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
            string department_name= Show_Department.Text.Trim();
            Show_Intake.Items.Clear();
            Show_Section.Items.Clear();
            if(department_name == string.Empty)
            {
                MessageBox.Show("Please Select A Department.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "SELECT DISTINCT dept_intake_section.Intake AS Intake FROM department, dept_intake_section " +
                    "WHERE department.Dept_Name='" + department_name + "' and department.ID=dept_intake_section.Dept_ID";
                Get_Department_Intake_Section_Semester_Record(query, "Show_Intake");
            }
        }

        private void Show_Intake_SelectedIndexChanged(object sender, EventArgs e)
        {
            string department_name = Show_Department.Text.Trim();
            string intake = Show_Intake.Text.Trim();
            Show_Section.Items.Clear();
            if (department_name == string.Empty)
            {
                MessageBox.Show("Please Select A Department.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(intake == string.Empty)
            {
                MessageBox.Show("Please Select A Intake.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string query = "SELECT dept_intake_section.Section " +
                    "FROM department, dept_intake, dept_intake_section " +
                    "WHERE department.ID=dept_intake.Dept_ID AND department.ID=dept_intake_section.Dept_ID " +
                    "AND department.Dept_Name='" + department_name + "' AND dept_intake.Intake=dept_intake_section.Intake " +
                    "AND dept_intake.Intake=" + intake;
                Get_Department_Intake_Section_Semester_Record(query, "Show_Section");
            }
        }

        private void Subbit_Student_Info_Click(object sender, EventArgs e)
        {
            string name = Student_Name.Text.Trim();
            string stu_id = Student_ID.Text.Trim();
            string semester = Semester_Name.Text.Trim();
            string email = Email.Text.Trim();
            string department_name = Show_Department.Text.Trim();
            string intake = Show_Intake.Text.Trim();
            string section = Show_Section.Text.Trim();
            string phone = Phone_No.Text.Trim();
            string address = Address.Text.Trim();
            string year = Year.Text.Trim();

            if(is_Valid(name, stu_id, semester, email, department_name, intake, section, phone, address, year) == true)
            {
                string query = "SELECT department.ID AS Dept_ID FROM department WHERE department.Dept_Name='" + department_name + "'";

                string dept_Id = Get_Department_ID(query);
                

                query = "INSERT INTO students (`Student_ID`, `Name`, `Email`, `Dept_ID`, `Intake`, `Section`, `Phone_No`, `Address`, `Years`, `Semester`) " +
                    "VALUES('" + stu_id + "', '" + name + "', '" + email + "', '" + dept_Id + "', '" + intake + "', '" + section + "', '" + phone + "', '" + address + "', '" + year + "', '" + semester + "')";

                if(Student_Info_Save_To_Database(query) == true)
                {
                    MessageBox.Show("Save Successfull.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Information Save Failed. Please Try Again.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }


        public bool Student_Info_Save_To_Database(string query)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();


            MySqlCommand command = connect.CreateCommand();
            command.CommandText = query;

            try
            {
                command.ExecuteNonQuery();
                connect.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connect.Close();

            return false;
        }


        public string Get_Department_ID(string query)
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

                string Dept_ID = dataReader.GetString("Dept_ID");
                connect.Close();
                return Dept_ID;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connect.Close();
            return string.Empty;
        }

        private bool is_Valid(string name, string stu_id, string semester, string email, string department_name, string intake, string section, string phone, string address, string year)
        {
            
            if (name == string.Empty)
            {
                MessageBox.Show("Please Enter Student Name.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Student_Name.Focus();
                return false;
            }
            else if (stu_id == string.Empty)
            {
                MessageBox.Show("Please Fillup Student ID.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Student_ID.Focus();
                return false;
            }
            else if (semester == string.Empty)
            {
                MessageBox.Show("Please Select Semester Name.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (email == string.Empty)
            {
                MessageBox.Show("Please Enter Student E-mail.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Email.Focus();
                return false;
            }
            else if (department_name == string.Empty)
            {
                MessageBox.Show("Please Select Department Name", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (intake == string.Empty)
            {
                MessageBox.Show("Please Select Intake.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (section == string.Empty)
            {
                MessageBox.Show("Please Select Section.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (phone == string.Empty)
            {
                MessageBox.Show("Please Enter Student Phone Number.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Phone_No.Focus();
                return false;
            }
            else if (address == string.Empty)
            {
                MessageBox.Show("Please Enter Student Addresss.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Address.Focus();
                return false;
            }
            else if (year == string.Empty)
            {
                MessageBox.Show("Please Enter Current Year.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Year.Focus();
                return false;
            }
            else if (stu_id != string.Empty && email != string.Empty && phone != string.Empty)
            {
                return Student_ID_Email_PhoneNo_Is_Unique(stu_id, email, phone);
            }

            return true;
        }

        private bool Student_ID_Email_PhoneNo_Is_Unique(string stu_id, string email, string phone)
        {
            string query = "SELECT COUNT(students.Student_ID) AS Tota_Student_ID from students WHERE students.Student_ID=" + stu_id;
            bool STU_ID = This_Student_Info_Already_Exist(query, "Tota_Student_ID");

            query = "SELECT COUNT(students.Email) AS Total_Student_Email from students WHERE students.Email = '" + email + "'";
            bool STU_EMAIL = This_Student_Info_Already_Exist(query, "Total_Student_Email");

            query = "SELECT COUNT(students.Phone_No) AS Total_Student_Phone_No from students WHERE students.Phone_No=" + phone;
            bool STU_PHONE = This_Student_Info_Already_Exist(query, "Total_Student_Phone_No");

            if (STU_ID == true && STU_EMAIL == true && STU_PHONE == true)
            {
                MessageBox.Show("This Student ID, E-mail & Phone Number Already Exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(STU_ID == true)
            {
                MessageBox.Show("Student ID: "+ stu_id +" Already Exist.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (STU_EMAIL == true)
            {
                MessageBox.Show("Student E-mail: " + email + " Already Exist.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (STU_PHONE == true)
            {
                MessageBox.Show("Student Phone No: " + phone + " Already Exist.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }
        public bool This_Student_Info_Already_Exist(string query, string Attribute_Name)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();

            MySqlCommand command = new MySqlCommand(query, connect);
            MySqlDataReader dataReader = command.ExecuteReader();

            try
            {
                while (dataReader.Read())
                {
                }

                int total_Stu = Convert.ToInt32(dataReader.GetString(Attribute_Name));
                if (total_Stu > 0)
                {
                    connect.Close();
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connect.Close();
            return false;
        }
    }
}
