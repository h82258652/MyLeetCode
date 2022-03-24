namespace LeetCode661
{
    public class Solution
    {
        public int[][] ImageSmoother(int[][] img)
        {
            var m = img.Length;
            var n = img[0].Length;

            var result = new int[m][];
            for (var i = 0; i < m; i++)
            {
                result[i] = new int[n];
            }

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    result[i][j] = Calc(img, i, j, m, n);
                }
            }

            return result;
        }

        private int Calc(int[][] img, int i, int j, int m, int n)
        {
            var sum = img[i][j];
            var count = 1;
            if (i - 1 >= 0 && j - 1 >= 0)
            {
                sum += img[i - 1][j - 1];
                count++;
            }

            if (j - 1 >= 0)
            {
                sum += img[i][j - 1];
                count++;
            }

            if (i + 1 < m && j - 1 >= 0)
            {
                sum += img[i + 1][j - 1];
                count++;
            }

            if (i - 1 >= 0)
            {
                sum += img[i - 1][j];
                count++;
            }

            if (i + 1 < m)
            {
                sum += img[i + 1][j];
                count++;
            }

            if (i - 1 >= 0 && j + 1 < n)
            {
                sum += img[i - 1][j + 1];
                count++;
            }

            if (j + 1 < n)
            {
                sum += img[i][j + 1];
                count++;
            }

            if (i + 1 < m && j + 1 < n)
            {
                sum += img[i + 1][j + 1];
                count++;
            }

            return sum / count;
        }
    }
}
