using System;

namespace Task2
{
    public class Str
    {
        public static string reverse(string st)
        {
            string st1 = "";
            foreach (char ch in st)
            {
                st1 = ch + st1;
            }
            return st1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            s = Str.reverse(s);
            Console.WriteLine(s);


        }
    }
}
