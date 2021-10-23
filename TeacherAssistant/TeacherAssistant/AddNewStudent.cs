﻿using System;
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
            Get_Department_Record();
            Student_Name.Focus();
        }

        private void Get_Department_Record()
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();

            string query = "SELECT DISTINCT department.Dept_Name as Department FROM department, dept_intake_section " +
                "WHERE department.ID=dept_intake_section.Dept_ID";
            

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
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            connect.Close();
        }


        private void Show_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            string department_name= Show_Department.Text.Trim();
            Show_Intake.Items.Clear();
            Show_Section.Items.Clear();
            MessageBox.Show(department_name);   // for testing
            if(department_name == string.Empty)
            {
                MessageBox.Show("Please Select A Department.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
                connect.Open();

                string query = "SELECT DISTINCT dept_intake_section.Intake AS Intake FROM department, dept_intake_section " +
                    "WHERE department.Dept_Name='" + department_name + "' and department.ID=dept_intake_section.Dept_ID";


                try
                {
                    MySqlCommand command = new MySqlCommand(query, connect);
                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Show_Intake.Items.Add(dataReader.GetString("Intake"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                connect.Close();
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
                MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
                connect.Open();

                string query = "SELECT dept_intake_section.Section " +
                    "FROM department, dept_intake, dept_intake_section " +
                    "WHERE department.ID=dept_intake.Dept_ID AND department.ID=dept_intake_section.Dept_ID " +
                    "AND department.Dept_Name='" + department_name + "' AND dept_intake.Intake=dept_intake_section.Intake " +
                    "AND dept_intake.Intake=" + intake;


                try
                {
                    MySqlCommand command = new MySqlCommand(query, connect);
                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Show_Section.Items.Add(dataReader.GetString("Section"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                connect.Close();
            }
        }

        private void Subbit_Student_Info_Click(object sender, EventArgs e)
        {
            string name = Student_Name.Text.Trim();
            string stu_id = Student_ID.Text.Trim();
            string semester = Semester_No.Text.Trim();
            string email = Email.Text.Trim();
            string department_name = Show_Department.Text.Trim();
            string intake = Show_Intake.Text.Trim();
            string section = Show_Section.Text.Trim();
            string phone = Phone_No.Text.Trim();
            string address = Address.Text.Trim();
            string year = Year.Text.Trim();

            if(is_Valid(name, stu_id, semester, email, department_name, intake, section, phone, address, year) == true)
            {
                MessageBox.Show(name + stu_id + semester + email + department_name + intake + section + phone + address + year);
            }
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

            return true;
        }
    }
}