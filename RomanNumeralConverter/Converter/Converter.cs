using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralConverter
{
    public class Converter
    {
        readonly Dictionary<char, int> numeralMap = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public Converter()
        {

        }

        public int convert(string romanNumber)
        {
            return calculate(parse(romanNumber));
        }

        private List<int> parse(string romanNumber)
        {
            List<int> splitNumber = new List<int>();

            foreach (char c in romanNumber) {
                int value;

                if (!numeralMap.TryGetValue(c, out value))
                {
                   throw new FormatException($"Unknown roman numeral: {c}");
                }

                splitNumber.Add(value);
            }

            return splitNumber;
        }

        private int calculate(List<int> list)
        {
            int value = 0;
            int lastNumber = 0;

            foreach (int number in list)
            {
                if (lastNumber != 0)
                {
                    if (number > lastNumber)
                    {
                        value += number - lastNumber;
                        lastNumber = 0;
                    } else
                    {
                        value += lastNumber;
                        lastNumber = number;
                    }
                } else
                {
                    lastNumber = number;
                }
            }

            value += lastNumber;

            return value;
        }
    }
}
