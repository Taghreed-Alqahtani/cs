using System;
using System.Collections.Generic;

namespace tokenize_tweets
{
    class Program
    {
        static void Main(string[] args)
        {
            int count_h = 0;
            int count_m = 0;
            Console.WriteLine("enter tweet : ");
            string tweet = Console.ReadLine();
            List<string> found = new List<string>();
            foreach (var item in tweet.Split(' '))
            {
                if (item.StartsWith("#") || item.StartsWith("@"))
                {
                    found.Add(item);
                }

            }
            foreach (var item in found)
            {
                Console.WriteLine(item);
                if (item.StartsWith("#"))
                {
                    count_h++;
                }
                else if (item.StartsWith("@"))
                {
                    count_m++;

                }
            }

            Console.WriteLine("The number of hashtags: " + count_h);
            Console.WriteLine("The number of mentions: " + count_m);
        }
    }
}
