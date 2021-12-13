namespace LeetCode1880
{
    public class Solution
    {
        public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
        {
            var first = 0;
            var firstWordLength = firstWord.Length;
            for (var i = 0; i < firstWordLength; i++)
            {
                first = first * 10 + firstWord[i] - 'a';
            }

            var second = 0;
            var secondWordLength = secondWord.Length;
            for (var i = 0; i < secondWordLength; i++)
            {
                second = second * 10 + secondWord[i] - 'a';
            }

            var target = 0;
            var targetWordLength = targetWord.Length;
            for (var i = 0; i < targetWordLength; i++)
            {
                target = target * 10 + targetWord[i] - 'a';
            }

            return first + second == target;
        }
    }
}
