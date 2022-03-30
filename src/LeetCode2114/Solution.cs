using System.Linq;

namespace LeetCode2114
{
    public class Solution
    {
        public int MostWordsFound(string[] sentences)
        {
            return sentences.Select(temp => temp.Count(c => c == ' ')).Max() + 1;
        }
    }
}
