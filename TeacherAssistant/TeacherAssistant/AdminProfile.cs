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
    public partial class Admin_Profile : Form
    {
        public Admin_Profile()
        {
            InitializeComponent();
        }
        private void Admin_Profile_Load(object sender, EventArgs e)
        {

        }

        private void AddDept_Click(object sender, EventArgs e)
        {
            ManageDept obj = new ManageDept();

            obj.ShowDialog();
        }

        private void Add_New_Student_Click(object sender, EventArgs e)
        {
            AddNewStudent obj = new AddNewStudent();

            obj.ShowDialog();
        }
    }
}
