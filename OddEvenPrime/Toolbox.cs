using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPrime
{
    public class Toolbox
    {
        public static Boolean IsWhole(string inputToCheck)
        {
            bool confirmed = false;
            try
            {
                int x = int.Parse(inputToCheck);
                confirmed = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine("\nWhole numbers only!\n");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nThat number is too large!\n");
            }
            return confirmed;
        }

        public static Boolean IsEven(int x)
        {
            bool check = false;
            if ((x % 2) == 0)
            {
                check = true;
            }
            return check;
        }

        public static Boolean IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
