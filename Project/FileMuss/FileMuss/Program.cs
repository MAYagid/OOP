using System;
using System.IO;

namespace FileMuss
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WindowHeight = 40;
            Directories current = new()
            {
                curdir = Directory.GetCurrentDirectory()
            };
            Commands comm = new();
            string com = "";
            while (true)
                
            {
                UserInterface.Print(current);
                comm.Command(current, com);
            }
        }
    }
}
