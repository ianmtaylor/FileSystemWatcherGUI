/*Author: Ian Taylor
 * Credit: Most of the basic FileSystemWatcher code came from the MSDN page
 * Summary: Basic filesystemwatcher from the MSDN page but modified. It is modified to create or append a SQLite database located in the debug folder.
 *          The SQLite dll file used to make a database is located in the solution folder.
 *          Concerning omitting the database file, I tested and ran my omitting if statements. I had to omit a couple other extensions because they were
 *          giving me problems.
 *          I also had the problem (now fixed) of having multiple event calls for a single action. I solved this by keeping two global PRIVATE strings
 *          (for time stamp and the fullpath) to perform some extra condition checking. If they have the same path & timestamp, it will cancel the event.
 *          This program WILL call an event for a folder change inside the path specified (folder changed because file inside changed).
 */
using System;
using System.IO;
using System.Security.Permissions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Assignment2
{
    
    public class Watcher
    {
        
        private static int id;
        private static string hasBeenDone;
        private static string strBeenDone;

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public static void Run(FileSystemWatcher watcher)
        {
            string path = "";
            bool exists = false;

            while (exists == false)
            {
                Console.WriteLine("Enter the path to watch: ");
                path = Console.ReadLine();
                if (Directory.Exists(path))
                {
                    exists = true;
                }
            }

            // If a directory is not specified, exit program.
            if ( !File.Exists(path) && (!(System.IO.Directory.Exists(path))))
            {
                // Display the proper way to call the program.
                Console.WriteLine("Usage: Watcher.exe (directory)");
                return;
            }

/*
            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS logfile (Filename text, oldPath text, newPath text, Change text, TimeStamp text);";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
            */
            // Create a new FileSystemWatcher and set its properties.
            watcher.Path = path;
            /* Watch for changes in LastAccess and LastWrite times, and
               the renaming of files or directories. */
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Only watch text files.
            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = true;
            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            // Begin watching.
            watcher.EnableRaisingEvents = true;
            hasBeenDone = "@";
            strBeenDone = "@";
            // Wait for the user to quit the program.
            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;
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
        
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            /*
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
            // Specify what is done when a file is changed, created, or deleted.
            sqlite_conn.Open();
            sqlite_cmd.CommandText = "INSERT INTO logfile (Filename, oldPath, newPath, Change, TimeStamp) VALUES ('File: " + e.Name + "', 'OldPath:" + null +"', 'NewPath: " + e.FullPath + "', 'Change: " + e.ChangeType + "', 'TimeStamp: " + date + "');";
            sqlite_cmd.ExecuteNonQuery();
            Console.WriteLine("File: " + e.Name + "; Path:" + e.FullPath + "; Change: " + e.ChangeType + "; TimeStamp: " + date);
            id++;
            sqlite_conn.Close();
            */
        }

        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            /*
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
            sqlite_conn.Open();
            sqlite_cmd.CommandText = "INSERT INTO logfile (Filename, oldPath, newPath, Change, TimeStamp) VALUES ('File: " + e.Name + "', 'OldPath:" + e.OldFullPath + "', 'NewPath: "+e.FullPath+"', 'Change: " + e.ChangeType + "', 'TimeStamp: " + date + "');";
            sqlite_cmd.ExecuteNonQuery();
            Console.WriteLine("File: " + e.Name + "; OldPath:" + e.OldFullPath + "' NewPath: " + e.FullPath + "; Change: " + e.ChangeType + "; TimeStamp: " + date);
            id++;
            sqlite_conn.Close();
            */
        }
        
    }
}
