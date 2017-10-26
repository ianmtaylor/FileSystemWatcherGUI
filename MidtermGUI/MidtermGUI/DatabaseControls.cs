using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermGUI
{
    public partial class DatabaseControlsBox : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        SQLiteDataReader sqlite_datareader;

        public DatabaseControlsBox()
        {
            InitializeComponent();
        }

        private void onExitFromWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onQuery_Click(object sender, EventArgs e)
        {
            DBControlslist.Items.Clear();

            try
            {

                if (DBextbox.Text.Contains(" "))
                {
                    MessageBox.Show("Invalid extention -- No spaces allowed");
                }
                else if (!DBextbox.Text.Contains("."))
                {
                    MessageBox.Show("Needs a period. Look at the example....Gosh");
                }
                else if (!DBextbox.Text.Contains("*"))
                {
                    MessageBox.Show("The extension needs a \"*\"");
                }
                else if (DBextbox.Text == "")
                {
                    MessageBox.Show("Enter an extension");
                }
                else
                {
                    sqlite_conn = new SQLiteConnection("Data source=database.db;Version=3;New=True;Compressions=True");
                    sqlite_conn.Open();
                    sqlite_cmd = sqlite_conn.CreateCommand();

                    sqlite_cmd.CommandText = "SELECT * FROM WatcherDB;";
                    sqlite_datareader = sqlite_cmd.ExecuteReader();

                    while (sqlite_datareader.Read())
                    {
                        if (DBextbox.Text == "*.*" ||  "*"+sqlite_datareader["Extension"].ToString() == DBextbox.Text)
                        {
                            ListViewItem newQuery = new ListViewItem();

                            newQuery.SubItems[0].Text = sqlite_datareader["File"].ToString();
                            ListViewItem.ListViewSubItem ext = new ListViewItem.ListViewSubItem(newQuery, sqlite_datareader["Extension"].ToString());
                            ListViewItem.ListViewSubItem newPath = new ListViewItem.ListViewSubItem(newQuery, sqlite_datareader["Path"].ToString());
                            ListViewItem.ListViewSubItem newEvent = new ListViewItem.ListViewSubItem(newQuery, sqlite_datareader["Event"].ToString());
                            ListViewItem.ListViewSubItem newTimeStamp = new ListViewItem.ListViewSubItem(newQuery, sqlite_datareader["TimeStamp"].ToString());
                            newQuery.SubItems.Add(newPath);
                            newQuery.SubItems.Add(newEvent);
                            newQuery.SubItems.Add(newTimeStamp);
                            newQuery.SubItems.Add(ext);
                            DBControlslist.Items.Add(newQuery);
                        }
                    }


                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Query impossible....:" + Environment.NewLine + error.Message);
            }
        }

        private void onClearDB_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to drop the database?", "Drop Database", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == answer)
            {
                try
                {
                    sqlite_conn = new SQLiteConnection("Data source=database.db;Version=3;New=True;Compression=True;");
                    sqlite_conn.Open();
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "DROP TABLE IF EXISTS WatcherDB;";
                    sqlite_cmd.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: Database can't be cleared!!" + Environment.NewLine + error.Message);
                }

                MessageBox.Show("Database cleared");
                DBControlslist.Items.Clear();
            }
        }
    }
}
