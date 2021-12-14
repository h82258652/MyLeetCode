namespace LeetCode1828
{
    public class Solution
    {
        public int[] CountPoints(int[][] points, int[][] queries)
        {
            var pointsLength = points.Length;
            var queriesLength = queries.Length;
            var result = new int[queriesLength];
            for (var queryIndex = 0; queryIndex < queriesLength; queryIndex++)
            {
                var query = queries[queryIndex];
                var x = query[0];
                var y = query[1];
                var r = query[2];
                var rSquare = r * r;

                var count = 0;

                for (var pointIndex = 0; pointIndex < pointsLength; pointIndex++)
                {
                    var point = points[pointIndex];
                    var pointX = point[0];
                    var pointY = point[1];

                    var distanceX = x - pointX;
                    var distanceY = y - pointY;
                    var distanceXSquare = distanceX * distanceX;
                    var distanceYSquare = distanceY * distanceY;

                    if (distanceXSquare + distanceYSquare <= rSquare)
                    {
                        count++;
                    }
                }

                result[queryIndex] = count;
            }

            return result;
        }
    }
}
