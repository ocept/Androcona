using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Androcona
{
    public partial class NewTimeEvent : Form
    {
        public NewTimeEvent()
        {
            InitializeComponent();
            this.TypeCombo.DataSource = Enum.GetValues(typeof(AlarmSettings.aType));
            this.TypeCombo.SelectedIndex = 0;
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            AlarmSettings aSettings = new AlarmSettings();
            aSettings.time = alarmTimePicker.Value;
            aSettings.description = descriptionTextbox.Text;
            aSettings.type = (AlarmSettings.aType)Enum.Parse(typeof(AlarmSettings.aType), TypeCombo.Text);

            if (TypeCombo.SelectedIndex == 0) //Alarm
            {
                Program.timeEvents.Add(new Alarm(aSettings));
            }
            Program.TheMainForm.updateDisplay();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
