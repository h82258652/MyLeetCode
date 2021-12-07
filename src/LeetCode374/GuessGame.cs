namespace LeetCode374
{
    public class GuessGame
    {
        private int _pick;

        public static Solution New(int pick)
        {
            var solution = new Solution
            {
                _pick = pick
            };
            return solution;
        }

        protected int guess(int num)
        {
            if (num > _pick)
            {
                return -1;
            }
            else if (num < _pick)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
