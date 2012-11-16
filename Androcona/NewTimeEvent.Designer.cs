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
            this.chimePanel = new System.Windows.Forms.Panel();
            this.chimeIntervalTextbox = new System.Windows.Forms.MaskedTextBox();
            this.notificationGroup = new System.Windows.Forms.GroupBox();
            this.notifyRunProgramCheck = new System.Windows.Forms.CheckBox();
            this.notifySoundCheck = new System.Windows.Forms.CheckBox();
            this.notifyMessageCheck = new System.Windows.Forms.CheckBox();
            this.chimePanel.SuspendLayout();
            this.notificationGroup.SuspendLayout();
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
            this.chimeTimeLabel.Location = new System.Drawing.Point(3, 10);
            this.chimeTimeLabel.Name = "chimeTimeLabel";
            this.chimeTimeLabel.Size = new System.Drawing.Size(137, 13);
            this.chimeTimeLabel.TabIndex = 9;
            this.chimeTimeLabel.Text = "Chime every .......... minutes";
            // 
            // chimeEndTimeLabel
            // 
            this.chimeEndTimeLabel.AutoSize = true;
            this.chimeEndTimeLabel.Location = new System.Drawing.Point(3, 35);
            this.chimeEndTimeLabel.Name = "chimeEndTimeLabel";
            this.chimeEndTimeLabel.Size = new System.Drawing.Size(28, 13);
            this.chimeEndTimeLabel.TabIndex = 10;
            this.chimeEndTimeLabel.Text = "Until";
            // 
            // chimeEndTimeTextbox
            // 
            this.chimeEndTimeTextbox.Location = new System.Drawing.Point(37, 32);
            this.chimeEndTimeTextbox.Mask = "00:00";
            this.chimeEndTimeTextbox.Name = "chimeEndTimeTextbox";
            this.chimeEndTimeTextbox.Size = new System.Drawing.Size(36, 20);
            this.chimeEndTimeTextbox.TabIndex = 12;
            this.chimeEndTimeTextbox.ValidatingType = typeof(System.DateTime);
            // 
            // chimePanel
            // 
            this.chimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chimePanel.Controls.Add(this.chimeIntervalTextbox);
            this.chimePanel.Controls.Add(this.chimeEndTimeTextbox);
            this.chimePanel.Controls.Add(this.chimeEndTimeLabel);
            this.chimePanel.Controls.Add(this.chimeTimeLabel);
            this.chimePanel.Location = new System.Drawing.Point(275, 172);
            this.chimePanel.Name = "chimePanel";
            this.chimePanel.Size = new System.Drawing.Size(213, 161);
            this.chimePanel.TabIndex = 13;
            // 
            // chimeIntervalTextbox
            // 
            this.chimeIntervalTextbox.Location = new System.Drawing.Point(67, 7);
            this.chimeIntervalTextbox.Mask = "000";
            this.chimeIntervalTextbox.Name = "chimeIntervalTextbox";
            this.chimeIntervalTextbox.Size = new System.Drawing.Size(31, 20);
            this.chimeIntervalTextbox.TabIndex = 13;
            // 
            // notificationGroup
            // 
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
            // NewTimeEvent
            // 
            this.AcceptButton = this.SetButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 352);
            this.Controls.Add(this.notificationGroup);
            this.Controls.Add(this.chimePanel);
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
            this.chimePanel.ResumeLayout(false);
            this.chimePanel.PerformLayout();
            this.notificationGroup.ResumeLayout(false);
            this.notificationGroup.PerformLayout();
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
        private System.Windows.Forms.CheckBox notifySoundCheck;
        private System.Windows.Forms.CheckBox notifyMessageCheck;
        private System.Windows.Forms.CheckBox notifyRunProgramCheck;
        protected System.Windows.Forms.ComboBox TypeCombo;
        protected System.Windows.Forms.DateTimePicker alarmTimePicker;
        protected System.Windows.Forms.TextBox descriptionTextbox;
        protected System.Windows.Forms.Panel chimePanel;
        protected System.Windows.Forms.GroupBox notificationGroup;
        protected System.Windows.Forms.MaskedTextBox chimeEndTimeTextbox;
        protected System.Windows.Forms.MaskedTextBox chimeIntervalTextbox;

    }
}