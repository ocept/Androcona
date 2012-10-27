namespace Androcona
{
    partial class MainForm
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
            this.NewTimeEventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewTimeEventButton
            // 
            this.NewTimeEventButton.Location = new System.Drawing.Point(182, 21);
            this.NewTimeEventButton.Name = "NewTimeEventButton";
            this.NewTimeEventButton.Size = new System.Drawing.Size(103, 39);
            this.NewTimeEventButton.TabIndex = 0;
            this.NewTimeEventButton.Text = "New";
            this.NewTimeEventButton.UseVisualStyleBackColor = true;
            this.NewTimeEventButton.Click += new System.EventHandler(this.NewTimeEventButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 407);
            this.Controls.Add(this.NewTimeEventButton);
            this.Name = "MainForm";
            this.Text = "Androcona";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewTimeEventButton;
    }
}

