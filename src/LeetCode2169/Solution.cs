namespace LeetCode2169
{
    public class Solution
    {
        public int CountOperations(int num1, int num2)
        {
            var count = 0;

            while (true)
            {
                if (num1 == 0 || num2 == 0)
                {
                    break;
                }

                if (num1 >= num2)
                {
                    num1 -= num2;
                }
                else
                {
                    num2 -= num1;
                }

                count++;
            }

            return count;
        }
    }
}
