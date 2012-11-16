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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            updateDisplay(this, EventArgs.Empty);
            Program.timeEvents.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(updateDisplay);

            ContextMenuStrip alarmContextMenu = new ContextMenuStrip();
            alarmContextMenu.Items.Add("Delete alarm", null, contextMenuDeleteAlarm);
            timeEventsListView.ContextMenuStrip = alarmContextMenu;
            alarmContextMenu.Opening += new CancelEventHandler(alarmContextMenu_Opening);
        }

        void alarmContextMenu_Opening(object sender, CancelEventArgs e) //do not show context menu if none selected
        {
            if (timeEventsListView.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void contextMenuDeleteAlarm(object sender, EventArgs e)
        {
            Program.timeEvents.RemoveAt((int)timeEventsListView.SelectedItems[0].Tag); //remove alarm
            saveAlarms.writeAlarms(); //update save file
        }

        public void updateDisplay(object sender, EventArgs e)
        {
            timeEventsListView.Items.Clear();
            for(int i = 0; i < Program.timeEvents.Count; i++)
            {
                ListViewItem item = new ListViewItem(Program.timeEvents[i].ToString());
                item.Tag = i;
                item.SubItems.Add(Program.timeEvents[i].AlarmTime.ToLongTimeString());
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
