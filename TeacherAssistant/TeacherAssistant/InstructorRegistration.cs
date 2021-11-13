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
    public partial class InstructorRegistration : Form
    {
        public InstructorRegistration()
        {
            InitializeComponent();
        }
        private void InstructorRegistration_Load(object sender, EventArgs e)
        {
            Instructor_Name.Focus();
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
        }


        private void Submit_Instructor_Info_Click(object sender, EventArgs e)
        {
            string Ins_Name, Ins_ID, Ins_Email, Ins_Dept, Ins_Phone, Ins_Password, Ins_Confirm_Password;


            Ins_Name = Instructor_Name.Text.Trim();
            Ins_ID = Instructor_ID.Text.Trim();
            Ins_Email = Instructor_Email.Text.Trim();
            Ins_Dept = Show_Department.Text.Trim();
            Ins_Phone = Instructor_Phone_No.Text.Trim();
            Ins_Password = Password1.Text.Trim();
            Ins_Confirm_Password = Password2.Text.Trim();
            MessageBox.Show(Ins_Name + "  " + Ins_ID + "  " + Ins_Email + "  " + Ins_Dept + "  " + Ins_Phone + "  " + Ins_Password + "  " + Ins_Confirm_Password);

            if (is_Valid(Ins_Name, Ins_ID, Ins_Email, Ins_Dept, Ins_Phone, Ins_Password, Ins_Confirm_Password) == true)
            {

                AddNewStudent obj = new AddNewStudent();  //  //  =====>> From AddNewStudent.cs file   <<=====

                string query1 = "SELECT department.ID As Dept_ID FROM department WHERE department.Dept_Name='" + Ins_Dept + "'";
                string Dept_ID = obj.Get_Department_ID(query1);   // <<==== this function exist AddNewStudent.cs file  

                string query2 = "INSERT INTO instructor (`Ins_ID`, `Email`, `Phone_No`, `Name`, `Dept_ID`, `Password`, `Security_Key`)" +
                    "VALUES ('" + Ins_ID + "', '" + Ins_Email + "', '" + Ins_Phone + "', '" + Ins_Name + "', '" + Dept_ID + "', '" + Ins_Password + "', '##');";
                  
                if (obj.Student_Info_Save_To_Database(query2) == true)  // <<==== this function exist AddNewStudent.cs file 
                {
                    MessageBox.Show("Save Successfully.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_All();
                }
                else
                {
                    MessageBox.Show("Information Save Failed. Please Try Again.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void Clear_All()
        {
            Instructor_Name.Clear();
            Instructor_ID.Clear();
            Instructor_Email.Clear();
            Instructor_Phone_No.Clear();
            Password1.Clear();
            Password2.Clear();
        }

        private bool is_Valid(string name, string Ins_id, string email, string department_name, string phone, string Password, string Confirm_Password)
        {

            if (name == string.Empty)
            {
                MessageBox.Show("Please Enter Instructor Name.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Instructor_Name.Focus();
                return false;
            }
            else if (Ins_id == string.Empty)
            {
                MessageBox.Show("Please Enter Instructor ID.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Instructor_ID.Focus();
                return false;
            }
            else if (email == string.Empty)
            {
                MessageBox.Show("Please Enter Instructor E-mail.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Instructor_Email.Focus();
                return false;
            }
            else if (department_name == string.Empty)
            {
                MessageBox.Show("Please Select Department Name.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (phone == string.Empty)
            {
                MessageBox.Show("Please Enter Instructor Phone No.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Instructor_Phone_No.Focus();
                return false;
            }
            else if (Password == string.Empty)
            {
                MessageBox.Show("Please Enter Password.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Password1.Focus();
                return false;
            }
            else if (Confirm_Password == string.Empty)
            {
                MessageBox.Show("Please Enter Confirm Password.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Password2.Focus();
                return false;
            }
            else if (Password != Confirm_Password)
            {
                MessageBox.Show("Password Does Not Match!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Password1.Focus();
                return false;
            }
            else if(Ins_id != string.Empty && email != string.Empty && phone != string.Empty)
            {
                if(Instructor_ID_Email_PhoneNo_Is_Unique(Ins_id, email, phone) == false)
                {
                    return false;
                }
            }


            return true;
        }

        private bool Instructor_ID_Email_PhoneNo_Is_Unique(string Ins_id, string email, string phone)
        {
            AddNewStudent obj = new AddNewStudent();   //  =====>> From AddNewStudent.cs file   <<=====

            string query = "SELECT COUNT(instructor.Ins_ID) AS Total_INS_ID FROM instructor WHERE instructor.Ins_ID=" + Ins_id;
            bool INS_ID = obj.This_Student_Info_Already_Exist(query, "Total_INS_ID");  // <<==== this function exist AddNewStudent.cs file 

            query = "SELECT COUNT(instructor.Email) AS Total_INS_Email FROM instructor WHERE instructor.Email='" + email + "'";
            bool INS_EMAIL = obj.This_Student_Info_Already_Exist(query, "Total_INS_Email");   // <<==== this function exist AddNewStudent.cs file 

            query = "SELECT COUNT(instructor.Phone_No) AS Total_INS_Phone FROM instructor WHERE instructor.Phone_No=" + phone;
            bool INS_PHONE = obj.This_Student_Info_Already_Exist(query, "Total_INS_Phone"); // <<==== this function exist AddNewStudent.cs file 

            if (INS_ID == true && INS_EMAIL == true && INS_PHONE == true)
            {
                MessageBox.Show("Instructor ID, E-mail & Phone Number Already Used.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (INS_ID == true)
            {
                MessageBox.Show("Instructor ID: " + Ins_id + " Already Used.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (INS_EMAIL == true)
            {
                MessageBox.Show("Instructor E-mail: " + email + " Already Used.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (INS_PHONE == true)
            {
                MessageBox.Show("Instructor Phone No.: " + phone + " Already Used.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Confirm?", "Close this Window.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }

}