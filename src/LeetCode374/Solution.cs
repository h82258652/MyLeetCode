namespace LeetCode374
{
    public class Solution : GuessGame
    {
        public int GuessNumber(int n)
        {
            int low = 1;
            int high = n;
            while (low < high)
            {
                var mid = low + (high - low) / 2;// 防止 low + high overflow
                var guessResult = guess(mid);
                if (guessResult == 0)
                {
                    return mid;
                }
                else if (guessResult > 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return low;
        }
    }
}
