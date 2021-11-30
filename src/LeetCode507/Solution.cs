namespace LeetCode507
{
    public class Solution
    {
        public bool CheckPerfectNumber(int num)
        {
            var total = 0;
            var i = 1;
            var half = num / 2;
            while (i <= half)
            {
                if (num % i == 0)
                {
                    total += i;
                }

                i++;
            }

            return total == num;
        }
    }
}
