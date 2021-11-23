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
    public partial class Change_Password_Form : Form
    {
        private string USER_TYPE = string.Empty;
        private string USER_EMAIL = string.Empty;
        public Change_Password_Form()
        {
            InitializeComponent();
        }

        public string passingUserEmaail
        {
            set { USER_EMAIL = value; }
            get
            { return USER_EMAIL; }
        }

        public string passingUserType
        {
            set { USER_TYPE = value; }
            get { return USER_TYPE; }
        }

        private void Save_Change_Click(object sender, EventArgs e)
        {
            string new_password = Get_Password.Text.Trim();
            string confirm_password = Get_Comfirm_Password.Text.Trim();

            if (is_valid(new_password, confirm_password) == true)
            {

                if (USER_TYPE == "Login as Admin" && Change_Password("UPDATE admin SET admin.Password='"+ new_password +"' WHERE admin.Email='"+ USER_EMAIL + "'") == true)
                {
                    MessageBox.Show("Password Change Successfully. Now Login Again", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();   // Now Close This Window
                }
                else if(USER_TYPE == "Login as Instructor" && Change_Password("UPDATE instructor SET instructor.Password='" + new_password + "' WHERE instructor.Email='" + USER_EMAIL + "'") == true)
                {
                    MessageBox.Show("Password Change Successfully. Now Login Again", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();   // Now Close This Window
                }
            }
        }

        private bool Change_Password(string query)
        {
            AddNewStudent obj = new AddNewStudent();     //  =====>> From AddNewStudent.cs file   <<=====

            bool check = obj.Student_Info_Save_To_Database(query);   // <<==== this function exist AddNewStudent.cs file 

            return check;
        }

        private bool is_valid(string new_password, string confirm_password)
        {
            if (new_password == string.Empty)
            {
                MessageBox.Show("Enter a New Password.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Get_Password.Focus();
                return false;
            }
            else if(confirm_password == string.Empty)
            {
                MessageBox.Show("Enter Confirm Password.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Get_Comfirm_Password.Focus();
                return false;
            }
            else if(new_password != confirm_password)
            {
                MessageBox.Show("Password Does Not Match.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Get_Password.Focus();
                return false;
            }

            return true;
        }


        private void No_Change_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure?", "Leave without Changing Password.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Get_Password_TextChanged(object sender, EventArgs e)
        {
            Get_Password.UseSystemPasswordChar = true;
        }

        private void Show_Password_Visible_CheckedChanged(object sender, EventArgs e)
        {

            if (Show_Password_Visible.Checked == true)
            {
                Get_Password.UseSystemPasswordChar = false;
            }
            else
            {
                Get_Password.UseSystemPasswordChar = true;
            }
        }

        private void Confirm_Password_Visible_CheckedChanged(object sender, EventArgs e)
        {
            if (Confirm_Password_Visible.Checked == true)
            {
                Get_Comfirm_Password.UseSystemPasswordChar = false;
            }
            else
            {
                Get_Comfirm_Password.UseSystemPasswordChar = true;
            }
        }

        private void Get_Comfirm_Password_TextChanged(object sender, EventArgs e)
        {
            Get_Comfirm_Password.UseSystemPasswordChar = true;
        }
    }  

}
    
