using System;

namespace JianZhi50
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(n)，n为s的长度
        /// 空间复杂度 O(1)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public char FirstUniqChar(string s)
        {
            var length = s.Length;
            if (length <= 0)
            {
                return ' ';
            }

            var firstIndex = new int[26];// 每个字母第一次出现的索引
            Array.Fill(firstIndex, -1);// 负1代表未查找
            for (var i = 0; i < length; i++)
            {
                var c = s[i];
                var delta = c - 'a';
                if (firstIndex[delta] == -1)
                {
                    firstIndex[delta] = i;
                }
                else
                {
                    firstIndex[delta] = -2;// 用负2代表重复
                }
            }

            var result = ' ';
            var minIndex = int.MaxValue;
            for (var i = 0; i < 26; i++)
            {
                var index = firstIndex[i];
                if (index < 0)
                {
                    continue;
                }

                if (index < minIndex)
                {
                    result = (char)('a' + i);
                    minIndex = firstIndex[i];
                }
            }

            return result;
        }
    }
}
