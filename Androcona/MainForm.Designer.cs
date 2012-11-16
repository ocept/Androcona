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
            this.timeEventsListView = new System.Windows.Forms.ListView();
            this.TypeColumn = new System.Windows.Forms.ColumnHeader();
            this.TimeColumn = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // NewTimeEventButton
            // 
            this.NewTimeEventButton.Location = new System.Drawing.Point(390, 12);
            this.NewTimeEventButton.Name = "NewTimeEventButton";
            this.NewTimeEventButton.Size = new System.Drawing.Size(103, 39);
            this.NewTimeEventButton.TabIndex = 0;
            this.NewTimeEventButton.Text = "New";
            this.NewTimeEventButton.UseVisualStyleBackColor = true;
            this.NewTimeEventButton.Click += new System.EventHandler(this.NewTimeEventButton_Click);
            // 
            // timeEventsListView
            // 
            this.timeEventsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TypeColumn,
            this.TimeColumn});
            this.timeEventsListView.FullRowSelect = true;
            this.timeEventsListView.Location = new System.Drawing.Point(12, 57);
            this.timeEventsListView.Name = "timeEventsListView";
            this.timeEventsListView.Size = new System.Drawing.Size(480, 338);
            this.timeEventsListView.TabIndex = 2;
            this.timeEventsListView.UseCompatibleStateImageBehavior = false;
            this.timeEventsListView.View = System.Windows.Forms.View.Details;
            // 
            // TypeColumn
            // 
            this.TypeColumn.Text = "Type";
            this.TypeColumn.Width = 97;
            // 
            // TimeColumn
            // 
            this.TimeColumn.Text = "Time";
            this.TimeColumn.Width = 90;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 407);
            this.Controls.Add(this.timeEventsListView);
            this.Controls.Add(this.NewTimeEventButton);
            this.Name = "MainForm";
            this.Text = "Androcona";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewTimeEventButton;
        private System.Windows.Forms.ListView timeEventsListView;
        private System.Windows.Forms.ColumnHeader TimeColumn;
        private System.Windows.Forms.ColumnHeader TypeColumn;
    }
}

