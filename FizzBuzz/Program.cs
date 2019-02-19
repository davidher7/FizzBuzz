using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {  
            // Declaring vars for multiples
            var F = 3;
            var B = 5;

            // A 'for' loop that stops at 100
            for (int x = 1; x < 101; x++)
            {
                // This checks if both vars have the same multiple
                if (x % F == 0 && x % B == 0)
                {
                    Console.WriteLine("FizzBuzz"); // Writes FizzBuzz if true

                }
                // This checks if its a multiple of 3
                else if (x % F == 0)
                {
                    Console.WriteLine("Fizz"); // Writes Fizz if true 

                }
                // This checks if its a mutiple of 5
                else if (x % B == 0)
                {
                    Console.WriteLine("Buzz"); // Writes Buzz if true

                }
                // If none are true then the loop continues writing to 100
                else
                {
                    Console.WriteLine(x);

                }
            }
        }
    }
}
