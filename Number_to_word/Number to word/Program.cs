using System;

namespace Number_to_word
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("one");
                if  (num == 2)
                {

                    Console.WriteLine("two");
                    if (num == 3)
                    { 
                     Console.WriteLine("three")
                    }
                }
            }
        }
    }
