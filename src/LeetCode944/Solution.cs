namespace LeetCode944
{
    public class Solution
    {
        public int MinDeletionSize(string[] strs)
        {
            var n = strs.Length;
            if (n == 1)
            {
                return 0;
            }

            var strLength = strs[0].Length;
            var result = 0;
            for (var i = 0; i < strLength; i++)
            {
                for (var j = 1; j < n; j++)
                {
                    if (strs[j][i] < strs[j - 1][i])
                    {
                        result++;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
