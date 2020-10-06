using System;

namespace consoleSweeper
{
    public class Grid
    {
        public Grid(int size1, int size2)
        {
            int[,] grid = new int[size1, size2];
            int mineAmount = size1 * size2 * (2/10);

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = 9;
                }

            }

        }

        public int[,] Generator(int[,] g, int mines)
        {
            Random random = new Random();
            int x;
            int y;
            int xLength = g.GetLength(0);
            int Length = g.GetLength(1);
            int[,] takenPos = new int[2, mines];

            for (int i = 0; i < mines; i++)
            {
                


            }
            return g;
        }

    }
}
