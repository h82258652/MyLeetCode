namespace LeetCode258
{
    public class Solution
    {
        public int AddDigits(int num)
        {
            if (num < 10)
            {
                return num;
            }

            var r = 0;
            while (num > 0)
            {
                r += num % 10;
                num /= 10;
            }

            return AddDigits(r);
        }
    }
}
