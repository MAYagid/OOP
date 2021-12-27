using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileMuss
{
    public class Commands
    {
        //string curdir = Directory.GetCurrentDirectory();
        //string command;

        public void Command(Directories D ,string Cur)
        {
            string com = Console.ReadLine();
            if (com.StartsWith("cd")) cd(D, com.Substring(3));
            if (com.StartsWith("md")) md(D, com.Substring(3));
            if (com.StartsWith("mf")) mf(D, com.Substring(3));
            if (com.StartsWith("deldir")) deldir(D, com.Substring(7));
            if (com.StartsWith("delf")) delfile(D, com.Substring(5));
            if (com.StartsWith("ren"))
            {
                string[] vs = com.Split(' ');
                ren(D, vs[1], vs[2]);
            }
            if (com == "exit") Environment.Exit(0);
        }

        public void cd(Directories D, string dir)
        {

            if (Directory.Exists(dir)) Directory.SetCurrentDirectory(dir);
            else if (Directory.Exists(D.curdir + '\\' + dir)) Directory.SetCurrentDirectory(D.curdir + '\\' + dir);
            else if (Directory.Exists(@"C:\" + dir)) Directory.SetCurrentDirectory(@"C:\" + dir);
            else if (dir == "..") {
                var path = Path.GetDirectoryName(D.curdir);
                Directory.SetCurrentDirectory(path);
            }
            D.curdir = Directory.GetCurrentDirectory();
        }

        public void md(Directories D, string name)
        {
            if (name != "") 
                Directory.CreateDirectory(D.curdir + '\\' + name);
        }

        public void mf(Directories D, string Name)
        {
            if (Name != "")
            {
                var fs = File.Create(D.curdir + '\\' + Name);
                fs.Close();
            }
        }

        public void deldir(Directories D, string Name)


        {
            if (Name != "")
            {
                var Dir = D.curdir + '\\' + Name;
                //Standart.Print(Dir, 0, Console.WindowHeight - 6);
                //
                if (Directory.Exists(Dir))
                {
                    string[] dirs = Directory.GetDirectories(Dir);
                    if (dirs.Length != 0)
                    {
                        Standart.Print("--> You really want to delete the folder " + Name + "? (y/n) ", 0, Console.WindowHeight - 6, ConsoleColor.Yellow);
                        var answ = Console.ReadLine();
                        if (answ == "y" || answ == "Y") Directory.Delete(Dir, true);
                    }
                    else
                    {
                        Directory.Delete(Dir);
                    }
                }
            }
        }

        public void delfile(Directories D, string Name)
        {
            var Dir = D.curdir + '\\' + Name;
            if (File.Exists(Dir))
            {
                Standart.Print("--> You really want to delete the file " + Name + "? (y/n) ", 0, Console.WindowHeight - 6, ConsoleColor.Yellow);
                var answ = Console.ReadLine();
                if (answ == "y" || answ == "Y") File.Delete(Dir);
            }
        }

        public void ren(Directories D, string OldName, string NewName)
        {
            var OldDir = D.curdir + '\\' + OldName;
            var NewDir = D.curdir + '\\' + NewName;
            Directory.Move(OldDir, NewDir);

        }
    }
}
