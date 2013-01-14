namespace Androcona
{
    partial class NewTimeEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.alarmTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SetButton = new System.Windows.Forms.Button();
            this._CancelButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.chimeTimeLabel = new System.Windows.Forms.Label();
            this.chimeEndTimeLabel = new System.Windows.Forms.Label();
            this.chimeEndTimeTextbox = new System.Windows.Forms.MaskedTextBox();
            this.chimeIntervalTextbox = new System.Windows.Forms.MaskedTextBox();
            this.notificationGroup = new System.Windows.Forms.GroupBox();
            this.soundComboList = new System.Windows.Forms.ComboBox();
            this.notifyRunProgramCheck = new System.Windows.Forms.CheckBox();
            this.notifySoundCheck = new System.Windows.Forms.CheckBox();
            this.notifyMessageCheck = new System.Windows.Forms.CheckBox();
            this.chimePanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dayCheckPanel = new System.Windows.Forms.Panel();
            this.daySun = new System.Windows.Forms.CheckBox();
            this.dayMon = new System.Windows.Forms.CheckBox();
            this.daySat = new System.Windows.Forms.CheckBox();
            this.dayTue = new System.Windows.Forms.CheckBox();
            this.dayFri = new System.Windows.Forms.CheckBox();
            this.dayWed = new System.Windows.Forms.CheckBox();
            this.dayThu = new System.Windows.Forms.CheckBox();
            this.repeatFreqCombo = new System.Windows.Forms.ComboBox();
            this.repeatCheck = new System.Windows.Forms.CheckBox();
            this.notificationGroup.SuspendLayout();
            this.chimePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.dayCheckPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // alarmTimePicker
            // 
            this.alarmTimePicker.CustomFormat = "HH:mm -- dd/MMM/yyy";
            this.alarmTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.alarmTimePicker.Location = new System.Drawing.Point(86, 42);
            this.alarmTimePicker.Name = "alarmTimePicker";
            this.alarmTimePicker.Size = new System.Drawing.Size(268, 20);
            this.alarmTimePicker.TabIndex = 0;
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(383, 12);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(106, 40);
            this.SetButton.TabIndex = 1;
            this.SetButton.Text = "OK";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // _CancelButton
            // 
            this._CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._CancelButton.Location = new System.Drawing.Point(383, 59);
            this._CancelButton.Name = "_CancelButton";
            this._CancelButton.Size = new System.Drawing.Size(106, 40);
            this._CancelButton.TabIndex = 2;
            this._CancelButton.Text = "Cancel";
            this._CancelButton.UseVisualStyleBackColor = true;
            this._CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(12, 45);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(68, 18);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time:";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(86, 75);
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(268, 20);
            this.descriptionTextbox.TabIndex = 4;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 78);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "Description:";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TypeCombo
            // 
            this.TypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Location = new System.Drawing.Point(86, 12);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(187, 21);
            this.TypeCombo.TabIndex = 6;
            this.TypeCombo.SelectedIndexChanged += new System.EventHandler(this.TypeCombo_SelectedIndexChanged);
            // 
            // TypeLabel
            // 
            this.TypeLabel.Location = new System.Drawing.Point(12, 12);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(68, 18);
            this.TypeLabel.TabIndex = 7;
            this.TypeLabel.Text = "Type:";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chimeTimeLabel
            // 
            this.chimeTimeLabel.AutoSize = true;
            this.chimeTimeLabel.Location = new System.Drawing.Point(3, 3);
            this.chimeTimeLabel.Name = "chimeTimeLabel";
            this.chimeTimeLabel.Size = new System.Drawing.Size(137, 13);
            this.chimeTimeLabel.TabIndex = 9;
            this.chimeTimeLabel.Text = "Chime every .......... minutes";
            // 
            // chimeEndTimeLabel
            // 
            this.chimeEndTimeLabel.AutoSize = true;
            this.chimeEndTimeLabel.Location = new System.Drawing.Point(3, 28);
            this.chimeEndTimeLabel.Name = "chimeEndTimeLabel";
            this.chimeEndTimeLabel.Size = new System.Drawing.Size(28, 13);
            this.chimeEndTimeLabel.TabIndex = 10;
            this.chimeEndTimeLabel.Text = "Until";
            // 
            // chimeEndTimeTextbox
            // 
            this.chimeEndTimeTextbox.Location = new System.Drawing.Point(37, 25);
            this.chimeEndTimeTextbox.Mask = "00:00";
            this.chimeEndTimeTextbox.Name = "chimeEndTimeTextbox";
            this.chimeEndTimeTextbox.Size = new System.Drawing.Size(36, 20);
            this.chimeEndTimeTextbox.TabIndex = 12;
            this.chimeEndTimeTextbox.ValidatingType = typeof(System.DateTime);
            // 
            // chimeIntervalTextbox
            // 
            this.chimeIntervalTextbox.Location = new System.Drawing.Point(67, 0);
            this.chimeIntervalTextbox.Mask = "000";
            this.chimeIntervalTextbox.Name = "chimeIntervalTextbox";
            this.chimeIntervalTextbox.Size = new System.Drawing.Size(31, 20);
            this.chimeIntervalTextbox.TabIndex = 13;
            // 
            // notificationGroup
            // 
            this.notificationGroup.Controls.Add(this.soundComboList);
            this.notificationGroup.Controls.Add(this.notifyRunProgramCheck);
            this.notificationGroup.Controls.Add(this.notifySoundCheck);
            this.notificationGroup.Controls.Add(this.notifyMessageCheck);
            this.notificationGroup.Location = new System.Drawing.Point(22, 146);
            this.notificationGroup.Name = "notificationGroup";
            this.notificationGroup.Size = new System.Drawing.Size(203, 186);
            this.notificationGroup.TabIndex = 14;
            this.notificationGroup.TabStop = false;
            this.notificationGroup.Text = "Notifications";
            // 
            // soundComboList
            // 
            this.soundComboList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.soundComboList.FormattingEnabled = true;
            this.soundComboList.Location = new System.Drawing.Point(69, 45);
            this.soundComboList.Name = "soundComboList";
            this.soundComboList.Size = new System.Drawing.Size(128, 21);
            this.soundComboList.TabIndex = 3;
            // 
            // notifyRunProgramCheck
            // 
            this.notifyRunProgramCheck.AutoSize = true;
            this.notifyRunProgramCheck.Location = new System.Drawing.Point(12, 70);
            this.notifyRunProgramCheck.Name = "notifyRunProgramCheck";
            this.notifyRunProgramCheck.Size = new System.Drawing.Size(88, 17);
            this.notifyRunProgramCheck.TabIndex = 2;
            this.notifyRunProgramCheck.Text = "Run Program";
            this.notifyRunProgramCheck.UseVisualStyleBackColor = true;
            // 
            // notifySoundCheck
            // 
            this.notifySoundCheck.AutoSize = true;
            this.notifySoundCheck.Location = new System.Drawing.Point(12, 47);
            this.notifySoundCheck.Name = "notifySoundCheck";
            this.notifySoundCheck.Size = new System.Drawing.Size(57, 17);
            this.notifySoundCheck.TabIndex = 1;
            this.notifySoundCheck.Text = "Sound";
            this.notifySoundCheck.UseVisualStyleBackColor = true;
            // 
            // notifyMessageCheck
            // 
            this.notifyMessageCheck.AutoSize = true;
            this.notifyMessageCheck.Checked = true;
            this.notifyMessageCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notifyMessageCheck.Location = new System.Drawing.Point(12, 24);
            this.notifyMessageCheck.Name = "notifyMessageCheck";
            this.notifyMessageCheck.Size = new System.Drawing.Size(90, 17);
            this.notifyMessageCheck.TabIndex = 0;
            this.notifyMessageCheck.Text = "Message Box";
            this.notifyMessageCheck.UseVisualStyleBackColor = true;
            // 
            // chimePanel
            // 
            this.chimePanel.AutoSize = true;
            this.chimePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chimePanel.Controls.Add(this.chimeIntervalTextbox);
            this.chimePanel.Controls.Add(this.chimeTimeLabel);
            this.chimePanel.Controls.Add(this.chimeEndTimeLabel);
            this.chimePanel.Controls.Add(this.chimeEndTimeTextbox);
            this.chimePanel.Location = new System.Drawing.Point(15, 101);
            this.chimePanel.Name = "chimePanel";
            this.chimePanel.Size = new System.Drawing.Size(143, 48);
            this.chimePanel.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dayCheckPanel);
            this.groupBox1.Controls.Add(this.repeatFreqCombo);
            this.groupBox1.Controls.Add(this.repeatCheck);
            this.groupBox1.Controls.Add(this.chimePanel);
            this.groupBox1.Location = new System.Drawing.Point(252, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 185);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repeat";
            // 
            // dayCheckPanel
            // 
            this.dayCheckPanel.AutoSize = true;
            this.dayCheckPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dayCheckPanel.Controls.Add(this.daySun);
            this.dayCheckPanel.Controls.Add(this.dayMon);
            this.dayCheckPanel.Controls.Add(this.daySat);
            this.dayCheckPanel.Controls.Add(this.dayTue);
            this.dayCheckPanel.Controls.Add(this.dayFri);
            this.dayCheckPanel.Controls.Add(this.dayWed);
            this.dayCheckPanel.Controls.Add(this.dayThu);
            this.dayCheckPanel.Location = new System.Drawing.Point(15, 45);
            this.dayCheckPanel.Name = "dayCheckPanel";
            this.dayCheckPanel.Size = new System.Drawing.Size(229, 50);
            this.dayCheckPanel.TabIndex = 16;
            // 
            // daySun
            // 
            this.daySun.AutoSize = true;
            this.daySun.Location = new System.Drawing.Point(50, 30);
            this.daySun.Name = "daySun";
            this.daySun.Size = new System.Drawing.Size(45, 17);
            this.daySun.TabIndex = 22;
            this.daySun.Tag = "0";
            this.daySun.Text = "Sun";
            this.daySun.UseVisualStyleBackColor = true;
            // 
            // dayMon
            // 
            this.dayMon.AutoSize = true;
            this.dayMon.Location = new System.Drawing.Point(3, 9);
            this.dayMon.Name = "dayMon";
            this.dayMon.Size = new System.Drawing.Size(47, 17);
            this.dayMon.TabIndex = 16;
            this.dayMon.Tag = "1";
            this.dayMon.Text = "Mon";
            this.dayMon.UseVisualStyleBackColor = true;
            // 
            // daySat
            // 
            this.daySat.AutoSize = true;
            this.daySat.Location = new System.Drawing.Point(3, 30);
            this.daySat.Name = "daySat";
            this.daySat.Size = new System.Drawing.Size(42, 17);
            this.daySat.TabIndex = 21;
            this.daySat.Tag = "6";
            this.daySat.Text = "Sat";
            this.daySat.UseVisualStyleBackColor = true;
            // 
            // dayTue
            // 
            this.dayTue.AutoSize = true;
            this.dayTue.Location = new System.Drawing.Point(50, 9);
            this.dayTue.Name = "dayTue";
            this.dayTue.Size = new System.Drawing.Size(45, 17);
            this.dayTue.TabIndex = 17;
            this.dayTue.Tag = "2";
            this.dayTue.Text = "Tue";
            this.dayTue.UseVisualStyleBackColor = true;
            // 
            // dayFri
            // 
            this.dayFri.AutoSize = true;
            this.dayFri.Location = new System.Drawing.Point(189, 9);
            this.dayFri.Name = "dayFri";
            this.dayFri.Size = new System.Drawing.Size(37, 17);
            this.dayFri.TabIndex = 20;
            this.dayFri.Tag = "5";
            this.dayFri.Text = "Fri";
            this.dayFri.UseVisualStyleBackColor = true;
            // 
            // dayWed
            // 
            this.dayWed.AutoSize = true;
            this.dayWed.Location = new System.Drawing.Point(95, 9);
            this.dayWed.Name = "dayWed";
            this.dayWed.Size = new System.Drawing.Size(49, 17);
            this.dayWed.TabIndex = 18;
            this.dayWed.Tag = "3";
            this.dayWed.Text = "Wed";
            this.dayWed.UseVisualStyleBackColor = true;
            // 
            // dayThu
            // 
            this.dayThu.AutoSize = true;
            this.dayThu.Location = new System.Drawing.Point(144, 9);
            this.dayThu.Name = "dayThu";
            this.dayThu.Size = new System.Drawing.Size(45, 17);
            this.dayThu.TabIndex = 19;
            this.dayThu.Tag = "4";
            this.dayThu.Text = "Thu";
            this.dayThu.UseVisualStyleBackColor = true;
            // 
            // repeatFreqCombo
            // 
            this.repeatFreqCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.repeatFreqCombo.FormattingEnabled = true;
            this.repeatFreqCombo.Items.AddRange(new object[] {
            "Every Day",
            "Every Weekday",
            "Every Week",
            "Every Fortnight",
            "Every Month"});
            this.repeatFreqCombo.Location = new System.Drawing.Point(83, 22);
            this.repeatFreqCombo.Name = "repeatFreqCombo";
            this.repeatFreqCombo.Size = new System.Drawing.Size(146, 21);
            this.repeatFreqCombo.TabIndex = 15;
            this.repeatFreqCombo.SelectedIndexChanged += new System.EventHandler(this.repeatFreqCombo_SelectedIndexChanged);
            // 
            // repeatCheck
            // 
            this.repeatCheck.AutoSize = true;
            this.repeatCheck.Location = new System.Drawing.Point(17, 24);
            this.repeatCheck.Name = "repeatCheck";
            this.repeatCheck.Size = new System.Drawing.Size(61, 17);
            this.repeatCheck.TabIndex = 14;
            this.repeatCheck.Text = "Repeat";
            this.repeatCheck.UseVisualStyleBackColor = true;
            // 
            // NewTimeEvent
            // 
            this.AcceptButton = this.SetButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.notificationGroup);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TypeCombo);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this._CancelButton);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.alarmTimePicker);
            this.Name = "NewTimeEvent";
            this.Text = "NewTimeEvent";
            this.notificationGroup.ResumeLayout(false);
            this.notificationGroup.PerformLayout();
            this.chimePanel.ResumeLayout(false);
            this.chimePanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.dayCheckPanel.ResumeLayout(false);
            this.dayCheckPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Button _CancelButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label chimeTimeLabel;
        private System.Windows.Forms.Label chimeEndTimeLabel;
        protected System.Windows.Forms.ComboBox TypeCombo;
        protected System.Windows.Forms.DateTimePicker alarmTimePicker;
        protected System.Windows.Forms.TextBox descriptionTextbox;
        protected System.Windows.Forms.GroupBox notificationGroup;
        protected System.Windows.Forms.MaskedTextBox chimeEndTimeTextbox;
        protected System.Windows.Forms.MaskedTextBox chimeIntervalTextbox;
        protected System.Windows.Forms.CheckBox notifySoundCheck;
        protected System.Windows.Forms.CheckBox notifyMessageCheck;
        protected System.Windows.Forms.CheckBox notifyRunProgramCheck;
        protected System.Windows.Forms.ComboBox soundComboList;
        protected System.Windows.Forms.Panel chimePanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox repeatCheck;
        private System.Windows.Forms.CheckBox daySat;
        private System.Windows.Forms.CheckBox dayFri;
        private System.Windows.Forms.CheckBox dayThu;
        private System.Windows.Forms.CheckBox dayWed;
        private System.Windows.Forms.CheckBox dayTue;
        private System.Windows.Forms.CheckBox dayMon;
        private System.Windows.Forms.ComboBox repeatFreqCombo;
        private System.Windows.Forms.Panel dayCheckPanel;
        private System.Windows.Forms.CheckBox daySun;

    }
}