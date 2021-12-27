using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileMuss
{
    public class Standart
    {
        public static void Print(string s,
                             int x = 0,
                             int y = 0,
                             ConsoleColor fg = ConsoleColor.DarkYellow,
                             ConsoleColor bg = ConsoleColor.Black
                             )
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bg;
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

    }
    public class Lines
    {
        int width;
        int height;
        string ch;

        public Lines(int W, string Ch, int H)
        {
            width = W;
            height = H;
            ch = Ch;
        }
        public Lines(int W, string Ch) : this(W, Ch, 0) { }
        public Lines(string Ch, int H) : this(0, Ch, H) { }

        

        public static void PrintLine(int X, int Y, string Ch, int W, int H)
        {
            if (H == 0)
            {
                for (int i = X; i < X + W; ++i)
                {
                    Standart.Print(Ch, i, Y);
                }
            }
            if (W == 0)
            {
                for (int j = Y; j < Y + H; ++j)
                {
                    Standart.Print(Ch, X, j);
                }
            }
        }

        public static void PrintLine(int X, int Y, Lines Line)
        {
            PrintLine(X, Y, Line.ch, Line.width, Line.height);
        }

        public static void PrintRect(int X, int Y, int W, int H)
        {
            PrintLine(X,Y, "═", W, 0);
            
            PrintLine(X, Y, "║", 0, H);
            PrintLine(X, Y + H, "═", W, 0);
            PrintLine(X + W -1, 0, "║", 0, H);
            Standart.Print("╔", X, Y);
            Standart.Print("╗", X+W-1, Y);
            Standart.Print("╚", X, Y + H);
            Standart.Print("╝", X + W - 1, Y + H);
            Console.SetCursorPosition(0, H+1);
            //Console.WriteLine("Hello");


        }
    }

    public class UserInterface
    {
        static int width = Console.WindowWidth;
        static int height = Console.WindowHeight;
        static string curdir;

        public static void Print(Directories D)
        {
            string curdir = D.GetDir();
            Console.Clear();
            Lines.PrintRect(0, 0, width / 2 - 1 , height - 8);
            Lines.PrintRect(width / 2, 0, width / 2 - 1, height - 8);
            //curdir = Directory.GetCurrentDirectory();            
            D.Print(D);
            Standart.Print(Directories.ShortDir(curdir), 3, 0, ConsoleColor.Yellow);
            Standart.Print("-->", 0, height - 7, ConsoleColor.Yellow);
        }


    }
}
