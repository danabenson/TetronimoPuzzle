using TetristPuzzle.Models;

namespace TetristPuzzle.Interfaces
{
    public interface IPiecePlacer
    {
        bool CanPlace(Grid g, Tetronimo t, int x, int y);

        void Place(Grid g, Tetronimo t, int x, int y);
    }
}