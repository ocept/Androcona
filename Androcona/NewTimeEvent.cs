using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Androcona
{
    public partial class NewTimeEvent : Form
    {
        protected struct soundFile //stores a soundfile path and shows only filename on form display
        {
            public string soundPath;
            public soundFile(string path)
            {
                soundPath = path;
            }
            public override string ToString()
            {
                return soundPath.Substring(soundPath.LastIndexOf(@"\") + 1);
            }
        }
        public delegate void newAlarmSetHandler(object NewTimeEvent, EventArgs e);
        public event newAlarmSetHandler newAlarmSet;

        public NewTimeEvent()
        {
            InitializeComponent();
            this.TypeCombo.DataSource = Enum.GetValues(typeof(AlarmSettings.aType));
            this.TypeCombo.SelectedIndex = 0;
            populateSoundComboList();
        }
        private void populateSoundComboList()
        {
            string soundsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Androcona\Sounds";
            string[] soundFiles = Directory.GetFiles(soundsPath, "*.wav");
            foreach (string s in soundFiles)
            {
                soundComboList.Items.Add(new soundFile(s));
            }
        }
        protected virtual void SetButton_Click(object sender, EventArgs e)
        {
            AlarmSettings aSettings = new AlarmSettings();
            aSettings.time = alarmTimePicker.Value;
            aSettings.description = descriptionTextbox.Text;
            aSettings.type = (AlarmSettings.aType)Enum.Parse(typeof(AlarmSettings.aType), TypeCombo.Text);
            aSettings.notifyMessageBox = notifyMessageCheck.Checked;
            if (notifySoundCheck.Checked && soundComboList.SelectedItem != null)
            {
                aSettings.playSound = notifySoundCheck.Checked;
                aSettings.soundPath = ((soundFile)soundComboList.SelectedItem).soundPath;
            }
            if (TypeCombo.Text == "Alarm")
            {
                Program.timeEvents.Add(new Alarm(aSettings));
            }
            else if (TypeCombo.Text == "Chime")
            {
                aSettings.chimeInterval = TimeSpan.FromMinutes(double.Parse(chimeIntervalTextbox.Text));
                aSettings.chimeEndTime = DateTime.Parse(chimeEndTimeTextbox.Text);
                Program.timeEvents.Add(new Chime(aSettings));
            }
            if (newAlarmSet != null)
            {
                newAlarmSet(this, EventArgs.Empty);
            }
            saveAlarms.writeAlarms();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeCombo.Text == "Chime")
            {
                chimePanel.Visible = true;
            }
            else if (TypeCombo.Text == "Alarm")
            {
                chimePanel.Visible = false;
            }
        }

    }
}
