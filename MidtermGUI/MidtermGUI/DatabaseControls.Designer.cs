namespace MidtermGUI
{
    partial class DatabaseControlsBox
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
            this.DBControlslist = new System.Windows.Forms.ListView();
            this.DirectoryControlsGroup = new System.Windows.Forms.GroupBox();
            this.returnBtn = new System.Windows.Forms.Button();
            this.clearDBbtn = new System.Windows.Forms.Button();
            this.QueryDBbtn = new System.Windows.Forms.Button();
            this.DBextbox = new System.Windows.Forms.ComboBox();
            this.DBControlsLabel = new System.Windows.Forms.Label();
            this.File = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeStamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Extension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DirectoryControlsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // DBControlslist
            // 
            this.DBControlslist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.File,
            this.Path,
            this.Event,
            this.TimeStamp,
            this.Extension});
            this.DBControlslist.Location = new System.Drawing.Point(12, 123);
            this.DBControlslist.Name = "DBControlslist";
            this.DBControlslist.Size = new System.Drawing.Size(770, 312);
            this.DBControlslist.TabIndex = 0;
            this.DBControlslist.UseCompatibleStateImageBehavior = false;
            this.DBControlslist.View = System.Windows.Forms.View.Details;
            // 
            // DirectoryControlsGroup
            // 
            this.DirectoryControlsGroup.Controls.Add(this.DBControlsLabel);
            this.DirectoryControlsGroup.Controls.Add(this.DBextbox);
            this.DirectoryControlsGroup.Controls.Add(this.QueryDBbtn);
            this.DirectoryControlsGroup.Controls.Add(this.clearDBbtn);
            this.DirectoryControlsGroup.Controls.Add(this.returnBtn);
            this.DirectoryControlsGroup.Location = new System.Drawing.Point(12, 12);
            this.DirectoryControlsGroup.Name = "DirectoryControlsGroup";
            this.DirectoryControlsGroup.Size = new System.Drawing.Size(770, 105);
            this.DirectoryControlsGroup.TabIndex = 1;
            this.DirectoryControlsGroup.TabStop = false;
            this.DirectoryControlsGroup.Text = "Directory Controls Available";
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(207, 19);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(355, 33);
            this.returnBtn.TabIndex = 0;
            this.returnBtn.Text = "Exit Controls Window";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.onExitFromWindow_Click);
            // 
            // clearDBbtn
            // 
            this.clearDBbtn.Location = new System.Drawing.Point(532, 76);
            this.clearDBbtn.Name = "clearDBbtn";
            this.clearDBbtn.Size = new System.Drawing.Size(111, 23);
            this.clearDBbtn.TabIndex = 1;
            this.clearDBbtn.Text = "Clear Database";
            this.clearDBbtn.UseVisualStyleBackColor = true;
            this.clearDBbtn.Click += new System.EventHandler(this.onClearDB_Click);
            // 
            // QueryDBbtn
            // 
            this.QueryDBbtn.Location = new System.Drawing.Point(415, 76);
            this.QueryDBbtn.Name = "QueryDBbtn";
            this.QueryDBbtn.Size = new System.Drawing.Size(111, 23);
            this.QueryDBbtn.TabIndex = 2;
            this.QueryDBbtn.Text = "Query Database";
            this.QueryDBbtn.UseVisualStyleBackColor = true;
            this.QueryDBbtn.Click += new System.EventHandler(this.onQuery_Click);
            // 
            // DBextbox
            // 
            this.DBextbox.FormattingEnabled = true;
            this.DBextbox.Items.AddRange(new object[] {
            "*.*",
            "*.txt",
            "*.pdf",
            "*.zip",
            "*.dll",
            "*.c",
            "*.cs",
            "*.java",
            "*.html",
            "*.js",
            "*.exe",
            "*.jpg",
            "*.png"});
            this.DBextbox.Location = new System.Drawing.Point(288, 76);
            this.DBextbox.Name = "DBextbox";
            this.DBextbox.Size = new System.Drawing.Size(121, 21);
            this.DBextbox.TabIndex = 3;
            this.DBextbox.Text = "*.*";
            // 
            // DBControlsLabel
            // 
            this.DBControlsLabel.AutoSize = true;
            this.DBControlsLabel.Location = new System.Drawing.Point(43, 76);
            this.DBControlsLabel.Name = "DBControlsLabel";
            this.DBControlsLabel.Size = new System.Drawing.Size(239, 13);
            this.DBControlsLabel.TabIndex = 4;
            this.DBControlsLabel.Text = "Select an extension to query(*.*, *.txt, *.gif, *.mov)\r\n";
            // 
            // File
            // 
            this.File.Text = "File Name";
            this.File.Width = 112;
            // 
            // Path
            // 
            this.Path.Text = "Path";
            this.Path.Width = 270;
            // 
            // Event
            // 
            this.Event.Text = "Event";
            this.Event.Width = 98;
            // 
            // TimeStamp
            // 
            this.TimeStamp.Text = "Time Stamp";
            this.TimeStamp.Width = 145;
            // 
            // Extension
            // 
            this.Extension.Text = "Extension";
            this.Extension.Width = 525;
            // 
            // DatabaseControlsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(794, 447);
            this.Controls.Add(this.DirectoryControlsGroup);
            this.Controls.Add(this.DBControlslist);
            this.Name = "DatabaseControlsBox";
            this.Text = "Database Controls";
            this.DirectoryControlsGroup.ResumeLayout(false);
            this.DirectoryControlsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView DBControlslist;
        private System.Windows.Forms.GroupBox DirectoryControlsGroup;
        private System.Windows.Forms.Label DBControlsLabel;
        private System.Windows.Forms.ComboBox DBextbox;
        private System.Windows.Forms.Button QueryDBbtn;
        private System.Windows.Forms.Button clearDBbtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.ColumnHeader File;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.ColumnHeader Event;
        private System.Windows.Forms.ColumnHeader TimeStamp;
        private System.Windows.Forms.ColumnHeader Extension;
    }
}