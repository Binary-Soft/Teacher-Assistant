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
    public partial class RecoveryAccoount : Form
    {
        private string USER_TYPE = string.Empty;
        private string USER_EMAIL = string.Empty;
        public RecoveryAccoount()
        {
            InitializeComponent();
        }

        public string passinguseremail
        {
            set { USER_EMAIL = value; }
            get
            { return USER_EMAIL; }
        }

        public string passingusertype
        {
            set { USER_TYPE = value; }
            get{ return USER_TYPE; }
        }
        private void RecoveryAccoount_Load(object sender, EventArgs e)
        {
            Get_Email.Text = USER_EMAIL;
        }


        private void Submit_Click(object sender, EventArgs e)
        {
            string email = Get_Email.Text.Trim();
            string security_key = Get_Security_Key.Text.Trim();

            if(is_valid(email, security_key) == true)
            {
                string query1, query2;

                query1 = "SELECT COUNT(admin.Admin_ID) AS Toltal from admin WHERE admin.Email='"+ email +"' AND admin.Security_Key='"+ security_key + "'";
                query2 = "SELECT COUNT(instructor.Ins_ID) AS Toltal from instructor WHERE instructor.Email='"+ email +"' AND instructor.Security_Key='" + security_key + "'";
                LoginForm obj = new LoginForm();

                Change_Password_Form obj2 = new Change_Password_Form();

                if (USER_TYPE == "Login as Admin" && obj.Is_Login(query1) == true)
                {
                    this.Hide();
                    obj2.passingUserType = USER_TYPE;
                    obj2.passingUserEmaail = USER_EMAIL;

                    obj2.ShowDialog();
                    this.Close();
                }
                else if(USER_TYPE == "Login as Instructor" && obj.Is_Login(query2) == true)
                {
                    this.Hide();
                    obj2.passingUserType = USER_TYPE;
                    obj2.passingUserEmaail = USER_EMAIL;

                    obj2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("E-mail or Security Key is Incorrect, Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }

        }

        private bool is_valid(string email, string security_key)
        {
            if(email == string.Empty)
            {
                MessageBox.Show("Pelse Enter Your Email.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Get_Email.Focus();
                return false;
            }
            else if(security_key == string.Empty)
            {
                MessageBox.Show("Pelse Enter Your Security Key.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Get_Security_Key.Focus();
                return false;
            }

            return true;
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
