namespace LeetCode2011
{
    public class Solution
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            var result = 0;

            foreach (var operation in operations)
            {
                switch (operation[1])
                {
                    case '+':
                        result++;
                        break;

                    case '-':
                        result--;
                        break;
                }
            }

            return result;
        }
    }
}
