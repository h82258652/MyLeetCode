using System.Collections.Generic;

namespace LeetCode205
{
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            var length = s.Length;
            var sToTMap = new Dictionary<char, char>();
            var tToSMap = new Dictionary<char, char>();
            for (var i = 0; i < length; i++)
            {
                var sc = s[i];
                var tc = t[i];

                if (sToTMap.TryGetValue(sc, out var exist))
                {
                    if (exist != tc)
                    {
                        return false;
                    }
                }
                else
                {
                    sToTMap[sc] = tc;
                }

                if (tToSMap.TryGetValue(tc, out var exist2))
                {
                    if (exist2 != sc)
                    {
                        return false;
                    }
                }
                else
                {
                    tToSMap[tc] = sc;
                }
            }

            return true;
        }
    }
}
