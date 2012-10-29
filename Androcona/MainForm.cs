﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Androcona
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void updateDisplay()
        {
            timeEventsListView.Items.Clear();
            foreach (Alarm al in Program.timeEvents)
            {
                ListViewItem item = new ListViewItem(al.ToString());
                item.SubItems.Add(al.AlarmTime.ToLongTimeString());
                timeEventsListView.Items.Add(item);
            }
        }
        private void NewTimeEventButton_Click(object sender, EventArgs e)
        {
            NewTimeEvent nt = new NewTimeEvent();
            nt.Show();
        }
    }
}