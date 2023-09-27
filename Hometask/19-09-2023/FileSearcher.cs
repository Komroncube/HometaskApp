using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask._19_09_2023
{
    public class FileSearcher
    {
        public void GetPathOfFile(string getfolder)
        {
            //Console.Write("File nomini kiriting: ");

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                if (SearchInDir(drive.Name, getfolder))
                {
                    return;
                }

            }
            /*if (file.Split('.').Length==2)
            {
                /*if (SearchInDir("D:\\", getfolder))
                {
                    return;
                }
                DriveInfo[] drives = DriveInfo.GetDrives();
           
                foreach(DriveInfo drive in drives)
                {
                    if (SearchInDir(drive.Name, file))
                    {
                        return;
                    }
                    
                }
            }*/

        }
        private bool SearchInDir(string path, string file)
        {
            string[] files;
            try
            {
                //Console.WriteLine(path);
                files = Directory.GetFiles(path);
            }
            catch 
            {
                return false;
            }

            string filepath=Path.Combine(path,file);
            if (files.Contains(filepath))
            {
                Console.WriteLine(filepath);
                return true;
            }
            string[] dirs = Directory.GetDirectories(path);
            foreach (var dir in dirs)
            {
                string path1 = Path.Combine(path, dir);
                bool check = SearchInDir(path1, file);
                if (check)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
