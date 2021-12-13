namespace LeetCode1796
{
    public class Solution
    {
        public int SecondHighest(string s)
        {
            var numCount = new int[10];
            foreach (var c in s)
            {
                if (char.IsDigit(c))
                {
                    numCount[c - '0']++;
                }
            }

            for (var i = 9; i >= 0; i--)
            {
                var count = numCount[i];
                if (count > 0)
                {
                    for (var j = i - 1; j >= 0; j--)
                    {
                        count = numCount[j];
                        if (count > 0)
                        {
                            return j;
                        }
                    }

                    break;
                }
            }

            return -1;
        }
    }
}
