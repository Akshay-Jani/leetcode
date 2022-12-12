using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions
{
    /// <summary>
    /// Class created to solve below Leetcode issue:
    /// https://leetcode.com/problems/integer-to-roman/
    /// </summary>
    public static class IntegerToRoman
    {
        public static string Run(int num)
        {
            return IntToRoman(num);
        }

        private static string IntToRoman(int num)
        {
            string result = string.Empty;

            if (num > 0)
            {
                Dictionary<int, string> config = new Dictionary<int, string>()
                {
                    { 1000, "M" },
                    { 900, "CM" },
                    { 500, "D" },
                    { 400, "CD" },
                    { 100, "C" },
                    { 90, "XC" },
                    { 50, "L" },
                    { 40, "XL" },
                    { 10, "X" },
                    { 9, "IX" },
                    { 5, "V" },
                    { 4, "IV" },
                    { 1, "I" },
                };

                if (config.ContainsKey(num))
                    return config[num];

                bool stopIteration = false;
                int startingPoint = config.Keys.FirstOrDefault(x => x <= num);
                int previousStartingPoint = startingPoint;
                int remainder = 0;
                int quotient = 0;

                while (!stopIteration)
                {
                    remainder = num % startingPoint;
                    quotient = num / startingPoint;

                    for (int i = 1; i <= quotient; i++)
                    {
                        result += config[startingPoint];
                    }

                    previousStartingPoint = startingPoint;
                    startingPoint = config.Keys.FirstOrDefault(x => x <= remainder);
                    num = remainder;

                    stopIteration = startingPoint == 0 || startingPoint == previousStartingPoint;
                }
            }

            return result;
        }
    }
}
