using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winningNum = r.Next(0, 100);

            bool won = false;

            do
            {
                Console.Write("Guess a number between 0 and 100: ");
                string input = Console.ReadLine();

                int i = int.Parse(input);

                if (i > winningNum)
                {
                    Console.WriteLine("TOO HIGH! Guess lower!");
                }
                else if (i < winningNum)
                {
                    Console.WriteLine("TOO LOW! Guess higher!");
                }
                else if (i == winningNum)
                {
                    Console.WriteLine("YOU WIN! Good job!");
                    won = true;
                }

                Console.WriteLine();
            } while (won == false);

            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
