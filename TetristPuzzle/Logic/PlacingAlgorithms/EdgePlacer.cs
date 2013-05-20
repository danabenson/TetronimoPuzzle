using TetristPuzzle.Interfaces;
using TetristPuzzle.Models;

namespace TetristPuzzle.Logic.PlacingAlgorithms
{
    public class EdgePlacer : PlacerBase, IPlacer
    {
        private readonly IPlacer _placer;

        public EdgePlacer(IPlacer placer)
        {
            _placer = placer;
        }

        public bool Place(Grid grid, Tetronimo current, Tetronimo next)
        {
            if (current.TetronimoType == TetronimoType.I)
            {
                current.Rotation = Rotation.Ninety;
                for (int i = 0; i < grid.Columns; i++)
                {
                    if (CanPlace(grid, current, i, 0))
                    {
                        CommitPlacement(grid, current, i, 0);
                        return true;
                    }
                    else if (CanPlace(grid, current, i, grid.Rows - 1))
                    {
                        CommitPlacement(grid, current, i, grid.Rows - 1);
                        return true;
                    }
                }
                current.Rotation = Rotation.Zero;
                for (int i = 0; i < grid.Rows; i++)
                {
                    if (CanPlace(grid, current, 0, i))
                    {
                        CommitPlacement(grid, current, i, 0);
                        return true;
                    }
                    else if (CanPlace(grid, current, grid.Columns - 1, i))
                    {
                        CommitPlacement(grid, current, grid.Columns - 1, i);
                        return true;
                    }
                }
            }
            return _placer.Place(grid, current, next);
        }
    }
}