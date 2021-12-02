using System.Linq;

namespace LeetCode506
{
    public class Solution
    {
        public string[] FindRelativeRanks(int[] score)
        {
            return score
                .Select((value, originIndex) => new { value, originIndex })
                .OrderByDescending(temp => temp.value)
                .Select((obj, sortedIndex) =>
                {
                    string rank;
                    switch (sortedIndex)
                    {
                        case 0:
                            rank = "Gold Medal";
                            break;

                        case 1:
                            rank = "Silver Medal";
                            break;

                        case 2:
                            rank = "Bronze Medal";
                            break;

                        default:
                            rank = (sortedIndex + 1).ToString();
                            break;
                    }

                    return new { obj.originIndex, rank };
                })
                .OrderBy(temp => temp.originIndex)
                .Select(temp => temp.rank)
                .ToArray();
        }
    }
}
