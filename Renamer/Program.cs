﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Renamer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			//Test
			//changes on ver1 branch.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain( ));
        }
    }
}
