using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of TeacherSubjectManager
            string connectionString = "Server=localhost; Port=3306; Database=lb7db; Uid=root; Pwd=rootpassword;";

            var manager = new TeacherSubjectManager(connectionString);

            // Pass the manager instance to the MainForm constructor
            Application.Run(new MainForm(manager));
        }
    }
}
