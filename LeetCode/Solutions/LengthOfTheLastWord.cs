namespace LeetCode.Solutions
{
    /// <summary>
    /// Class created to solve below Leetcode issue:
    /// https://leetcode.com/problems/length-of-last-word
    /// </summary>
    public static class LengthOfTheLastWord
    {
        public static int Run(string s)
        {
            return LengthOfLastWord(s);
        }

        /// <summary>
        /// "Hello World"
        /// " hello world   "
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static int LengthOfLastWord(string s)
        {
            if (!string.IsNullOrWhiteSpace(s))
            {
                s = s.Trim();
                int lastWhiteSpaceIndex = LastWhiteSpaceIndex(s);
                if (lastWhiteSpaceIndex > -1)
                {
                    string lastWord = s.Substring(lastWhiteSpaceIndex + 1);
                    if (!string.IsNullOrWhiteSpace(lastWord))
                        return lastWord.Length;
                }
                else if (!s.Contains(" "))
                {
                    return s.Length;
                }
            }
            return 0;
        }

        private static int LastWhiteSpaceIndex(string s)
        {
            return s.LastIndexOf(" ");
        }
    }
}
