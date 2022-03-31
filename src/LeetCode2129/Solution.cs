namespace LeetCode2129
{
    public class Solution
    {
        public string CapitalizeTitle(string title)
        {
            var chars = title.ToCharArray();
            var left = 0;
            for (var i = 0; i < chars.Length; i++)
            {
                if (chars[i] != ' ')
                {
                    continue;
                }

                switch (i - left)
                {
                    case 1:
                        chars[left] = char.ToLowerInvariant(chars[left]);
                        break;

                    case 2:
                        chars[left] = char.ToLowerInvariant(chars[left]);
                        chars[left + 1] = char.ToLowerInvariant(chars[left + 1]);
                        break;

                    default:
                        ToTitle(chars, left, i);
                        break;
                }

                left = i + 1;
            }

            switch (chars.Length - left)
            {
                case 1:
                    chars[left] = char.ToLowerInvariant(chars[left]);
                    break;

                case 2:
                    chars[left] = char.ToLowerInvariant(chars[left]);
                    chars[left + 1] = char.ToLowerInvariant(chars[left + 1]);
                    break;

                default:
                    ToTitle(chars, left, chars.Length);
                    break;
            }

            return new string(chars);
        }

        private void ToTitle(char[] chars, int left, int right)
        {
            chars[left] = char.ToUpperInvariant(chars[left]);
            for (var i = left + 1; i < right; i++)
            {
                chars[i] = char.ToLowerInvariant(chars[i]);
            }
        }
    }
}
