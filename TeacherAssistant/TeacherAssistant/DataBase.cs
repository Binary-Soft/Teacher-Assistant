using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TeacherAssistant
{
    static class DataBase
    {
        public static string Connect_String()
        {
            string database = "datasource=localhost; username=root; password=; port=3306; sslmode=none;" +
                   "database=teacher_assistant;";

            return database;
        }

    }
}
