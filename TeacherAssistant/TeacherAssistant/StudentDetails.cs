﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherAssistant
{
    public partial class StudentDetails : Form
    {
        private string STUDENT_ID = string.Empty;
        private string STUDENT_NAME = string.Empty;
        private string STUDENT_INTAKE = string.Empty;
        private string COURSE_ID = string.Empty;
        private string STU_Phone_NO = string.Empty;
        private string STUDENT_ADDRESS = string.Empty;
        private string STUDENT_EMAIL = string.Empty;
        private string TOTAL_CLASS = string.Empty;

        public string PassingStudentID
        {
            set { STUDENT_ID = value; }
            get { return STUDENT_ID; }
        }
        public string PassingStudentName
        {
            set { STUDENT_NAME = value; }
            get { return STUDENT_NAME; }
        }
        public string PassingCourseID
        {
            set { COURSE_ID = value; }
            get { return COURSE_ID; }
        }
        public string PassingIntake
        {
            set { STUDENT_INTAKE = value; }
            get { return STUDENT_INTAKE; }
        }
        public string PassinStudentPhoneNo
        {
            set { STU_Phone_NO = value; }
            get { return STU_Phone_NO; }
        }
        public string PassinStudentAddress
        {
            set { STUDENT_ADDRESS = value; }
            get { return STUDENT_ADDRESS; }
        }
        public string PassinStudentEmail
        {
            set { STUDENT_EMAIL = value; }
            get { return STUDENT_EMAIL; }
        }
        public string PassingTotalClass
        {
            set { TOTAL_CLASS = value; }
            get { return TOTAL_CLASS; }
        }

        public StudentDetails()
        {
            InitializeComponent();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            Show_Student_Details();
        }

        private void Show_Student_Details()
        {
            Show_Student_Name.Text = STUDENT_NAME;
            Show_Student_ID.Text = STUDENT_ID;
            Show_Student_Email.Text = STUDENT_EMAIL;
            Show_Phone_No.Text = STU_Phone_NO;
            Show_Student_Address.Text = STUDENT_ADDRESS;
            Show_Total_Mark.Text = string.Empty;
            Show_Attendance_Percentage.Text = Convert.ToString(Get_Attendance_Percentage(STUDENT_ID, COURSE_ID)) + '%';

        }

        private int Get_Total_Attendance(string Student_Id, string Courde_Id)
        {
            string query = "SELECT COUNT(attendance.Present_Or_Not) AS 'Instructor_ID' FROM attendance " +
                "WHERE attendance.Student_ID='" + Student_Id + "' AND attendance.Course_ID='" + Courde_Id + "'";

            InstructorProfile obj = new InstructorProfile();

            int Total_atten = Convert.ToInt32(obj.Get_Instructor_ID(query));

            return Total_atten;
        }

        private double Get_Attendance_Percentage(string Student_Id, string Courde_Id)
        {
            int total_attendance = Get_Total_Attendance(Student_Id, Courde_Id);
                                                

            double attendance_Percentage = (total_attendance * 100) / Convert.ToInt32(TOTAL_CLASS) * 1.0;

            return attendance_Percentage;
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
