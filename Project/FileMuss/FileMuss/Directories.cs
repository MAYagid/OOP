using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileMuss
{
    public class Directories
    {
        public string curdir { get; set; }

        public string GetDir()
        {
            return Directory.GetCurrentDirectory();
        }
        public void SetDir(string St)
        {
            curdir = St;
            Directory.SetCurrentDirectory(St);
        }

        public static string ShortDir(string St)
        {
            string newSt = St;
            string[] vs = St.Split('\\');
            if (vs.Length > 4)
            {
                newSt = vs[0] + '\\' + vs[1] + "\\...\\" + vs[vs.Length - 2] + '\\' + vs[vs.Length - 1];
                return newSt;
            }
            return newSt;

        }

        public void Print(Directories D)
        {
            string Dir = D.curdir;
            var dir = Directory.GetDirectories(D.curdir);
            var files = Directory.GetFiles(D.curdir);
            string stDir;
            Standart.Print("..", 2, 1, ConsoleColor.Yellow);
            Standart.Print("..", Console.WindowWidth / 2 + 3, 1, ConsoleColor.Yellow);
            for (int i = 0; i < dir.Length % 30; i++)
            {
                string[] vs = dir[i].Split('\\');
                stDir = vs[vs.Length - 1];
                Standart.Print(stDir+'\n', 2, i+2, ConsoleColor.Yellow);
                
            }
            for (int i = 0; i < files.Length % 30; ++i)
            {
                string[] vf = files[i].Split('\\');
                string stFile = vf[vf.Length - 1];
                Standart.Print(stFile + '\n', Console.WindowWidth / 2 + 3, i + 2, ConsoleColor.Yellow);
            }
        }
    }
}
