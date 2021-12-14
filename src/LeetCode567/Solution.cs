using System.Linq;

namespace LeetCode567
{
    public class Solution
    {
        public bool CheckInclusion(string s1, string s2)
        {
            var s1Length = s1.Length;
            var s2Length = s2.Length;
            if (s1Length > s2Length)
            {
                return false;
            }

            var s1NumCount = new int[26];
            foreach (var c in s1)
            {
                s1NumCount[c - 'a']++;
            }

            // 初始化和 s1 长度一致的 s2 字符数量数组
            var s2NumCount = new int[26];
            for (var i = 0; i < s1Length; i++)
            {
                var c = s2[i];
                s2NumCount[c - 'a']++;
            }

            // 最左边已经符合了
            if (s1NumCount.SequenceEqual(s2NumCount))
            {
                return true;
            }

            for (var i = s1Length; i < s2Length; i++)
            {
                // 移除区间最左边那个字符
                var previous = s2[i - s1Length];
                s2NumCount[previous - 'a']--;

                // 添加区间最右边那个字符
                var c = s2[i];
                s2NumCount[c - 'a']++;

                if (s1NumCount.SequenceEqual(s2NumCount))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
