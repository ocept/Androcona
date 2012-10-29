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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // alarmTimePicker
            // 
            this.alarmTimePicker.CustomFormat = "HH:MM -- dd/MMM/yyy";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 4;
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
            this.TypeCombo.Items.AddRange(new object[] {
            "Alarm",
            "Chime"});
            this.TypeCombo.Location = new System.Drawing.Point(86, 12);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(187, 21);
            this.TypeCombo.Sorted = true;
            this.TypeCombo.TabIndex = 6;
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
            // NewTimeEvent
            // 
            this.AcceptButton = this.SetButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 352);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TypeCombo);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this._CancelButton);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.alarmTimePicker);
            this.Name = "NewTimeEvent";
            this.Text = "NewTimeEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker alarmTimePicker;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Button _CancelButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.ComboBox TypeCombo;

    }
}