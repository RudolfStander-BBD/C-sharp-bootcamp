using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class FizzBuzz
    {
        public static void printFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(getFizzBuzz(i) + " ");
            }
        }

        public static string getFizzBuzz(int number)
        {
            if (number <= 0 || number > 70)
            {
                throw new InvalidOperationException("Modulo arithmetic below zero gets weird-ish");
            }

            bool fizzy = isFizz(number);
            bool buzzy = isBuzz(number);

            if (fizzy && buzzy)
            {
                return "FizzBuzz";
            } else if (fizzy)
            {
                return "Fizz";
            }
            else if (buzzy)
            {
                return "Buzz";
            }

            return number.ToString();
        }

        public static bool isFizz(int number)
        {
            return number % 3 == 0;
        }

        public static bool isBuzz(int number)
        {
            return number % 5 == 0;
        }
    }

    public class FB
    {
        public static void Main()
        {
            FizzBuzz.printFizzBuzz();
        }
    }
}
