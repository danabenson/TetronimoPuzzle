using TetristPuzzle.Models;

namespace TetristPuzzle.Interfaces
{
    public interface IPlacer
    {
        bool Place(Grid grid, Tetronimo current, Tetronimo next);
    }
}