using System;

namespace JianZhi58II
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(s)
        /// 空间复杂度 O(s)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public string ReverseLeftWords(string s, int n)
        {
            var length = s.Length;
            n %= length;
            if (n <= 0)
            {
                return s;
            }

            var chars = s.ToCharArray();
            Array.Reverse(chars);
            Array.Reverse(chars, 0, length - n);
            Array.Reverse(chars, length - n, n);
            return new string(chars);
        }
    }
}
