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
        protected virtual int alarmInit()
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
                return 0; //invalid time input
            }
            return 1;
        }

        public virtual string[] toStringArray()
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
        public AlarmSettings.aType AlarmType { get { return alarmSettings.type; } set { } }
        public string AlarmDescription { get { return alarmSettings.description; } set { } }
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
        protected override int alarmInit()
        {
            if (base.alarmInit() == 1)
            {
                eTimer.AutoReset = true; //timer restarts after triggering
                return 1;
            }
            else
            {
                return 0; //base init failed, exit
            }
        }
        protected override void eTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            base.eTimer_Elapsed(sender, e);
            if (DateTime.Now.Add(alarmSettings.chimeInterval).CompareTo(alarmSettings.chimeEndTime) > 0)
            {
                eTimer.Stop();
            }
        }
        public TimeSpan ChimeInterval { get { return alarmSettings.chimeInterval; } set { } }
        public DateTime ChimeEndTime { get { return alarmSettings.chimeEndTime; } set { } }
        public override string[] toStringArray()
        {
            List<String> outLines = new List<string>();
            outLines.AddRange(base.toStringArray());
            outLines.Insert(outLines.Count - 1, "chimeInterval="+alarmSettings.chimeInterval.ToString());
            outLines.Insert(outLines.Count - 1, "chimeEndTime="+alarmSettings.chimeEndTime.ToBinary());
            return outLines.ToArray();
        }
    }
}
