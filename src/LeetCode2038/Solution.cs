namespace LeetCode2038
{
    public class Solution
    {
        public bool WinnerOfGame(string colors)
        {
            var length = colors.Length;
            if (length < 3)
            {
                return false;
            }

            var aCount = 0;
            var bCount = 0;
            for (var i = 2; i < length; i++)
            {
                var c1 = colors[i - 2];
                var c2 = colors[i - 1];
                var c3 = colors[i];
                if (c1 == 'A' && c2 == 'A' && c3 == 'A')
                {
                    aCount++;
                }
                else if (c1 == 'B' && c2 == 'B' && c3 == 'B')
                {
                    bCount++;
                }
            }

            return aCount > bCount;
        }
    }
}
