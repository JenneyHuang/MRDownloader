﻿using System;
using System.Windows.Forms;


namespace MROFtpDownloader
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Form1 f1 = new Form1();
            Application.Run(f1);

            
        }
    }
}