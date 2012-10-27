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
            this.SuspendLayout();
            // 
            // alarmTimePicker
            // 
            this.alarmTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.alarmTimePicker.Location = new System.Drawing.Point(63, 55);
            this.alarmTimePicker.Name = "alarmTimePicker";
            this.alarmTimePicker.Size = new System.Drawing.Size(191, 20);
            this.alarmTimePicker.TabIndex = 0;
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(383, 12);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(106, 41);
            this.SetButton.TabIndex = 1;
            this.SetButton.Text = "OK";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // NewTimeEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 352);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.alarmTimePicker);
            this.Name = "NewTimeEvent";
            this.Text = "NewTimeEvent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker alarmTimePicker;
        private System.Windows.Forms.Button SetButton;

    }
}