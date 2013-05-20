using TetristPuzzle.Logic.PlacingAlgorithms;
using TetristPuzzle.Models;

namespace TetristPuzzle.Logic
{
    public class TetrisPuzzle
    {
        public Grid Solve(Input input)
        {
            var grid = new Grid();
            var placer = new EdgePlacer(new RandomPlacer());

            int currentIndex = input.StartIndex;
            bool success = true;
            while (success)
            {
                var currentPiece = input.TetronimoSequence[currentIndex];
                var nextPiece = input.TetronimoSequence[currentIndex + 1];
                success = placer.Place(grid, currentPiece, nextPiece);
                currentIndex++;
            }

            return grid;
        }
    }
}