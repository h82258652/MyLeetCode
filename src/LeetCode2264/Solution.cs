namespace LeetCode2264
{
    public class Solution
    {
        public string LargestGoodInteger(string num)
        {
            var length = num.Length;
            var result = string.Empty;
            for (var i = 0; i < length - 2; i++)
            {
                if (num[i] != num[i + 1] || num[i + 1] != num[i + 2])
                {
                    continue;
                }

                if (result.Length == 0 || num[i] > result[0])
                {
                    result = new string(num[i], 3);
                }
            }

            return result;
        }
    }
}
