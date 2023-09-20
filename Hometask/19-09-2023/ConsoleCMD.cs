using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask._19_09_2023
{
    public class ConsoleCMD
    {
        public void RunTerminal()
        {
            bool lamp = true;
            string command;
            while (lamp)
            {
                command = Console.ReadLine();
                if(command =="finish")
                {
                    lamp = false;
                    return;
                }
                string path = Directory.GetCurrentDirectory();

                string[] cmds = command.Split(" ");
                switch (cmds[0])
                {
                    case "cd":
                        if (cmds[1]==".")
                        {
                            //parent folderga o'ta olmadim shuning uchun terminalni finish qildim
                            Directory.GetParent(path);
                            lamp = false;
                            break;

                        }
                        path = Path.Combine(path, cmds[1]);
                        Directory.SetCurrentDirectory(path);
                        break;
                    case "dir":
                        string[] dirs = Directory.GetDirectories(path);
                        foreach (string dir in dirs)
                        {
                            Console.WriteLine(dir);
                        }
                        break;
                    case "mkdir":
                        path = Path.Combine(path, cmds[1]);
                        Directory.CreateDirectory(path); 
                        break;
                        
                }
            }
        }
    }
}
