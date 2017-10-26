namespace MidtermGUI
{
    partial class FrontWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startWatchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopWatchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fSWHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.directoryBox = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.DBcontrols = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.extBox = new System.Windows.Forms.ComboBox();
            this.ContentsViewbox = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.absolutePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Timestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStartFSW = new System.Windows.Forms.ToolStripButton();
            this.toolStopFSW = new System.Windows.Forms.ToolStripButton();
            this.ToolWriteToDB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolOpenDBControls = new System.Windows.Forms.ToolStripButton();
            this.toolAbout = new System.Windows.Forms.ToolStripButton();
            this.toolHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.DirectoryGroup = new System.Windows.Forms.GroupBox();
            this.subdirectories = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DatabaseGroup = new System.Windows.Forms.GroupBox();
            this.writetodbbox = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timebar = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.DirectoryGroup.SuspendLayout();
            this.DatabaseGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.watcherToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.ToolTipText = "File Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exit Program";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.onExit_Click);
            // 
            // watcherToolStripMenuItem
            // 
            this.watcherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startWatchingToolStripMenuItem,
            this.stopWatchingToolStripMenuItem});
            this.watcherToolStripMenuItem.Name = "watcherToolStripMenuItem";
            this.watcherToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.watcherToolStripMenuItem.Text = "&Watcher";
            this.watcherToolStripMenuItem.ToolTipText = "Watcher Menu";
            // 
            // startWatchingToolStripMenuItem
            // 
            this.startWatchingToolStripMenuItem.Name = "startWatchingToolStripMenuItem";
            this.startWatchingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.startWatchingToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.startWatchingToolStripMenuItem.Text = "Start Watching";
            this.startWatchingToolStripMenuItem.ToolTipText = "Start FSW";
            this.startWatchingToolStripMenuItem.Click += new System.EventHandler(this.btnStart_onStartWatch);
            // 
            // stopWatchingToolStripMenuItem
            // 
            this.stopWatchingToolStripMenuItem.Enabled = false;
            this.stopWatchingToolStripMenuItem.Name = "stopWatchingToolStripMenuItem";
            this.stopWatchingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.stopWatchingToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.stopWatchingToolStripMenuItem.Text = "Stop Watching";
            this.stopWatchingToolStripMenuItem.ToolTipText = "StopFSW";
            this.stopWatchingToolStripMenuItem.Click += new System.EventHandler(this.btnStop_StopWatching);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeToDatabaseToolStripMenuItem,
            this.queryToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "&Database";
            this.databaseToolStripMenuItem.ToolTipText = "Database Menu";
            // 
            // writeToDatabaseToolStripMenuItem
            // 
            this.writeToDatabaseToolStripMenuItem.Name = "writeToDatabaseToolStripMenuItem";
            this.writeToDatabaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.W)));
            this.writeToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.writeToDatabaseToolStripMenuItem.Text = "Write to Database";
            this.writeToDatabaseToolStripMenuItem.ToolTipText = "Write to Database";
            this.writeToDatabaseToolStripMenuItem.Click += new System.EventHandler(this.OnWritetoDB_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.queryToolStripMenuItem.Text = "Database Controls";
            this.queryToolStripMenuItem.ToolTipText = "Database Control Panel";
            this.queryToolStripMenuItem.Click += new System.EventHandler(this.onDatabaseControls_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.fSWHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.ToolTipText = "Help Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.ToolTipText = "About Prompt";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.onAbouttab_Click);
            // 
            // fSWHelpToolStripMenuItem
            // 
            this.fSWHelpToolStripMenuItem.Name = "fSWHelpToolStripMenuItem";
            this.fSWHelpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.fSWHelpToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.fSWHelpToolStripMenuItem.Text = "FSW help";
            this.fSWHelpToolStripMenuItem.ToolTipText = "Help Prompt";
            this.fSWHelpToolStripMenuItem.Click += new System.EventHandler(this.onFSWHelp_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.Timebar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 598);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(500, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // directoryBox
            // 
            this.directoryBox.Location = new System.Drawing.Point(217, 44);
            this.directoryBox.Name = "directoryBox";
            this.directoryBox.Size = new System.Drawing.Size(253, 20);
            this.directoryBox.TabIndex = 9;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Location = new System.Drawing.Point(352, 68);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(118, 23);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_StopWatching);
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(217, 68);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_onStartWatch);
            // 
            // DBcontrols
            // 
            this.DBcontrols.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.DBcontrols.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DBcontrols.Location = new System.Drawing.Point(6, 19);
            this.DBcontrols.Name = "DBcontrols";
            this.DBcontrols.Size = new System.Drawing.Size(216, 70);
            this.DBcontrols.TabIndex = 16;
            this.DBcontrols.Text = "Database Controls";
            this.DBcontrols.UseVisualStyleBackColor = true;
            this.DBcontrols.Click += new System.EventHandler(this.onDatabaseControls_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Monitor By Extension\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Directory to Monitor";
            // 
            // extBox
            // 
            this.extBox.FormattingEnabled = true;
            this.extBox.Items.AddRange(new object[] {
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
            this.extBox.Location = new System.Drawing.Point(33, 43);
            this.extBox.Name = "extBox";
            this.extBox.Size = new System.Drawing.Size(137, 21);
            this.extBox.TabIndex = 25;
            this.extBox.Text = "*.*";
            // 
            // ContentsViewbox
            // 
            this.ContentsViewbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.absolutePath,
            this.Event,
            this.Timestamp});
            this.ContentsViewbox.Location = new System.Drawing.Point(11, 293);
            this.ContentsViewbox.Name = "ContentsViewbox";
            this.ContentsViewbox.Size = new System.Drawing.Size(477, 290);
            this.ContentsViewbox.TabIndex = 26;
            this.ContentsViewbox.UseCompatibleStateImageBehavior = false;
            this.ContentsViewbox.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            this.FileName.Tag = "";
            this.FileName.Text = "File Name";
            this.FileName.Width = 117;
            // 
            // absolutePath
            // 
            this.absolutePath.Text = "Path";
            this.absolutePath.Width = 117;
            // 
            // Event
            // 
            this.Event.Text = "Event";
            this.Event.Width = 85;
            // 
            // Timestamp
            // 
            this.Timestamp.Text = "Time Stamp";
            this.Timestamp.Width = 155;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStartFSW,
            this.toolStopFSW,
            this.toolStripSeparator2,
            this.ToolWriteToDB,
            this.toolOpenDBControls,
            this.toolStripSeparator3,
            this.toolAbout,
            this.toolHelp,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(500, 25);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStartFSW
            // 
            this.toolStartFSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStartFSW.Image = ((System.Drawing.Image)(resources.GetObject("toolStartFSW.Image")));
            this.toolStartFSW.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStartFSW.Name = "toolStartFSW";
            this.toolStartFSW.Size = new System.Drawing.Size(23, 22);
            this.toolStartFSW.Text = "toolStripButton1";
            this.toolStartFSW.ToolTipText = "Start FSW";
            this.toolStartFSW.Click += new System.EventHandler(this.btnStart_onStartWatch);
            // 
            // toolStopFSW
            // 
            this.toolStopFSW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStopFSW.Enabled = false;
            this.toolStopFSW.Image = ((System.Drawing.Image)(resources.GetObject("toolStopFSW.Image")));
            this.toolStopFSW.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStopFSW.Name = "toolStopFSW";
            this.toolStopFSW.Size = new System.Drawing.Size(23, 22);
            this.toolStopFSW.Text = "toolStripButton2";
            this.toolStopFSW.ToolTipText = "Stop FSW";
            this.toolStopFSW.Click += new System.EventHandler(this.btnStop_StopWatching);
            // 
            // ToolWriteToDB
            // 
            this.ToolWriteToDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolWriteToDB.Image = ((System.Drawing.Image)(resources.GetObject("ToolWriteToDB.Image")));
            this.ToolWriteToDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolWriteToDB.Name = "ToolWriteToDB";
            this.ToolWriteToDB.Size = new System.Drawing.Size(23, 22);
            this.ToolWriteToDB.Text = "toolStripButton3";
            this.ToolWriteToDB.ToolTipText = "Write to Database";
            this.ToolWriteToDB.Click += new System.EventHandler(this.OnWritetoDB_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolOpenDBControls
            // 
            this.toolOpenDBControls.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolOpenDBControls.Image = ((System.Drawing.Image)(resources.GetObject("toolOpenDBControls.Image")));
            this.toolOpenDBControls.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOpenDBControls.Name = "toolOpenDBControls";
            this.toolOpenDBControls.Size = new System.Drawing.Size(23, 22);
            this.toolOpenDBControls.Text = "toolStripButton4";
            this.toolOpenDBControls.ToolTipText = "Database Control Menu";
            this.toolOpenDBControls.Click += new System.EventHandler(this.onDatabaseControls_Click);
            // 
            // toolAbout
            // 
            this.toolAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolAbout.Image")));
            this.toolAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(23, 22);
            this.toolAbout.Text = "toolStripButton5";
            this.toolAbout.ToolTipText = "About Prompt";
            this.toolAbout.Click += new System.EventHandler(this.onAbouttab_Click);
            // 
            // toolHelp
            // 
            this.toolHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolHelp.Image")));
            this.toolHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHelp.Name = "toolHelp";
            this.toolHelp.Size = new System.Drawing.Size(23, 22);
            this.toolHelp.Text = "toolStripButton6";
            this.toolHelp.ToolTipText = "Help Menu";
            this.toolHelp.Click += new System.EventHandler(this.onFSWHelp_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // DirectoryGroup
            // 
            this.DirectoryGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.DirectoryGroup.Controls.Add(this.subdirectories);
            this.DirectoryGroup.Controls.Add(this.label1);
            this.DirectoryGroup.Controls.Add(this.groupBox2);
            this.DirectoryGroup.Controls.Add(this.extBox);
            this.DirectoryGroup.Controls.Add(this.label2);
            this.DirectoryGroup.Controls.Add(this.directoryBox);
            this.DirectoryGroup.Controls.Add(this.label4);
            this.DirectoryGroup.Controls.Add(this.btnStart);
            this.DirectoryGroup.Controls.Add(this.btnStop);
            this.DirectoryGroup.Location = new System.Drawing.Point(11, 52);
            this.DirectoryGroup.Name = "DirectoryGroup";
            this.DirectoryGroup.Size = new System.Drawing.Size(477, 110);
            this.DirectoryGroup.TabIndex = 0;
            this.DirectoryGroup.TabStop = false;
            this.DirectoryGroup.Text = "Directory";
            // 
            // subdirectories
            // 
            this.subdirectories.AutoSize = true;
            this.subdirectories.Location = new System.Drawing.Point(33, 87);
            this.subdirectories.Name = "subdirectories";
            this.subdirectories.Size = new System.Drawing.Size(128, 17);
            this.subdirectories.TabIndex = 31;
            this.subdirectories.Text = "Watch Subdirectories";
            this.subdirectories.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "(*.txt, *.gif, *.mov, etc)";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 89);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // DatabaseGroup
            // 
            this.DatabaseGroup.Controls.Add(this.writetodbbox);
            this.DatabaseGroup.Controls.Add(this.DBcontrols);
            this.DatabaseGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.DatabaseGroup.Location = new System.Drawing.Point(12, 168);
            this.DatabaseGroup.Name = "DatabaseGroup";
            this.DatabaseGroup.Size = new System.Drawing.Size(476, 100);
            this.DatabaseGroup.TabIndex = 29;
            this.DatabaseGroup.TabStop = false;
            this.DatabaseGroup.Text = "Database";
            // 
            // writetodbbox
            // 
            this.writetodbbox.Location = new System.Drawing.Point(228, 19);
            this.writetodbbox.Name = "writetodbbox";
            this.writetodbbox.Size = new System.Drawing.Size(241, 70);
            this.writetodbbox.TabIndex = 17;
            this.writetodbbox.Text = "Write to Database";
            this.writetodbbox.UseVisualStyleBackColor = true;
            this.writetodbbox.Click += new System.EventHandler(this.OnWritetoDB_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = false;
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(0, 3, 80, 2);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(89, 17);
            this.StatusLabel.Text = "Status: Stopped";
            // 
            // Timebar
            // 
            this.Timebar.Name = "Timebar";
            this.Timebar.Size = new System.Drawing.Size(0, 17);
            // 
            // FrontWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(500, 620);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ContentsViewbox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DirectoryGroup);
            this.Controls.Add(this.DatabaseGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrontWindow";
            this.Text = "File System Watcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closingEvent);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.DirectoryGroup.ResumeLayout(false);
            this.DirectoryGroup.PerformLayout();
            this.DatabaseGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox directoryBox;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button DBcontrols;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox extBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListView ContentsViewbox;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader absolutePath;
        private System.Windows.Forms.ColumnHeader Event;
        private System.Windows.Forms.ColumnHeader Timestamp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStartFSW;
        private System.Windows.Forms.ToolStripButton toolStopFSW;
        private System.Windows.Forms.ToolStripButton ToolWriteToDB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolOpenDBControls;
        private System.Windows.Forms.ToolStripButton toolAbout;
        private System.Windows.Forms.ToolStripButton toolHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.GroupBox DirectoryGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox DatabaseGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox subdirectories;
        private System.Windows.Forms.ToolStripMenuItem fSWHelpToolStripMenuItem;
        private System.Windows.Forms.Button writetodbbox;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startWatchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopWatchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Timebar;
    }
}

