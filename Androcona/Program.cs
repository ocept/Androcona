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
        public static System.Collections.ObjectModel.ObservableCollection<Alarm> timeEvents = new System.Collections.ObjectModel.ObservableCollection<Alarm>();
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();

            ApplicationContext trayContext = new trayApplicationContext(); //master controller for program
            Application.Run(trayContext);
        }
    }
    public class trayApplicationContext: ApplicationContext
    {
        static private ContextMenuStrip contextMenu = new ContextMenuStrip();
        private MainForm mainForm;
        public trayApplicationContext()
        {
            contextMenu.Items.Add("List Alarms", null, contextMenuListAlarms);
            contextMenu.Items.Add("Set new alarm", null, contextMenuNewAlarm);
            contextMenu.Items.Add(new ToolStripSeparator());
            contextMenu.Items.Add("Quit", null, contextMenuQuit);
            trayIcon.DoubleClick += new EventHandler(trayIcon_DoubleClick);
        }

        private NotifyIcon trayIcon = new NotifyIcon(new System.ComponentModel.Container())
            {
                ContextMenuStrip = contextMenu,
                Text = "Androcona",
                Icon = new System.Drawing.Icon("testIcon.ico"),
                Visible = true
            };
        private void contextMenuListAlarms(object sender, EventArgs e)
        {
            launchMainForm();
        }

        private void contextMenuNewAlarm(object sender, EventArgs e)
        {
            NewTimeEvent newAlarm = new NewTimeEvent();
            newAlarm.Show();
        }

        private void contextMenuQuit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            launchMainForm();
        }
        private void launchMainForm() //launches form if not already open
        {
            if (mainForm == null)
            {
                mainForm = new MainForm();
                mainForm.Show();
                mainForm.FormClosed += new FormClosedEventHandler(mainForm_FormClosed); //make form null when closed
            }
            else mainForm.Activate();
        }
        void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm = null;
        }
    }
}
