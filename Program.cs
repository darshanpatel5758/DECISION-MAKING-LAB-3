using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace DECISION_MAKING
{
    class Program
    {
        public static void MyMethod()
        {
            // User Input
            startloop:  Console.WriteLine("Enter a number between 1 and 100:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput >= 1 && userInput <= 100)
            {
                if (userInput % 2 != 0)
                {
                    Console.WriteLine("Output: " + userInput + " and odd");
                }
                else if (userInput % 2 == 0)
                {
                    if (userInput >= 2 && userInput <= 25)
                    {
                        Console.WriteLine("Output: Even and less than 25");
                    }
                    else if (userInput >= 26 && userInput <= 60)
                    {
                        Console.WriteLine("Output: Even ");
                    }
                    else
                    {
                        Console.WriteLine("Output: " + userInput + " Even ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter number 1 and 100");
                goto startloop;
            }
            
        }

        static void Main(string[] args)
        {
            

            bool isLooping = true;
            while(isLooping)
            {
                MyMethod();

                Console.WriteLine("Continue? (y/n) : ");
                string userInput2 = Console.ReadLine();

               if (userInput2.Equals("y", StringComparison.OrdinalIgnoreCase))
               {
                    continue;
               }
               else
               {
                
                isLooping = false;
                Console.WriteLine("Bye!");
                }
            }
        }
    }
}
