namespace LeetCode.Solutions
{
    /// <summary>
    /// Class created to solve below Leetcode issue:
    /// https://leetcode.com/problems/roman-to-integer/
    /// </summary>
    public static class RomanToInteger
    {
        public static int RomanToInt(string s, int sum = 0, int current = 0)
        {
            if (!string.IsNullOrEmpty(s))
            {
                if (current >= s.Length)
                    return sum;

                bool skipTwo = false;

                switch (s[current].ToString())
                {
                    case "I":
                        if ((current + 1) < s.Length && s[current + 1].ToString() == "V")
                        {
                            skipTwo = true;
                            sum += 4;
                        }
                        else if ((current + 1) < s.Length && s[current + 1].ToString() == "X")
                        {
                            skipTwo = true;
                            sum += 9;
                        }
                        else
                        {
                            sum += 1;
                        }

                        break;
                    case "V":
                        sum += 5;
                        break;
                    case "X":
                        if ((current + 1) < s.Length && s[current + 1].ToString() == "L")
                        {
                            skipTwo = true;
                            sum += 40;
                        }
                        else if ((current + 1) < s.Length && s[current + 1].ToString() == "C")
                        {
                            skipTwo = true;
                            sum += 90;
                        }
                        else
                        {
                            sum += 10;
                        }

                        break;
                    case "L":
                        sum += 50;
                        break;
                    case "C":
                        if ((current + 1) < s.Length && s[current + 1].ToString() == "D")
                        {
                            skipTwo = true;
                            sum += 400;
                        }
                        else if ((current + 1) < s.Length && s[current + 1].ToString() == "M")
                        {
                            skipTwo = true;
                            sum += 900;
                        }
                        else
                        {
                            sum += 100;
                        }

                        break;
                    case "D":
                        sum += 500;
                        break;
                    case "M":
                        sum += 1000;
                        break;
                }

                if (skipTwo)
                    current += 2;
                else
                    current++;
                return RomanToInt(s, sum, current);
            }
            return 0;
        }
    }
}
