using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week11
{
    public static class Program
    {
        public static StudentClass student;
        public static StartForm startForm;
        public static MainForm mainForm;
        public static aboutForm aboutBox;
        public static StudentInfoForm studentInfoForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            student = new StudentClass();
            startForm = new StartForm();
            mainForm = new MainForm();
            aboutBox = new aboutForm();
            studentInfoForm = new StudentInfoForm();
            Application.Run(startForm);
        }
    }
}
