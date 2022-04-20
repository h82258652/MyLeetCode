namespace LeetCode2224
{
    public class Solution
    {
        public int ConvertTime(string current, string correct)
        {
            var currentTime = ToMinutes(current);
            var correctTime = ToMinutes(correct);
            var step = 0;
            while (correctTime > currentTime)
            {
                if (correctTime - 60 >= currentTime)
                {
                    correctTime -= 60;
                }
                else if (correctTime - 15 >= currentTime)
                {
                    correctTime -= 15;
                }
                else if (correctTime - 5 >= currentTime)
                {
                    correctTime -= 5;
                }
                else
                {
                    correctTime--;
                }

                step++;
            }
            return step;
        }

        private int ToMinutes(string time)
        {
            var hour = int.Parse(time.Substring(0, 2));
            var minute = int.Parse(time.Substring(3, 2));
            return hour * 60 + minute;
        }
    }
}
