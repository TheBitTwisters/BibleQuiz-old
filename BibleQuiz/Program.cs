﻿using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibleQuiz
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new frmSplashScreen().Show();
            Application.Run();
        }
    }
}
