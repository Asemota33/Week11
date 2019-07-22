using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week11
{
    public static class Program
    {
        public static MainForm mainform;
        public static StartForm startform;
        public static aboutForm aboutBox;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            startform = new StartForm();
            mainform = new MainForm();
            aboutBox = new aboutForm();
            Application.Run(new StartForm());
        }
    }
}
