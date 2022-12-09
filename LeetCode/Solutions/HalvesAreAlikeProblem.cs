using System.Linq;

namespace LeetCode.Solutions
{
    /// <summary>
    /// Class created to solve below Leetcode issue:
    /// https://leetcode.com/problems/determine-if-string-halves-are-alike/
    /// </summary>
    public static class HalvesAreAlikeProblem
    {
        public static bool Run(string s)
        {
            return HalvesAreAlike(s);
        }

        private static bool HalvesAreAlike(string s)
        {
            if (s.Length % 2 == 0)
            {
                int mid = s.Length / 2;
                string half1 = s.Substring(0, mid);
                string half2 = s.Substring(mid, mid);

                if (!string.IsNullOrEmpty(half1) && !string.IsNullOrEmpty(half2))
                {
                    int countHalf1 = half1.Count(x => x.Equals('a') || x.Equals('A')
                                            || x.Equals('e') || x.Equals('E')
                                            || x.Equals('i') || x.Equals('I')
                                            || x.Equals('o') || x.Equals('O')
                                            || x.Equals('u') || x.Equals('U'));
                    int countHalf2 = half2.Count(x => x.Equals('a') || x.Equals('A')
                                            || x.Equals('e') || x.Equals('E')
                                            || x.Equals('i') || x.Equals('I')
                                            || x.Equals('o') || x.Equals('O')
                                            || x.Equals('u') || x.Equals('U'));

                    return countHalf1 == countHalf2;
                }
            }

            return false;
        }
    }
}
