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
          //  login_As.Items.Add("Login as Instructor");
        }


        private void Login_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();
            MessageBox.Show("Connected");


            string userType;
            string email, pin_code, query, Data_Base_Email , Data_Base_Password;


            userType = login_As.Text.Trim();
            email = Email.Text.Trim();
            pin_code = Password.Text;


           // query = "SELECT * FROM admin WHERE Email='" + email + "' AND Password='" + pin_code + "'";
           query = "SELECT * FROM admin";
           MySqlCommand command = new MySqlCommand(query, connect);
           MySqlDataReader dataReader = command.ExecuteReader();


            /*
                    // use this comment section or use "MySqlDataReader" =>> line-52 
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

                Data_Base_Email = dataReader.GetString("Email");
                Data_Base_Password = dataReader.GetString("Password");

                //   Login as Admin
                if (userType == "Login as Admin" && (email == Data_Base_Email && pin_code == Data_Base_Password))
                {
                   // this.Hide();
                    MessageBox.Show("Admin Login");
                    Admin_Profile obj = new Admin_Profile();
                    obj.ShowDialog();

                }
                else if (userType == "Login as Instructor")
                {
                    MessageBox.Show("Instructor");
                }
                else
                {
                    MessageBox.Show("E-mail or Password is Incorrect, Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connect.Close();
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
