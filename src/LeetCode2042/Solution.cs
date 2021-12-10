using System;
using System.Collections.Generic;

namespace LeetCode2042
{
    public class Solution
    {
        public bool AreNumbersAscending(string s)
        {
            var numbers = new List<int>();

            foreach (var word in s.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                if (int.TryParse(word, out var number))
                {
                    numbers.Add(number);
                }
            }

            var count = numbers.Count;
            for (var i = 1; i < count; i++)
            {
                if (numbers[i] <= numbers[i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
