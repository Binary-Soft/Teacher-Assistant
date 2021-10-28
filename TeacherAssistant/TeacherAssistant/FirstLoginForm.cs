using System;
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
    public partial class FirstLoginForm : Form
    {
        public FirstLoginForm()
        {
            InitializeComponent();
        }

        private void Instructor_Password_Change_Click(object sender, EventArgs e)
        {
            string ins_password = Instructor_New_Password.Text;
            string ins_confirm_password = Instructor_Confirm_Password.Text;
            string ins_security_key = Instructor_New_Security_Key.Text;
            string ins_confirm_security_key = Instructor_confirm_Security_Key.Text;

            if (Ins_Password_Security_key_is_valid(ins_password, ins_confirm_password, ins_security_key, ins_confirm_security_key) == true)
            {
                string query = "UPDATE instructor SET instructor.Password='" + ins_password + "' , instructor.Security_Key='" + ins_security_key + "' WHERE instructor.Email='" + Form1.INSTRUCTOR_EMAIL + "'";
                if (Update_Instructor_Password_Security_Key(query) == true)
                {
                    MessageBox.Show("Password And Security Key Change Successfully. Now Login Again", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();   // Now Close This Window
                }
                else
                {
                    MessageBox.Show("Informathon Update Failed, Please Try Again.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private bool Update_Instructor_Password_Security_Key(string query)
        {

            AddNewStudent obj = new AddNewStudent();     //  =====>> From AddNewStudent.cs file   <<=====

            return obj.Student_Info_Save_To_Database(query);   // <<==== this function exist AddNewStudent.cs file  
        }

        private bool Ins_Password_Security_key_is_valid(string ins_password, string ins_confirm_password, string ins_security_key, string ins_confirm_security_key)
        {
            if (ins_password == string.Empty)
            {
                MessageBox.Show("Please Enter a Password.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Instructor_New_Password.Focus();
                return false;
            }
            else if (ins_confirm_password == string.Empty)
            {
                MessageBox.Show("Please Enter a Confirm Password.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Instructor_Confirm_Password.Focus();
                return false;
            }
            else if (ins_security_key == string.Empty)
            {
                MessageBox.Show("Please Enter a Security Key.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Instructor_New_Security_Key.Focus();
                return false;
            }
            else if (ins_confirm_security_key == string.Empty)
            {
                MessageBox.Show("Please Enter Confirm Security Key.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Instructor_New_Security_Key.Focus();
                return false;
            }
            else if (ins_password != ins_confirm_password)
            {
                MessageBox.Show("Password Does Not Match.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Instructor_New_Password.Focus();
                return false;
            }
            if (ins_security_key != ins_confirm_security_key)
            {
                MessageBox.Show("Security Key Does Not Match.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Instructor_New_Security_Key.Focus();
                return false;
            }


            return true;
        }
    }
}
