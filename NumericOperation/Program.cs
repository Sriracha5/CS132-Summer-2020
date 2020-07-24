using System;

namespace numericOperators
{
    class Program
    {
        static void Main()
        {
            int num1 = 20; // identify first interger "20".
            int num2 = 77; // identify second interger "77".
            float num3 = 5.2f; // identify float "5.2"

            float sum = num1 + num2 + num3; // add two intergers
            int subtract = num2 - num1;   // take two numbers and subtract 
            int multiply = num1 * num2;   // take two numbers and multiply
            float divide = num1 / num3;   // take two numbers and divide
            int modulus = num2 % num1;    // find remeider between two numbers

            Console.WriteLine("sum of 3 numbers is: " + sum);
            Console.WriteLine("77 - 20 is: " + subtract);
            Console.WriteLine("20 * 77 is: " + multiply);
            Console.WriteLine("20 / 5.2 is:" + divide);
            Console.WriteLine("77 % 20 is: " + modulus);
        }
    }
}