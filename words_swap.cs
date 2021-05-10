using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            swap("hello world taghreed amal"); // world hello amal taghreed
        }
        public static void swap(string word)
        {
            string[] array = word.Split(' ');
     
            for (int x = 0; x < array.Length; x+=2)
            {
                string temp = array[x];
                array[x] = array[x + 1];
                array[x + 1] = temp;
            }
            for (int y = 0; y < array.Length; y++)
            {
                Console.Write(array[y]+" ");

            }
        }
    }
}
