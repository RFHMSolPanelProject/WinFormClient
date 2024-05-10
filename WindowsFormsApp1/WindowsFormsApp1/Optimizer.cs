using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class Optimizer
    {
        public class Cell
        {
            public int Row { get; set; }
            public int Column { get; set; }
            public int Level { get; set; }

            public Cell(int row, int column, int level)
            {
                Row = row;
                Column = column;
                Level = level;
            }
        }

        private const int Rows = 10;
        private const int Columns = 4;
        private const int Levels = 6;

        private int[,,] AdjMat = new int[Rows, Columns, Levels];

        public void InitAdjMat()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    for (int k = 0; k < Levels; k++)
                    {
                        AdjMat[i, j, k] = 1;
                    }
                }
            }
        }

        public List<Cell> FindShortestPath(Cell start, Cell end)
        {
            // Initialize distances
            int[,,] distance = new int[Rows, Columns, Levels];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    for (int k = 0; k < Levels; k++)
                    {
                        distance[i, j, k] = int.MaxValue;
                    }
                }
            }

            distance[start.Row, start.Column, start.Level] = 0;

            // Initialize visited cells
            bool[,,] visited = new bool[Rows, Columns, Levels];

            // Dijkstra algorithm
            bool pathFound = false;
            while (true)
            {
                // Find the closest unvisited cell
                int minDistance = int.MaxValue;
                Cell closestCell = null;
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        for (int k = 0; k < Levels; k++)
                        {
                            if (!visited[i, j, k] && distance[i, j, k] < minDistance)
                            {
                                minDistance = distance[i, j, k];
                                closestCell = new Cell(i, j, k);
                            }
                        }
                    }
                }

                if (closestCell == null || minDistance == int.MaxValue)
                {
                    // No more reachable cells or destination unreachable
                    break;
                }

                visited[closestCell.Row, closestCell.Column, closestCell.Level] = true;

                // Check if we reached the destination
                if (closestCell.Equals(end))
                {
                    pathFound = true;
                    break;
                }

                // Update distances of neighboring cells
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int k = -1; k <= 1; k++)
                        {
                            int newRow = closestCell.Row + i;
                            int newColumn = closestCell.Column + j;
                            int newLevel = closestCell.Level + k;

                            if (newRow >= 0 && newRow < Rows &&
                                newColumn >= 0 && newColumn < Columns &&
                                newLevel >= 0 && newLevel < Levels)
                            {
                                int newDistance = distance[closestCell.Row, closestCell.Column, closestCell.Level] +
                                                  AdjMat[newRow, newColumn, newLevel];
                                if (newDistance < distance[newRow, newColumn, newLevel])
                                {
                                    distance[newRow, newColumn, newLevel] = newDistance;
                                }
                            }
                        }
                    }
                }
            }

            if (!pathFound)
            {
                // No path found, do something (e.g., return an empty list)
                return new List<Cell>();
            }

            // Reconstruct the shortest path
            List<Cell> shortestPath = new List<Cell>();
            if (visited[end.Row, end.Column, end.Level])
            {
                Cell currentCell = end;
                while (!currentCell.Equals(start))
                {
                    shortestPath.Add(currentCell);
                    int minDistance = int.MaxValue;
                    Cell nextCell = null;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            for (int k = -1; k <= 1; k++)
                            {
                                int newRow = currentCell.Row + i;
                                int newColumn = currentCell.Column + j;
                                int newLevel = currentCell.Level + k;

                                if (newRow >= 0 && newRow < Rows &&
                                    newColumn >= 0 && newColumn < Columns &&
                                    newLevel >= 0 && newLevel < Levels &&
                                    distance[newRow, newColumn, newLevel] < minDistance)
                                {
                                    minDistance = distance[newRow, newColumn, newLevel];
                                    nextCell = new Cell(newRow, newColumn, newLevel);
                                }
                            }
                        }
                    }
                    currentCell = nextCell;
                }
                shortestPath.Add(start); // Add the start cell to the path
                shortestPath.Reverse(); // Reverse the path to get the correct order
            }

            return shortestPath;
        }
    }
}

