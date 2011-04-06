using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Belvedere
{
    public class Folder : 
    {
        private static List<Folder> Folders { get; set; }

        public String Name { get; set; }
        public String Path { get; set; }

        public List<BelevdereRule> Rules { get; set; }

        //TODO Make sure path is a file
        public Folder(String path)
        {
            Path = path;
            //Name = /* make the name just the last part */  
            Rules = new List<BelevdereRule>();
        }


        public static Folder GetNewFolder()
        {
            System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            // Set the help text description for the FolderBrowserDialog.
            folderBrowserDialog1.Description = 
            "Select the directory to watch.";

            // Do not allow the user to create new files via the FolderBrowserDialog.
            folderBrowserDialog1.ShowNewFolderButton = false;

            // Default to the My Documents folder.
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Personal;
            String folderName="";
                // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if( result == DialogResult.OK )
            {
                folderName = folderBrowserDialog1.SelectedPath;
            }

            return new Folder(folderName);
           // Microsoft.Win32.OpenFileDialog openFile = new Microsoft.Win32.OpenFileDialog();
            //openFile.  
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
