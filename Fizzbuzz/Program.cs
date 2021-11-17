using System;
using System.Collections.Generic;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 255; i++) 
            { 
                // Creating a list of strings
                List<string> words = new List<string>();
                
                if (i%3 == 0)
                {
                    words.Add("Fizz");
                }
                if (i%5 == 0)
                {
                    words.Add("Buzz");
                }
                
                if (i%7 == 0)
                {
                    words.Add("Bang");
                }

                if (i%11 == 0)
                {
                    words.Clear();
                    words.Add("Bong");
                }

                if (i % 13 == 0)
                {
                    if (words.Contains("Bang"))
                    {
                        int j = words.IndexOf("Bang");
                        words.Insert(j, "Fezz");
                    }
                    else if (words.Contains("Bong"))
                    {
                        int j = words.IndexOf("Bong");
                        words.Insert(j, "Fezz");
                    }
                    else if (words.Contains("Buzz"))
                    {
                        int j = words.IndexOf("Buzz");
                        words.Insert(j, "Fezz");
                    }
                    else
                    {
                        words.Add("Fezz");
                    }
                    
                }

                if (i % 17 == 0)
                {
                    words.Reverse();
                }
                    
                    
                int listLength = words.Count;

                if (listLength == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    words.ForEach(Console.Write);
                    Console.WriteLine();
                }
            }
        }
    }
}

