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
    public partial class InstructorProfile : Form
    {
        public InstructorProfile()
        {
            InitializeComponent();
        }

        private void InstructorProfile_Load(object sender, EventArgs e)
        {
            Temp_Instructor_Email.Text = Form1.INSTRUCTOR_EMAIL;
        }
    }
}
