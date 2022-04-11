namespace LeetCode1455
{
    public class Solution
    {
        public int IsPrefixOfWord(string sentence, string searchWord)
        {
            var words = sentence.Split(' ');
            for (var i = 0; i < words.Length; i++)
            {
                var word = words[i];
                if (word.StartsWith(searchWord))
                {
                    return i + 1;
                }
            }

            return -1;
        }
    }
}
