using System;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 100; i++) 
            { 
                string printwords = "";
                if (i%3 == 0)
                {
                    printwords = printwords += "Fizz";
                }
                if (i%5 == 0)
                {
                    printwords = printwords += "Buzz";
                }

                if (printwords != "")
                {
                    Console.WriteLine(printwords);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}