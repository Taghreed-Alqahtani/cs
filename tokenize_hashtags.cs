using System;
using System.Collections.Generic;
namespace ConsoleApp5
{
    class Program
    {
        static List<string> tokenizer(string source)
        {
            string[] tokens = source.Split(' ');
            List<string> hashtag = new List<string>();
            foreach (var word in tokens)
            {
                if (word[0] == '#') hashtag.Add(word);
            }
            return hashtag;
        }

        static void Main(string[] args)
        {
            List<string> tokens = tokenizer("hello #people I'am #taghreed");
            for (int i = 0; i < tokens.Count; i++)
            {
                Console.WriteLine(tokens[i]);
            }
        }
    }
}

