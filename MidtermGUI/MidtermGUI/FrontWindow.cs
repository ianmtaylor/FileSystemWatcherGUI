/*Author: Ian Taylor
 *Date: October 2017 Fall Quarter
 *Project: File System Watcher GUI midterm
 * 
 *All Controls concerning the database query and clear are located in the form DatabaseControls. There are multiple buttons to get to the form laid out
 *throughout the GUI. The "write to database" button is still located on the main window.
 * 
 * EXTRA CREDIT (hopefully)
 * --------------------------
 * Status Bar at bottom that displays time, and status of FSW (changes color based on running/stopped and displays a status label indicator)
 * 
 */




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Security.Permissions;

namespace MidtermGUI
{
    public partial class FrontWindow : Form
    {

        delegate void SetTextCallback(FileSystemEventArgs e);


        FileSystemWatcher watch = null;
        private static SQLiteConnection sqlite_conn;
        private static SQLiteCommand sqlite_cmd;
        private static string hasBeenDone;
        private static string strBeenDone;

        public FrontWindow()
        {
            InitializeComponent();

            Timer timeStamp = new Timer();
            timeStamp.Interval = 1000;
            timeStamp.Tick += timeTick;
            timeStamp.Start();
        }

        private void timeTick(Object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString();

            string[] newtime = time.Split(' ');
            Timebar.Text = "Time : " + newtime[1] + " " +newtime[2];
        }

        private void btnStart_onStartWatch(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(directoryBox.Text))
                {
                    MessageBox.Show("Invalid Directory");
                }
                else if (extBox.Text.Contains(" "))
                {
                    MessageBox.Show("Invalid extention -- No spaces allowed");
                }
                else if (!extBox.Text.Contains("."))
                {
                    MessageBox.Show("Needs a period. Look at the example....Gosh");
                }
                else if (!extBox.Text.Contains("*"))
                {
                    MessageBox.Show("The extension needs a \"*\"");
                }
                else if (extBox.Text == "")
                {
                    MessageBox.Show("Enter an extension");
                }
                else
                {
                    /********Directory Group Box *********///remember to edit as you add new items
                   
                    this.btnStart.Enabled = false;
                    this.btnStop.Enabled = true;
                    this.extBox.Enabled = false;
                    this.subdirectories.Enabled = false;
                    
                    this.directoryBox.Enabled = false;

                    /**********Database Group Box **********/
                    DBcontrols.Enabled = false;
                    writetodbbox.Enabled = false;


                    /*************Toolbar******************/
                    toolStartFSW.Enabled = false;
                    toolStopFSW.Enabled = true;
                    ToolWriteToDB.Enabled = false;
                    toolOpenDBControls.Enabled = false;
                    toolAbout.Enabled = false;
                    toolHelp.Enabled = false;
                    /*************Menu*********************/
                    exitToolStripMenuItem.Enabled = false;
                    startWatchingToolStripMenuItem.Enabled = false;
                    stopWatchingToolStripMenuItem.Enabled = true;
                    writeToDatabaseToolStripMenuItem.Enabled = false;
                    queryToolStripMenuItem.Enabled = false;
                    aboutToolStripMenuItem.Enabled = false;
                    fSWHelpToolStripMenuItem.Enabled = false;
                    /***************status Bar **************/
                    statusStrip1.BackColor = Color.LimeGreen;
                    StatusLabel.Text = "Status: Running";
                    
                    /************Run Watcher ***************/
                    if (watch == null)
                    {
                        watch = new FileSystemWatcher();
                        Run(watch);
                    }
                    else
                    {
                        resumeFSW(watch);
                    }

                    
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Error with watcher!!!" + Environment.NewLine + error.Message);
                btnStop_StopWatching(this, new EventArgs());
            }
        }
        private void btnStop_StopWatching(object sender, EventArgs e)//reverse everything
        {
            try
            {
                /********Directory Group Box *********///remember to edit as you add new items
                this.directoryBox.Enabled = true;
                this.btnStart.Enabled = true;
                this.btnStop.Enabled = false;
                this.extBox.Enabled = true;
                this.subdirectories.Enabled = true;
               

                /**********Database Group Box **********/
                DBcontrols.Enabled = true;
                writetodbbox.Enabled = true;

                /*************Toolbar******************/
                toolStartFSW.Enabled = true;
                toolStopFSW.Enabled = false;
                ToolWriteToDB.Enabled = true;
                toolOpenDBControls.Enabled = true;
                toolAbout.Enabled = true;
                toolHelp.Enabled = true;
                /*************Menu*********************/
                exitToolStripMenuItem.Enabled = true;
                startWatchingToolStripMenuItem.Enabled = true;
                stopWatchingToolStripMenuItem.Enabled = false;
                writeToDatabaseToolStripMenuItem.Enabled = true;
                queryToolStripMenuItem.Enabled = true;
                aboutToolStripMenuItem.Enabled = true;
                fSWHelpToolStripMenuItem.Enabled = true;
                /***************Status Bar***************/
                statusStrip1.BackColor = Color.DarkCyan;
                StatusLabel.Text = "Status: Stopped";
                /************Stop Watcher ***************/
                PauseFSW(watch);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: can't stop watching!!! " + Environment.NewLine + error.Message);
            }
        }

        private void PauseFSW(FileSystemWatcher e)
        {
            e.EnableRaisingEvents = false;
        }

        private void resumeFSW(FileSystemWatcher e)
        {
            e.EnableRaisingEvents = true;
        }

        private void SetText(FileSystemEventArgs e)
         {

             if (this.ContentsViewbox.InvokeRequired)
             {
                 SetTextCallback d = new SetTextCallback(SetText);
                 this.Invoke(d, new object[] { e });
             }
             else
             {
                ListViewItem newEntry = new ListViewItem(Path.GetFileName(e.Name));
                ListViewItem.ListViewSubItem ext = new ListViewItem.ListViewSubItem(newEntry, Path.GetExtension(e.Name));
                ListViewItem.ListViewSubItem newPath = new ListViewItem.ListViewSubItem(newEntry, e.FullPath);
                ListViewItem.ListViewSubItem newEvent = new ListViewItem.ListViewSubItem(newEntry, e.ChangeType.ToString());
                ListViewItem.ListViewSubItem newTimeStamp = new ListViewItem.ListViewSubItem(newEntry, DateTime.Now.ToString());
                newEntry.SubItems.Add(newPath);
                newEntry.SubItems.Add(newEvent);
                newEntry.SubItems.Add(newTimeStamp);
                newEntry.SubItems.Add(ext);
                ContentsViewbox.Items.Add(newEntry);
            }
         }
         




        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public void Run(FileSystemWatcher watcher)
        {
            string path = this.directoryBox.Text;
           
            
            // Create a new FileSystemWatcher and set its properties.
            watcher.Path = path;
            /* Watch for changes in LastAccess and LastWrite times, and
               the renaming of files or directories. */
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            
            watcher.Filter = "*"+this.extBox.Text;
            if (this.subdirectories.Checked == true)
                watcher.IncludeSubdirectories = true;
            else
                watcher.IncludeSubdirectories = false;


            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            // Begin watching.
            watcher.EnableRaisingEvents = true;
            hasBeenDone = "@";
            strBeenDone = "@";
        }

        public static string getExtension(string path)
        {
            if (path == null || path.Length == 0)
                return "Invalid";
            if (path.LastIndexOf(".") == -1)
                return "Invalid";
            return path.Substring(path.LastIndexOf("."));
        }

        // Define the event handlers.

        private  void OnChanged(object source, FileSystemEventArgs e)
        {
            
            System.DateTime date;
            date = System.DateTime.Now;

            if (e.FullPath.Contains("database.db") || e.FullPath.Contains("database.db-journal"))
            {
                return;
            }
            else if (e.FullPath.Contains(".ide") || e.FullPath.Contains("Assignment2"))
            {
                return;
            }
            else if (e.FullPath.Equals(strBeenDone) && date.ToString().Equals(hasBeenDone))
            {
                return;
            }

            hasBeenDone = date.ToString();
            strBeenDone = e.FullPath;

            SetText(e);
           
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            
            System.DateTime date;
            date = System.DateTime.Now;

            if (e.FullPath.Contains("database.db") || e.FullPath.Contains("database.db-journal"))
            {
                return;
            }
            else if (e.FullPath.Contains(".ide") || e.FullPath.Contains("Assignment2"))
            {
                return;
            }
            else if (e.FullPath.Equals(strBeenDone) && date.ToString().Equals(hasBeenDone))
            {
                return;
            }

            // Specify what is done when a file is renamed.
            hasBeenDone = date.ToString();
            strBeenDone = e.FullPath;
            SetText(e);
            
        }

        private void onFSWHelp_Click(object sender, EventArgs e)
        {
            FSWhelp helpForm = new FSWhelp();
            helpForm.ShowDialog();
        }

        private void onAbouttab_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOU have chosen to click my About tab.\n I guess you can say you really...know how to press my buttons....\nNo? okay then...\n" +
                "This program was created by Ian Taylor, October 2017");
        }

        private void OnWritetoDB_Click(object sender, EventArgs e)
        {
            try
            {
                sqlite_conn = new SQLiteConnection("Data source=database.db;Version=3;New=True;Compression=True;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();


                sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS WatcherDB (File text, Path text, Event text, TimeStamp text, Extension text);";
                sqlite_cmd.ExecuteNonQuery();

               
               foreach (ListViewItem viewbox in ContentsViewbox.Items)
               {
                    sqlite_cmd.CommandText = "INSERT INTO WatcherDB (File, Path, Event, TimeStamp, Extension) VALUES (?, ?, ?, ?, ?);";
                    sqlite_cmd.Parameters.Add("@File", DbType.String).Value = viewbox.SubItems[0].Text;
                    sqlite_cmd.Parameters.Add("@Path", DbType.String).Value = viewbox.SubItems[1].Text;
                    sqlite_cmd.Parameters.Add("@Event", DbType.String).Value = viewbox.SubItems[2].Text;
                    sqlite_cmd.Parameters.Add("@TimeStamp", DbType.String).Value = viewbox.SubItems[3].Text;
                    sqlite_cmd.Parameters.Add("@Extension", DbType.String).Value = viewbox.SubItems[4].Text;
                    sqlite_cmd.ExecuteNonQuery();
               }


                ContentsViewbox.Items.Clear();

                sqlite_conn.Close();

                MessageBox.Show("Successfully written to database");
            }
            catch (Exception err)
            {
                MessageBox.Show("Could not write to database:" + Environment.NewLine + err.Message);
            }
        }

        private void closingEvent(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show("Would you like to save the contents to the database? Otherwise, the information will be gone...forever", "Don't leave me", MessageBoxButtons.YesNoCancel);
            if (DialogResult.Cancel == answer)
                e.Cancel = true;
            else if (DialogResult.Yes == answer)
            {
                if(watch != null)
                    btnStop_StopWatching(this, new EventArgs());
                OnWritetoDB_Click(this, new EventArgs());

            }
            else
            {
                if(watch != null)
                    btnStop_StopWatching(this, new EventArgs());
            }
        }

        private void onDatabaseControls_Click(object sender, EventArgs e)
        {
            DatabaseControlsBox dbform = new DatabaseControlsBox();
            dbform.ShowDialog();
        }

        private void onExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
