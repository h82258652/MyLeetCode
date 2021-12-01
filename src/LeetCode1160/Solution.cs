namespace LeetCode1160
{
    public class Solution
    {
        public int CountCharacters(string[] words, string chars)
        {
            var charsCount = new int[26];
            foreach (var c in chars)
            {
                charsCount[c - 'a']++;
            }

            var result = 0;
            foreach (var word in words)
            {
                var wordCharsCount = new int[26];
                foreach (var c in word)
                {
                    wordCharsCount[c - 'a']++;
                }

                var learn = true;

                for (var i = 0; i < 26; i++)
                {
                    if (charsCount[i] < wordCharsCount[i])
                    {
                        learn = false;
                        break;
                    }
                }

                if (learn)
                {
                    result += word.Length;
                }
            }

            return result;
        }
    }
}
