/**********
 **
 **Name:Mckenzie Fernando
 **Class:CS132
 **Project: HOP04
 **Date:2020-08-03
 ** Return a string
 **
 *************/





using System;

namespace Scopes
{
    class Program
    {
        public static string Str2;

        static void ReturnString(string Str1)
        {
            Str2 = "Programming in C#";
            Console.Write(Str1);
        }

        static void Main()
        {
            ReturnString("CS132 ");
            Console.WriteLine(Str2);
        }
    }
}



