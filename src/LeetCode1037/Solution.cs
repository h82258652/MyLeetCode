namespace LeetCode1037
{
    public class Solution
    {
        public bool IsBoomerang(int[][] points)
        {
            var p1 = points[0];
            var p2 = points[1];
            var p3 = points[2];

            return ((p3[1] - p2[1]) * (p2[0] - p1[0])) != ((p2[1] - p1[1]) * (p3[0] - p2[0]));
        }
    }
}
