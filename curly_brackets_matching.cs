using System;

namespace brackets_matching
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(match(text));
        }
        static bool match(string a)// curly brackets matching
        {
            int x = 0;
            foreach (var item in a)
            {
                if (item == '{') x++;
                else if (item == '}') x--;

                if (x < 0) return false;
            }
            return x == 0;
        }
    }
}
