using System;
using System.Text;
using TetristPuzzle.Models;

namespace TetristPuzzle.Logic
{
    public class GridSerializer
    {
        public string Execute(Grid grid)
        {
            var sb = new StringBuilder();
            sb.Append(grid.NumEmpty);
            sb.Append(Environment.NewLine);
            for (int i = 0; i < grid.Rows; i++)
            {
                for (int j = 0; j < grid.Columns; j++)
                {
                    sb.Append(grid.GridSpaces[j, i]);
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}