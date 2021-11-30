using System.Collections.Generic;

namespace LeetCode118
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new IList<int>[numRows];
            for (var i = 0; i < numRows; i++)
            {
                result[i] = new List<int>();
            }
            result[0].Add(1);

            for (var i = 1; i < numRows; i++)
            {
                var previousRow = result[i - 1];
                var row = result[i];
                for (var j = 0; j < previousRow.Count; j++)
                {
                    var temp = previousRow[j];
                    if (j == 0)
                    {
                        row.Add(temp);
                    }
                    else
                    {
                        row.Add(temp + previousRow[j - 1]);
                    }
                }
                row.Add(1);
            }

            return result;
        }
    }
}
