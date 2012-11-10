using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Androcona
{
    class Alarm
    {
        protected AlarmSettings alarmSettings;
        protected System.Timers.Timer eTimer;
        public Alarm(AlarmSettings settings)
        {
            alarmSettings = settings;
            alarmInit();
        }
        protected virtual void alarmInit()
        {
            try
            {
                eTimer = new System.Timers.Timer(alarmSettings.time.Subtract(DateTime.Now).TotalMilliseconds / 5);
                eTimer.Elapsed += new System.Timers.ElapsedEventHandler(eTimer_Elapsed);
                eTimer.AutoReset = false;
                eTimer.Start();
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("AlarmInit: invalid time input");
                return; //invalid time input
            }
        }

        public string[] toStringArray()
        {
            List<String> outLines = new List<string>();
            outLines.Add("BEGIN save");
            outLines.Add("type=" + alarmSettings.type);
            outLines.Add("time=" + alarmSettings.time.ToBinary().ToString());
            outLines.Add("description=" + alarmSettings.description);
            outLines.Add("notifyMessageBox=" + alarmSettings.notifyMessageBox.ToString());
            outLines.Add("END");

            return outLines.ToArray();
        }

        public DateTime AlarmTime { get { return alarmSettings.time; } set{} }
        protected virtual void eTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            
            if (alarmSettings.notifyMessageBox) notifyMessageBox();
        }

        private void notifyMessageBox()
        {
            System.Windows.Forms.MessageBox.Show("Alarm triggered:" + alarmSettings.description + " " + alarmSettings.time, "Alarm");
        }

    }
    class Chime : Alarm
    {
        public Chime(AlarmSettings settings) : base(settings)
        {

        }
        protected override void alarmInit()
        {
            base.alarmInit();
            eTimer.AutoReset = true;
        }
        protected override void eTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            base.eTimer_Elapsed(sender, e);
            if (DateTime.Now.Add(alarmSettings.chimeInterval).CompareTo(alarmSettings.chimeEndTime) > 0)
            {
                eTimer.Stop();
            }
        }
    }
}
