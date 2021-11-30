namespace LeetCode434
{
    public class Solution
    {
        public int CountSegments(string s)
        {
            char preChar = ' ';
            int result = 0;
            foreach (var c in s)
            {
                if (c == ' ' && preChar != ' ')
                {
                    result++;
                }

                preChar = c;
            }

            if (preChar != ' ')
            {
                result++;
            }

            return result;
        }
    }
}
