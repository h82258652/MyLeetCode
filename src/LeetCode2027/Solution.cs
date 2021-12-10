namespace LeetCode2027
{
    public class Solution
    {
        public int MinimumMoves(string s)
        {
            var result = 0;

            var length = s.Length;
            for (var i = 0; i < length; i++)
            {
                var c = s[i];
                if (c == 'X')
                {
                    result++;
                    i += 2;
                }
            }

            return result;
        }
    }
}
