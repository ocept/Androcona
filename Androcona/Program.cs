using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

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

            loadAlarms.readAlarms();

            ApplicationContext trayContext = new trayApplicationContext(); //master controller for program
            Application.Run(trayContext);
            
        }
    }
    public static class loadAlarms
    {
        static char[] nameValueSeparators = new char[] { '=', ':'};
        public static void readAlarms()
        {
            string alarmFile = Directory.GetCurrentDirectory() + @"\alarms.txt";
            if (File.Exists(alarmFile))
            {
                string[] fileLines = File.ReadAllLines(alarmFile);
                parseSaves(fileLines);
            }
        }
        private static void parseSaves(string[] fileLines)
        {
            for(int i = 0; i < fileLines.Length; i++)
            {
                if (fileLines[i] == "BEGIN save")
                    parseSave(fileLines, i);
            }

        }
        private static void parseSave(string[] fileLines, int n) //TODO: exception handling, validation
        {
            AlarmSettings a = new AlarmSettings();
            for (int i = n+1; i < fileLines.Length; i++) //parse each line, ignoring BEGIN
            {
                if (fileLines[i] == "END") break; //end of save
                string[] split = fileLines[i].Split(nameValueSeparators, 2);
                switch (split[0])
                {
                    case "type":
                        a.type = (AlarmSettings.aType) Enum.Parse(typeof(AlarmSettings.aType), split[1]);
                        break;
                    case "time":
                        a.time = DateTime.FromBinary(long.Parse(split[1]));
                        break;
                    case "description":
                        a.description = split[1];
                        break;
                    case "notifyMessageBox":
                        a.notifyMessageBox = bool.Parse(split[1]);
                        break;
                    default:
                        break;
                }
            }
            Program.timeEvents.Add(new Alarm(a));
        }
    }
    public static class saveAlarms
    {
        public static void writeAlarms()
        {
            string alarmFile = Directory.GetCurrentDirectory()+@"\alarms.txt";
            List<String> alarmLines = new List<string>();
            foreach (Alarm a in Program.timeEvents)
            {
                alarmLines.AddRange(a.toStringArray());
                
            }
            File.WriteAllLines(alarmFile, alarmLines.ToArray());
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
