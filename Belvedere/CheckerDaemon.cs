using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Belvedere
{
    /// <summary>
    /// Use the file watcher and then run
    /// </summary>
    class CheckerDaemon
    {
        static List<FileSystemWatcher> FileWatchers { get; set; }
        
        public void Watch(Folder f)
        {
            FileSystemWatcher fsw = new FileSystemWatcher(f.Path);
            
            fsw.Changed += new FileSystemEventHandler(fsw_Changed);

            FileWatchers.Add(fsw);
        }

        public class FolderSystemWatcher : FileSystemWatcher
        {
            public Folder myFolder {get;set;}

            public FolderSystemWatcher(Folder f)
            {
                myFolder = f;
            }

            void fsw_Changed(object sender, FileSystemEventArgs e)
            {
                string fileChanged = e.FullPath;
                //for each rule check all the conditions
                foreach (BelevdereRule rule in myFolder.Rules)
                {
                    foreach (BelvedereCondition condition in rule.Conditions)
                    {
                        
                    }
                }
                Console.WriteLine(sender.GetType());
                throw new NotImplementedException();
            }
        }

      
        
    }
}
