using System.Collections.Generic;

namespace LeetCode1034
{
    public class Solution
    {
        public struct Point
        {
            public Point(int row, int column)
            {
                this.row = row;
                this.column = column;
            }

            public int row;
            public int column;
        }

        public int[][] ColorBorder(int[][] grid, int row, int col, int color)
        {
            var totalRow = grid.Length;
            var totalColumn = grid[0].Length;

            var copy = new int[totalRow][];
            for (var i = 0; i < totalRow; i++)
            {
                copy[i] = new int[totalColumn];
                for (var j = 0; j < totalColumn; j++)
                {
                    copy[i][j] = grid[i][j];
                }
            }

            var target = grid[row][col];
            var edgePoints = new HashSet<Point>();
            var visitedPoints = new HashSet<Point>();
            LoopEdge(grid, row, col, target, totalRow, totalColumn, edgePoints, visitedPoints);

            foreach (var point in edgePoints)
            {
                copy[point.row][point.column] = color;
            }

            return copy;
        }

        private void LoopEdge(
            int[][] grid,
            int row,
            int col,
            int target,
            int totalRow,
            int totalColumn,
            HashSet<Point> edgePoints,
            HashSet<Point> visitedPoints)
        {
            if (row < 0 || col < 0 ||
                row >= totalRow || col >= totalColumn)
            {
                return;
            }

            var point = new Point(row, col);
            if (visitedPoints.Contains(point))
            {
                return;
            }

            var val = grid[row][col];
            if (val != target)
            {
                visitedPoints.Add(point);
                return;
            }

            var isEdge = false;
            if (row <= 0 || grid[row - 1][col] != target)// Top
            {
                isEdge = true;
            }
            else if (row >= totalRow - 1 || grid[row + 1][col] != target)// Bottom
            {
                isEdge = true;
            }
            else if (col <= 0 || grid[row][col - 1] != target)// Left
            {
                isEdge = true;
            }
            else if (col >= totalColumn - 1 || grid[row][col + 1] != target) // Right
            {
                isEdge = true;
            }

            if (isEdge)
            {
                edgePoints.Add(new Point(row, col));
            }

            visitedPoints.Add(point);

            // Top
            LoopEdge(grid, row - 1, col, target, totalRow, totalColumn, edgePoints, visitedPoints);
            // Bottom
            LoopEdge(grid, row + 1, col, target, totalRow, totalColumn, edgePoints, visitedPoints);
            // Left
            LoopEdge(grid, row, col - 1, target, totalRow, totalColumn, edgePoints, visitedPoints);
            // Right
            LoopEdge(grid, row, col + 1, target, totalRow, totalColumn, edgePoints, visitedPoints);
        }
    }
}
