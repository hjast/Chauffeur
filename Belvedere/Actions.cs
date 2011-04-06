using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Belvedere
{
    /// <summary>
    ///  This contains all of the actions for Belvedere
    /// </summary>
    class Actions
    {
        public static void moveFile(string from, string to)
        {
            File.Move(from, to);
        }

        public static void deleteFile(string path)
        {
            File.Delete(path);
        }

        public static void renameFile(string from, string to)
        {
            File.Move(from, to);
        }
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="f"></param>
        public static void moveRecycleBin(File f)
        {
         //   FileIO.FileSystem.DeleteDirectory(path, FileIO.UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
        }

        public static void copyFile(string from, string to)
        {
            File.Copy(from, to);
        }

        public static void openFile(string path)
        {
            File.Open(path);
        }
    }
}
