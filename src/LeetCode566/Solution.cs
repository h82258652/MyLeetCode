namespace LeetCode566
{
    public class Solution
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            var m = mat.Length;
            var n = mat[0].Length;

            if (m * n != r * c)
            {
                return mat;
            }

            var result = new int[r][];
            for (var i = 0; i < r; i++)
            {
                result[i] = new int[c];
            }

            var resultI = 0;
            var resultJ = 0;
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    result[resultI][resultJ] = mat[i][j];
                    resultJ++;
                    if (resultJ == c)
                    {
                        resultJ = 0;
                        resultI++;
                    }
                }
            }

            return result;
        }
    }
}
