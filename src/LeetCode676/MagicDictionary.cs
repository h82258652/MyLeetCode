namespace LeetCode676
{
    public class MagicDictionary
    {
        private string[] _dictionary;

        public MagicDictionary()
        {
        }

        public void BuildDict(string[] dictionary)
        {
            _dictionary = dictionary;
        }

        public bool Search(string searchWord)
        {
            foreach (var word in _dictionary)
            {
                if (IsMatch(word, searchWord))
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsMatch(string word, string searchWord)
        {
            if (word == searchWord)
            {
                return false;
            }

            if (word.Length != searchWord.Length)
            {
                return false;
            }

            var missMatch = false;
            for (var i = 0; i < word.Length; i++)
            {
                if (word[i] == searchWord[i])
                {
                    continue;
                }

                if (missMatch)
                {
                    return false;
                }

                missMatch = true;
            }

            return true;
        }
    }
}
