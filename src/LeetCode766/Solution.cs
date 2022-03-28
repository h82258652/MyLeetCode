namespace LeetCode766
{
    public class Solution
    {
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;

            for (var i = 0; i < m; i++)
            {
                if (!IsMatch(matrix, i, 0, m, n))
                {
                    return false;
                }
            }

            for (var j = 1; j < n; j++)
            {
                if (!IsMatch(matrix, 0, j, m, n))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsMatch(int[][] matrix, int i, int j, int m, int n)
        {
            var element = matrix[i][j];
            while (true)
            {
                i++;
                j++;
                if (i >= m || j >= n)
                {
                    break;
                }

                if (matrix[i][j] == element)
                {
                    continue;
                }

                return false;
            }

            return true;
        }
    }
}
