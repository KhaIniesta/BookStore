﻿using BookStore.Forms;
using System;
using System.Windows.Forms;

namespace BookStore
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form_Login());
            //Application.Run(new Form_Admin());
            //Application.Run(new Form_Cashier());
            Application.Run(new Form_SM());
        }
    }
}
