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
            Console.WriteLine($"Length of Last Word is: {LengthOfTheLastWord.Run("Hello World   mee")}");
            Console.WriteLine($"Number of Trailing Zeroes is: {NumberOfTrailingZeroes.Run(13)}");
        }
    }
}
