﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandBoxWindowsApp
{
     class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("debugging!!!");
            if (args.Length > 0 && args[0] != string.Empty)
            {
                Console.WriteLine("debugging!!!");
                //var cmdForm = new Form1();
                //cmdForm.cmdManage(args);
                //Environment.Exit(0);
            }
            else {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            
        }





    }
}


