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

        private void NewTimeEventButton_Click(object sender, EventArgs e)
        {
            NewTimeEvent nt = new NewTimeEvent();
            //nt.Activate();
            nt.Show();
        }
    }
}
