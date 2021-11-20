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
        private int Dept_ID, intake_no;
        public ManageDept()
        {
            InitializeComponent();
            this.Dept_ID = 0;
            this.intake_no = 0;
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
                MessageBox.Show("Please Enter Valid Department Name.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                
                try
                {
                    command.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                connect.Close();
                Reset();
                Get_Department_Record();

            }
            else
            {
                MessageBox.Show("Please, Select A Department.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowDeptName_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = -1;  // set default value
        }
        private void Intake_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = -1;  // set default value
        }

        private void ShowDeptName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Dept_ID = Convert.ToInt32(ShowDeptName.SelectedRows[0].Cells[0].Value.ToString());
                if (this.Dept_ID != -1)
                {
                    string selected_item = ShowDeptName.SelectedRows[0].Cells[1].Value.ToString();
                    AddDeptName.Text = selected_item;

                    Show_Intake(Dept_ID);   
                }
                else
                {
                    Reset();
                    MessageBox.Show("Please, Select Valid Department.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please, Enter A Department.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Reset();
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
            Show_Section_No.Items.Clear();
            this.intake_no = 0;
            if (this.Dept_ID != 0)
            {
                string dept_ID = ShowDeptName.SelectedRows[0].Cells[0].Value.ToString();
                MessageBox.Show("Dept ID " + dept_ID);  // testing


                MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
                connect.Open();

                string query;

                query = "SELECT COALESCE(MAX(dept_intake.Intake), 0) as Max_Intake from department, dept_intake WHERE department.ID=dept_intake.Dept_ID and dept_intake.Dept_ID=" + dept_ID;
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
                MessageBox.Show("Please, Select A Department.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void Save_New_Intake_To_Database(string Dept_ID, int Intake_No)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();

            string query = "INSERT INTO dept_intake (Dept_ID, Intake) VALUES (" + Dept_ID + ", " + Convert.ToString(Intake_No) + ")";
            MySqlCommand command = connect.CreateCommand();
            command.CommandText = query;

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            this.intake_no = 0;
            Intake.DataSource = null;
            AddDeptName.Clear();
            Show_Section_No.Items.Clear();
            Show_Section_No.Items.Add(" ");
        }

        private void Intake_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.Dept_ID != 0)
            {
                int Dept_ID = Convert.ToInt32(ShowDeptName.SelectedRows[0].Cells[0].Value.ToString());
                int Dep_intake = Convert.ToInt32(Intake.SelectedRows[0].Cells[0].Value.ToString());
                if (Dep_intake != -1)
                {
                    this.intake_no = Dep_intake;
                    Show_Section_No.Items.Clear();
                    Display_Section_No(Dept_ID, Dep_intake);
                }
                else if (Dep_intake == -1)
                {
                    MessageBox.Show("Please, Select A Valid Intake.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Show_Intake(Dept_ID);
                }
            }
            else
            {
                MessageBox.Show("Please, Select A Department Name.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void Display_Section_No(int Dept_ID, int Dep_intake)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();
            string query = "SELECT dept_intake_section.Section as Section FROM dept_intake_section WHERE dept_intake_section.Dept_ID=" + Convert.ToString(Dept_ID) + " and dept_intake_section.Intake=" + Convert.ToString(Dep_intake);
            
            try
            {
                MySqlCommand command = new MySqlCommand(query, connect);
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Show_Section_No.Items.Add(dataReader.GetString("Section"));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            connect.Close();
        }

        private void Add_New_Section_Click(object sender, EventArgs e)
        {
            if(this.Dept_ID == 0)
            {
                MessageBox.Show("Please, Select A Department.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(this.intake_no == 0)
            {
                MessageBox.Show("Please, Select A Section.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string dept_ID = ShowDeptName.SelectedRows[0].Cells[0].Value.ToString();
                string dept_Intake = Intake.SelectedRows[0].Cells[0].Value.ToString();
                MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
                connect.Open();

                string query = "SELECT COALESCE(MAX(dept_intake_section.Section), 0) as Max_Section FROM dept_intake_section WHERE dept_intake_section.Dept_ID=" + dept_ID + " and dept_intake_section.Intake=" + dept_Intake;

                

                int Section;
                try
                {
                    MySqlCommand command = new MySqlCommand(query, connect);
                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                    }

                    Section = dataReader.GetInt32("Max_Section");
                    Section = Section + 1;
                    Save_New_Section_To_Database(dept_ID, dept_Intake, Convert.ToString(Section));

                    Show_Section_No.Items.Clear();
                    Display_Section_No(Convert.ToInt32(dept_ID), Convert.ToInt32(dept_Intake));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

                connect.Close();
            }
            
        }

        private void Save_New_Section_To_Database(string dept_ID, string dept_Intake, string Section)
        {
            MySqlConnection connect = new MySqlConnection(DataBase.Connect_String());
            connect.Open();

            try
            {
                string query = "INSERT INTO dept_intake_section (Dept_ID, Intake, Section) VALUES (" + dept_ID + "," + dept_Intake + ", " + Section + ")";
                MySqlCommand command = new MySqlCommand(query, connect);

                command = connect.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("Section : " + Section + " Added Successfully.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.intake_no = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            connect.Close();
        }


        private void Back_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Confirm?", "Close this Window.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

