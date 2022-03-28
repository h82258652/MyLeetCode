using System;
using System.Linq;

namespace LeetCode1460
{
    public class Solution
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            Array.Sort(target);
            Array.Sort(arr);
            return target.SequenceEqual(arr);
        }
    }
}
