using System.Collections.Generic;

namespace LeetCode119
{
    public class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            var result = new List<int>();

            for (var i = 0; i <= rowIndex; i++)
            {
                var tempRow = new List<int>();

                for (var j = 0; j < result.Count; j++)
                {
                    if (j == 0)
                    {
                        tempRow.Add(result[j]);
                    }
                    else
                    {
                        tempRow.Add(result[j] + result[j - 1]);
                    }
                }

                tempRow.Add(1);

                result = tempRow;
            }

            return result;
        }
    }
}
