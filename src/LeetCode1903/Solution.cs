namespace LeetCode1903
{
    public class Solution
    {
        public string LargestOddNumber(string num)
        {
            var length = num.Length;
            for (var i = length - 1; i >= 0; i--)
            {
                var c = num[i];
                if (c == '0' || c == '2' || c == '4' || c == '6' || c == '8')
                {
                    continue;
                }

                return num.Substring(0, i + 1);
            }

            return string.Empty;
        }
    }
}
