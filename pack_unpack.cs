using System;

namespace pack
{
    class Program
    {
        static void Main(string[] args)
        {
            uint value = 0;
            
            byte one = 5;
            byte two = 8;
            byte three = 201;
            byte four = 25;

            value = value | four;
            
                value= value << 24;
            
            value = value | three;
            
                value = value << 16;
            
            value = value | two;

                value = value << 8;
            
            value = value | one;
            
            Console.WriteLine(value);// pack one,two,three,four into value


            value = value | four;

            value = value >> 24;

            value = value | three;

            value = value >> 16;

            value = value | two;

            value = value >> 8;

            value = value & one;
            
            Console.WriteLine(value); // unpack value
        }

    }
}
