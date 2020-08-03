






using System;

namespace Methods
{
    class Program
    {
        //this is a method called Adding that take in 2 parameters
        //both of type interger
        public static int Adding(int num1, int num2)
        {
            
            
            //the passed in intergers are added
            //and the result is stored in the interger "sum"
            int sum = num1 + num2;
            return sum; // return the value stored in "sum

        }
        //this is a method called "Main",
        // this method is called when the program is ran 
        static void Main()
        {
            //call method "Adding" and pass in 2 parameters: 10 and 20 
            //and print the result of method "Adding"
            Console.WriteLine(Adding(10,20));
        }
    }
}       
