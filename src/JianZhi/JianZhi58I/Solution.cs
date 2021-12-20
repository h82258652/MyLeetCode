using System;

namespace JianZhi58I
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(n)，
        /// 空间复杂度 O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReverseWords(string s)
        {
            var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            return string.Join(' ', words);
        }
    }
}
