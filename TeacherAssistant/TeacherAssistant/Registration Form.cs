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
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Name : " + Get_Full_Name.Text);
            Console.WriteLine("E-mail: " + Get_Email.Text);
            Console.WriteLine("Password : " + Get_Password.Text);
            Console.WriteLine("Confirm Password : " + Get_Comfirm_Password.Text);
            MessageBox.Show("Successfull");
        }
    }
}
