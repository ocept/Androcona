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
        public Alarm(AlarmSettings settings)
        {
            alarmSettings = settings;
            alarmInit();
        }
        public void alarmInit()
        {
            try
            {
                System.Timers.Timer eTimer = new System.Timers.Timer(alarmSettings.time.Subtract(DateTime.Now).TotalMilliseconds);
                eTimer.Elapsed += new System.Timers.ElapsedEventHandler(eTimer_Elapsed);
                eTimer.Start();
            }
            catch (System.ArgumentException)
            {
                return; //invalid time input
            }
        }
        public DateTime AlarmTime { get { return alarmSettings.time; } set{} }
        private void eTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Alarm triggered");
        }

    }
    class Chime : Alarm
    {
        public Chime(AlarmSettings settings) : base(settings)
        {

        }
        private DateTime endTime;
    }
}
