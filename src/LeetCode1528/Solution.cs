namespace LeetCode1528
{
    public class Solution
    {
        public string RestoreString(string s, int[] indices)
        {
            var chars = new char[indices.Length];
            for (var i = 0; i < s.Length; i++)
            {
                chars[indices[i]] = s[i];
            }

            return new string(chars);
        }
    }
}
