namespace LeetCode733
{
    public class Solution
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            var height = image.Length;
            var width = image[0].Length;

            var oldColor = image[sr][sc];
            var visited = new bool[height][];
            for (var i = 0; i < height; i++)
            {
                visited[i] = new bool[width];
            }

            InternalFloodFill(image, sr, sc, height, width, oldColor, newColor, visited);

            return image;
        }

        private void InternalFloodFill(int[][] image, int i, int j, int height, int width, int oldColor, int newColor, bool[][] visited)
        {
            if (i < 0 || j < 0 || i >= height || j >= width)
            {
                return;
            }

            if (visited[i][j])
            {
                return;
            }

            visited[i][j] = true;
            if (image[i][j] != oldColor)
            {
                return;
            }

            image[i][j] = newColor;
            InternalFloodFill(image, i - 1, j, height, width, oldColor, newColor, visited);
            InternalFloodFill(image, i + 1, j, height, width, oldColor, newColor, visited);
            InternalFloodFill(image, i, j - 1, height, width, oldColor, newColor, visited);
            InternalFloodFill(image, i, j + 1, height, width, oldColor, newColor, visited);
        }
    }
}
