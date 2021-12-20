using System;

namespace JianZhi58II
{
    public class Solution
    {
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
