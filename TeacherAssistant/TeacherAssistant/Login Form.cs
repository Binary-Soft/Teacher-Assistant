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
    public partial class LoginForm : Form
    {
        public static string INSTRUCTOR_EMAIL = string.Empty;   // Set Intitial Value.
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login_As.Items.Add("Login as Admin");
            login_As.Items.Add("Login as Instructor");
        }

        private void login_As_SelectedIndexChanged(object sender, EventArgs e)
        {
            Email.Text = string.Empty;
            Password.Text = string.Empty;
        }


        private void Login_Click(object sender, EventArgs e)
        {
            string userType, email, pin_code;
            string query1, query2;


            userType = login_As.Text.Trim();
            email = Email.Text.Trim();
            pin_code = Password.Text;

            query1 = "SELECT COUNT(admin.Email) AS Toltal FROM admin WHERE admin.Email='" + email + "' AND admin.Password='" + pin_code + "'";
            query2 = "SELECT COUNT(instructor.Email) AS Toltal FROM instructor WHERE instructor.Email='" + email + "' AND instructor.Password='" + pin_code + "'";
              
            //   Login as Admin
            if (userType == "Login as Admin" && Is_Login(query1) == true)
            {
                 this.Hide();
                Admin_Profile obj = new Admin_Profile();
                obj.ShowDialog();
                //  MessageBox.Show("Logout Successfull.", "Successfull.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_All();
                this.Show();
            }
               // Login as Instructor
            else if (userType == "Login as Instructor" && Is_Login(query2) == true)
            {
                INSTRUCTOR_EMAIL = email;
                if (Is_First_Time_Login(email) == true)
                {
                    Email.Clear();
                    Password.Clear();
                    this.Hide();
                    MessageBox.Show("You Logged in First Time. Please Change Your Password And Add Security Key.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    FirstLoginForm obj = new FirstLoginForm();

                    // obj.Text = "test environment";    // runtime form title change
                    // obj.Refresh();                    //  Refrase the title
                    obj.ShowDialog();
                    Clear_All();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    InstructorProfile obje = new InstructorProfile();
                    obje.ShowDialog();

                    //  MessageBox.Show("Logout Successfull.", "Successfull.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_All();
                    this.Show();
                }
                INSTRUCTOR_EMAIL = string.Empty;
            }
            else
            {
                MessageBox.Show("E-mail or Password is Incorrect, Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }


        private void Clear_All()
        {
            Email.Clear();
            Password.Clear();
        }

        private bool Is_First_Time_Login(string email)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();

            string query = "SELECT COUNT(instructor.Email) AS Email FROM instructor WHERE instructor.Email='" + email + "' and instructor.Security_Key='##'";

            MySqlCommand command = new MySqlCommand(query, connect);
            MySqlDataReader dataReader = command.ExecuteReader();


            try
            {
                while (dataReader.Read())
                {
                }
                int total_email = Convert.ToInt32(dataReader.GetString("Email"));
                if (total_email == 1)
                {
                    connect.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            connect.Close();
            return false;
        }


        public bool Is_Login(string query)
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

                int total = Convert.ToInt32(dataReader.GetString("Toltal"));
                if(total == 1)
                {
                    connect.Close();
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            connect.Close();
            return false;
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            // Password.PasswordChar = '●';
            Password.UseSystemPasswordChar = true;
        }

        private void Show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if(Show_Password.Checked == true)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }

        private void Forget_Password_Click(object sender, EventArgs e)
        {
            string user_type = login_As.Text.Trim();

            if (is_valid(user_type) == true)
            {
                Password.Clear();
                this.Hide();
                RecoveryAccoount obj = new RecoveryAccoount();

                obj.passingusertype = user_type;
                obj.passinguseremail = Email.Text.Trim();

                obj.ShowDialog();
                this.Show();
            }
        }

        private bool is_valid(string user_type)
        {
            if (user_type == String.Empty)
            {
                MessageBox.Show("Pelse Select User Type.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
