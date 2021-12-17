using System.Text;

namespace JianZhi05
{
    public class Solution
    {
        /// <summary>
        /// 时间复杂度 O(n)，n 为 s 的长度
        /// 空间复杂度 O(n)，最差的情况 s 全是空格，需要 3n 的空间，忽略常数仍为 O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReplaceSpace(string s)
        {
            var buffer = new StringBuilder();
            foreach (var c in s)
            {
                if (c == ' ')
                {
                    buffer.Append("%20");
                }
                else
                {
                    buffer.Append(c);
                }
            }

            return buffer.ToString();
        }
    }
}
