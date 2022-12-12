using LeetCode.Solutions;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Integer is: {RomanToInteger.RomanToInt("III")}");
            Console.WriteLine($"Answer is: {HalvesAreAlikeProblem.Run("Textbook")}");
            Console.WriteLine($"Roman is: {IntegerToRoman.Run(1994)}");
        }
    }
}
