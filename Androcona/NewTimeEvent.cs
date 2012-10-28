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

        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            Program.timeEvents.Add(new Alarm(alarmTimePicker.Value));
            Program.TheMainForm.updateDisplay();
            this.Close();
        }
    }
}
