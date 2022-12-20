using System.Linq;

namespace LeetCode.Solutions
{
    /// <summary>
    /// Class created to solve below Leetcode issue:
    /// https://leetcode.com/problems/factorial-trailing-zeroes/
    /// </summary>
    public static class NumberOfTrailingZeroes
    {
        public static int Run(int n)
        {
            return n == 0 ? 0 : n / 5 + Run(n / 5);
        }

        private static int TrailingZeroes(int n)
        {
            if (n > 0)
            {
                int factorialValue = GetFactorial(n);

                if (factorialValue > 0)
                {
                    //return CheckIfDividedByTen(factorialValue, 0);
                    return factorialValue.ToString().Count(x => x == '0');
                }
            }
            return 0;
        }

        private static int GetFactorial(int n)
        {
            return n == 1 ? n : n * GetFactorial(n - 1);
        }

        private static int CheckIfDividedByTen(int n, int count)
        {
            return n % 10 == 0 ? CheckIfDividedByTen(n / 10, count + 1) : count;
        }
    }
}
