namespace LeetCode1252
{
    public class Solution
    {
        public int OddCells(int m, int n, int[][] indices)
        {
            var rowCount = new int[m];
            var columnCount = new int[n];
            foreach (var indice in indices)
            {
                var ri = indice[0];
                var ci = indice[1];

                rowCount[ri]++;
                columnCount[ci]++;
            }

            var result = 0;
            for (var r = 0; r < m; r++)
            {
                for (var c = 0; c < n; c++)
                {
                    var sum = rowCount[r] + columnCount[c];
                    if (sum % 2 == 1)
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
