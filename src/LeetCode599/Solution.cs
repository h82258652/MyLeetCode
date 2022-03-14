using System.Collections.Generic;

namespace LeetCode599
{
    public class Solution
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            var temp = new HashSet<string>();
            var both = new List<string>();
            var index1 = new Dictionary<string, int>();
            var index2 = new Dictionary<string, int>();
            for (var i = 0; i < list1.Length; i++)
            {
                var s = list1[i];
                temp.Add(s);
                index1[s] = i;
            }

            for (var i = 0; i < list2.Length; i++)
            {
                var s = list2[i];
                if (temp.Contains(s))
                {
                    both.Add(s);
                    index2[s] = i;
                }
            }

            var result = new List<string>();
            var minIndex = int.MaxValue;
            foreach (var s in both)
            {
                var i = index1[s] + index2[s];

                if (i == minIndex)
                {
                    result.Add(s);
                }
                else if (i < minIndex)
                {
                    result.Clear();
                    result.Add(s);
                    minIndex = i;
                }
            }

            return result.ToArray();
        }
    }
}
