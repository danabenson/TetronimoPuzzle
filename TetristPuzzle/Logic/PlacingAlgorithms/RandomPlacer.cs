using System;
using TetristPuzzle.Interfaces;
using TetristPuzzle.Models;

namespace TetristPuzzle.Logic.PlacingAlgorithms
{
    public class RandomPlacer : PlacerBase, IPlacer
    {
        private static Random _random;

        public RandomPlacer()
        {
            _random = _random ?? new Random();
        }

        public bool Place(Grid grid, Tetronimo current, Tetronimo next)
        {
            var maxTries = 1000;
            for (int i = 0; i < maxTries; i++)
            {
                var x = _random.Next(grid.Columns);
                var y = _random.Next(grid.Rows);
                current.Rotation = (Rotation) _random.Next(4);
                if (CanPlace(grid, current, x, y))
                {
                    CommitPlacement(grid, current, x, y);
                    return true;
                }
            }
            return false;
        }
    }
}