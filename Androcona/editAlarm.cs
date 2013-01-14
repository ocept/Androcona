using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Androcona
{
    public partial class editAlarm : Androcona.NewTimeEvent
    {
        private int AlarmIndex;
        public editAlarm(int alarmIndex)
        {
            AlarmIndex = alarmIndex;
            InitializeComponent();
            importAlarmData(Program.timeEvents[alarmIndex]);
        }
        private void importAlarmData(Alarm alarm) //populates form with stored alarm values
        {
            if(alarm.AlarmType == AlarmSettings.aType.Alarm)
                TypeCombo.SelectedIndex = 0;
            else if (alarm.AlarmType == AlarmSettings.aType.Chime)
            {
                TypeCombo.SelectedIndex = 1;
                chimeIntervalTextbox.Text = (alarm as Chime).ChimeInterval.TotalMinutes.ToString();
                chimeEndTimeTextbox.Text = (alarm as Chime).ChimeEndTime.ToShortTimeString();
            }
            alarmTimePicker.Value = alarm.AlarmTime;
            descriptionTextbox.Text = alarm.AlarmDescription;

            if (alarm.SoundSet) //sound
            {
                notifySoundCheck.Checked = true;
                soundFile snd = new soundFile(alarm.SoundPath);
                soundComboList.Items.Add(snd);
                soundComboList.SelectedIndex = soundComboList.Items.Count - 1;
            }

            //repeats


        }
        protected override void SetButton_Click(object sender, EventArgs e)
        {
            Program.timeEvents.RemoveAt(AlarmIndex); //remove original alarm
            base.SetButton_Click(sender, e); //add alarm with modified values
        }
    }
}
