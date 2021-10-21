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
        private int Dept_ID;
        public ManageDept()
        {
            InitializeComponent();
            Dept_ID = 0;
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

        private void AddNewDepart_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();

            string query = "INSERT INTO department(Dept_Name) VALUES(@department_Name)";
            MySqlCommand command = connect.CreateCommand();
            command.CommandText = query;

            string department_name = AddDeptName.Text.Trim();

            if (department_name == string.Empty)
            {
                MessageBox.Show("Please Enter Valid Department Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void EditDepartment_Click(object sender, EventArgs e)
        {
            if (this.Dept_ID != 0)
            {
                MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
                connect.Open();
                string query = "UPDATE department SET Dept_Name=@department_name WHERE ID=@ID";
                MySqlCommand command = connect.CreateCommand();
                command.CommandText = query;


                string department_name = AddDeptName.Text.Trim();

                command.Parameters.AddWithValue("@department_name", department_name);
                command.Parameters.AddWithValue("@ID", Dept_ID);
                command.ExecuteNonQuery();

                connect.Close();
                this.Dept_ID = 0;
                Get_Department_Record();

            }
            else
            {
                MessageBox.Show("Please, Select a Department.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowDeptName_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = -1;  // set default value
        }

        private void ShowDeptName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dept_ID = Convert.ToInt32(ShowDeptName.SelectedRows[0].Cells[0].Value.ToString());
            if(Dept_ID != -1)
            {
                string selected_item = ShowDeptName.SelectedRows[0].Cells[1].Value.ToString();
                AddDeptName.Text = selected_item;
                MessageBox.Show(Convert.ToString(Dept_ID));   // for testing

                Show_Intake(Dept_ID);
            }
            else
            {
                Reset();
                MessageBox.Show("Please, Select Valid Department.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

 

        private void Show_Intake(int Dept_ID)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();

            string query;

            query = "SELECT dept_intake.Intake FROM department, dept_intake WHERE department.ID=dept_intake.Dept_ID and department.ID=" + Convert.ToString(Dept_ID);
            MySqlCommand command = new MySqlCommand(query, connect);

            MySqlDataReader dataReader = command.ExecuteReader();

            DataTable data_table = new DataTable();
            data_table.Load(dataReader);

            Intake.DataSource = data_table;

            connect.Close();
        }


        private void Add_New_Intake_Number_bottom_Click(object sender, EventArgs e)
        {
            string dept_ID = ShowDeptName.SelectedRows[0].Cells[0].Value.ToString();
            if (this.Dept_ID != 0)
            {
               //   int intake_num = Convert.ToInt32(Intake.Text.Trim());

                MessageBox.Show("Dept ID " + dept_ID);  // testing


                MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
                connect.Open();

                string query;

                query = "SELECT COALESCE(MAX(dept_intake.Intake),0 ) as Max_Intake from department, dept_intake WHERE department.ID=dept_intake.Dept_ID and dept_intake.Dept_ID=" + dept_ID;
                MySqlCommand command = new MySqlCommand(query, connect);
                MySqlDataReader dataReader = command.ExecuteReader();


                int Max_intake;
                try
                {

                    while (dataReader.Read())
                    {
                    }

                     Max_intake = dataReader.GetInt32("Max_Intake");
                     Max_intake = Max_intake + 1;

                    Save_New_Intake_To_Database(dept_ID, Max_intake);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                connect.Close();

                Show_Intake(Dept_ID);

            }
            else
            {
                MessageBox.Show("Please, Select a Department.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

          
        }

        private void Save_New_Intake_To_Database(string Dept_ID, int Intake_No)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();

            string query = "INSERT INTO dept_intake (Dept_ID, Intake) VALUES ("+ Dept_ID + ", " + Convert.ToString(Intake_No) + ")";
            MySqlCommand command = connect.CreateCommand();
            command.CommandText = query;

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            connect.Close();
            MessageBox.Show("Intake " + Convert.ToString(Intake_No) + " Create Successfull", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Reset_All_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            AddDeptName.Focus();
            this.Dept_ID = 0;
            Intake.DataSource = null;
            AddDeptName.Clear();
        }

        private void Intake_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Dept_ID = Convert.ToInt32(ShowDeptName.SelectedRows[0].Cells[0].Value.ToString());
            MessageBox.Show("You Select Last Row .Error!");  // for testing
            try
            {
                int Dep_intake = Convert.ToInt32(Intake.SelectedRows[0].Cells[0].Value.ToString());

                MessageBox.Show("You Select Last Row .Error!!!!!!! ");    // for testing
                MessageBox.Show("Dept ID " + Convert.ToString(Dept_ID) + "  Intake " + Convert.ToString(Dep_intake));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please, Select a Valid Intake.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
