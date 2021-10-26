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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_As_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login_As.Items.Add("Login as Admin");
            login_As.Items.Add("Login as Instructor");
        }


        private void Login_Click(object sender, EventArgs e)
        {
            string userType, email, pin_code;


            userType = login_As.Text.Trim();
            email = Email.Text.Trim();
            pin_code = Password.Text;
 

               //   Login as Admin
            if (userType == "Login as Admin" && Is_Login("Login as Admin", email, pin_code) == true)
            {
                // this.Hide();
                MessageBox.Show("Admin Login");
                Admin_Profile obj = new Admin_Profile();
                obj.ShowDialog();

            }
               // Login as Instructor
            else if (userType == "Login as Instructor" && Is_Login("Login as Instructor", email, pin_code) == true)
            {
                MessageBox.Show("Instructor Login");
            }
            else
            {
                MessageBox.Show("E-mail or Password is Incorrect, Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }


        private bool Is_Login(string userType, string user_email, string user_password)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();
            MessageBox.Show("Connected");

            string query = string.Empty;



            if(userType == "Login as Admin")
            {
                query = "SELECT COUNT(admin.Email) AS Toltal FROM admin WHERE admin.Email='" + user_email + "' AND admin.Password='" + user_password + "'";
            }
            else if(userType == "Login as Instructor")
            {
                query = "SELECT COUNT(instructor.Email) AS Toltal FROM instructor WHERE instructor.Email='" + user_email + "' AND instructor.Password='" + user_password + "'";
            }

            MySqlCommand command = new MySqlCommand(query, connect);
            MySqlDataReader dataReader = command.ExecuteReader();


            /*
                    // use this comment section or use "MySqlDataReader" =>> Line 101
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(command);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);

                  // now get the value from mysql database
            foreach(DataRow datarow in datatable.Rows)
            {
                Console.WriteLine(datarow["email"].ToString().Trim());
                Console.WriteLine(datarow["password"].ToString().Trim());
            }
            */

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


        private void Registration_Click(object sender, EventArgs e)
        {
            Registration_Form obj = new Registration_Form();
            obj.ShowDialog();
        }


        private void Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
