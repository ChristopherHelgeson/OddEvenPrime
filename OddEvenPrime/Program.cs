using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPrime
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool goAgain = true;
            string userInput = "";
            int parsedInput = 0;

            while (goAgain)
            {
                Console.Clear();
                Console.WriteLine("ODD OR EVEN. PRIME?\n\n");
                Console.Write("\nPlease enter a whole number: ");
                userInput = Console.ReadLine();
                if (Toolbox.IsWhole(userInput))
                {
                    parsedInput = int.Parse(userInput);
                    if (Toolbox.IsEven(parsedInput))
                    {
                        Console.Write($"\nYour number, {userInput}, is even ");
                    }
                    else
                    {
                        Console.Write($"\nYour number, {userInput}, is odd ");
                    }
                    if (Toolbox.IsPrime(parsedInput))
                    {
                        Console.WriteLine("and prime.\n");
                    }
                    else
                    {
                        Console.WriteLine("but not prime.\n");
                    }
                }
                goAgain = Repeat();
            }
        }

        public static Boolean Repeat()
        {
            bool repeat = false;
            Console.Write("Would you like to play again? (Y/N): ");
            string input = Console.ReadLine();
            if (input == "y" || input == "Y")
            {
                repeat = true;
            }
            return repeat;
        }
    }
}
