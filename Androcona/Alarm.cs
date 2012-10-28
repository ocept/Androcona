using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Androcona
{
    class Alarm
    {
        protected DateTime alarmTime;
        public Alarm(DateTime time)
        {
            alarmTime = time;
            alarmInit();
        }
        public void alarmInit()
        {
            System.Timers.Timer eTimer = new System.Timers.Timer(alarmTime.Subtract(DateTime.Now).TotalMilliseconds);
            eTimer.Elapsed += new System.Timers.ElapsedEventHandler(eTimer_Elapsed);
            eTimer.Start();
        }
        public DateTime AlarmTime { get { return alarmTime; } set{} }
        void eTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Alarm triggered");
        }

    }
    class Chime : Alarm
    {
        public Chime(DateTime time) : base(time)
        {

        }
        private DateTime endTime;
    }
}
