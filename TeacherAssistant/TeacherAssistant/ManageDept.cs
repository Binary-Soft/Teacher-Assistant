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
    public partial class ManageDept : Form
    {
        private int ID;
        public ManageDept()
        {
            InitializeComponent();
            ID = 0;
        }

        private void ManageDept_Load(object sender, EventArgs e)
        {
            Get_Department_Record();
        }

        private void Get_Department_Record()
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();

            string query = "SELECT ID, Dept_Name FROM department";
            MySqlCommand command = new MySqlCommand(query, connect);
            MySqlDataReader dataReader = command.ExecuteReader();

            DataTable data_table = new DataTable();
            data_table.Load(dataReader);


            ShowDeptName.DataSource = data_table;

            
            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();

            string query = "INSERT INTO department(Dept_Name) VALUES(@department_Name)";
            MySqlCommand command = connect.CreateCommand();
            command.CommandText = query;

            string department_name = AddDeptName.Text.Trim();

            if (department_name == "")
            {
                MessageBox.Show("Please Enter Valid Department Name.");
            }
            else
            { 
                command.Parameters.AddWithValue("@department_Name", department_name);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }


            connect.Close();
            AddDeptName.Clear();
            Get_Department_Record();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(this.ID != 0)
            {
                MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
                connect.Open();
                string query = "UPDATE department SET Dept_Name=@department_name WHERE ID=@ID";
                MySqlCommand command = connect.CreateCommand();
                command.CommandText = query;


                string department_name = AddDeptName.Text.Trim();

                command.Parameters.AddWithValue("@department_name", department_name);
                command.Parameters.AddWithValue("@ID", ID);
                command.ExecuteNonQuery();

                connect.Close();
                this.ID = 0;
                Get_Department_Record();
                
            }
            else
            {
                MessageBox.Show("Please, select a Department.");
            }

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(ShowDeptName.SelectedRows[0].Cells[0].Value.ToString());
            string selected_item = ShowDeptName.SelectedRows[0].Cells[1].Value.ToString();
            AddDeptName.Text = selected_item;
            MessageBox.Show(Convert.ToString(ID));



        }

        private void Intake_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
