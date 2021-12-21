namespace LeetCode2000
{
    public class Solution
    {
        public string ReversePrefix(string word, char ch)
        {
            var chIndex = 0;
            while (chIndex < word.Length)
            {
                if (word[chIndex] == ch)
                {
                    break;
                }

                chIndex++;
            }

            if (chIndex >= word.Length)
            {
                return word;
            }

            var wordArray = word.ToCharArray();

            var left = 0;
            while (left < chIndex)
            {
                (wordArray[left], wordArray[chIndex]) = (wordArray[chIndex], wordArray[left]);

                left++;
                chIndex--;
            }

            return new string(wordArray);
        }
    }
}
