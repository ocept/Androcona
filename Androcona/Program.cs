using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Androcona
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>   
        public static List<Alarm> timeEvents = new List<Alarm>();
        public static MainForm TheMainForm = new MainForm();
        [STAThread]
        static void Main()
        {
            NotifyIcon trayIcon = new NotifyIcon(new System.ComponentModel.Container())
            {
                ContextMenuStrip = new ContextMenuStrip(),
                Text = "Androcona",
                Icon = new System.Drawing.Icon("testIcon.ico"),
                Visible = true             
            };

            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(TheMainForm);
        }
    }
}
