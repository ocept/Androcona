﻿using System;
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
            if (alarmSettings.time.Subtract(DateTime.Now).TotalMilliseconds <= 0) //alarm time is in past
            {
                return setRepeatAlarm();
            }
            return startTimer();
          
        }
        private int setRepeatAlarm()
        {
            if (!alarmSettings.repeat)
            {
                Console.WriteLine("Repeat attempt on non repeat alarm");
                return 0;
            }
            if (alarmSettings.repeatFreq == AlarmSettings.repeatFreqEnum.Monthly)
            {
                alarmSettings.time = alarmSettings.time.AddMonths(1);
                //Timer not restarted due to interval being > the max value 
                //TODO: run daily check on alarms and start if due within 24hrs
            }
            else if (alarmSettings.repeatFreq == AlarmSettings.repeatFreqEnum.Weekly || 
                (alarmSettings.repeatFreq == AlarmSettings.repeatFreqEnum.Fortnightly && alarmSettings.time.AddDays(7).CompareTo(DateTime.Now) < 0))
            {
                if (alarmSettings.time.TimeOfDay.CompareTo(DateTime.Now.TimeOfDay) > 0) //if alarm is later in day than current time
                {
                    if (alarmSettings.repeatDays[(int)DateTime.Now.DayOfWeek - 1]) //if alarm is set for today
                    {
                        alarmSettings.time = DateTime.Today.Add(alarmSettings.time.TimeOfDay);
                        startTimer();
                    }
                }
            }


            return 1;
        }
        private int startTimer()
        {
            try
            {
                eTimer = new System.Timers.Timer(alarmSettings.time.Subtract(DateTime.Now).TotalMilliseconds);
                eTimer.Elapsed += new System.Timers.ElapsedEventHandler(eTimer_Elapsed);
                eTimer.AutoReset = false;
                eTimer.Start();
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("AlarmInit: invalid time input");
                return 0;
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
            outLines.Add("playSound=" + alarmSettings.playSound.ToString());
            if(alarmSettings.soundPath != null) outLines.Add("soundPath=" + alarmSettings.soundPath.ToString());
            outLines.Add("END");

            return outLines.ToArray();
        }

        public DateTime AlarmTime { get { return alarmSettings.time; } set{} }
        public AlarmSettings.aType AlarmType { get { return alarmSettings.type; } set { } }
        public string AlarmDescription { get { return alarmSettings.description; } set { } }
        public string SoundPath { get { return alarmSettings.soundPath; } set { } }
        public bool SoundSet { get { return alarmSettings.playSound; } set { } }

        protected virtual void eTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            alarmTriggered();
        }
#if DEBUG
        public void alarmTriggered()
#else
        private void alarmTriggered()
#endif
        {
            if (alarmSettings.playSound) playSound();
            if (alarmSettings.notifyMessageBox) notifyMessageBox();
        }
        private void playSound()
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(alarmSettings.soundPath);
                player.Play();
            }
            catch
            {
                Console.WriteLine("error playing sound file: " + alarmSettings.soundPath);
            }
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
