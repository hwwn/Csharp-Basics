using System;

namespace Treehouse.CodeChallenges
{
    class Program
    {
        static void Main()
        {

            Console.Write("Enter the number of times to print \"Yay!\": ");

            try
            {
                var times = double.Parse(Console.ReadLine());

                if(times < 0)
                {
                    Console.WriteLine("You must enter a positive number.");
                }
                else if(times == (int)times)
                {
                    var i = 0;

                    while(i < (int)times)
                    {
                        Console.Write("\"Yay!\"");

                        i += 1;

                        Console.WriteLine("The loop has run " + i + " times.");
                    }
                }
                else
                {
                    Console.WriteLine("You must enter a whole number.");
                }
            }

            catch(FormatException)
            {
                Console.WriteLine("That is not valid input."); 
            }
        }
    }
}
