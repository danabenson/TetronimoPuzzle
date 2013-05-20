using TetristPuzzle.Interfaces;
using TetristPuzzle.Models;

namespace TetristPuzzle.Logic.Pieces
{
    public class I_PiecePlacer : PiecePlacerBase, IPiecePlacer
    {
        public bool CanPlace(Grid g, Tetronimo t, int x, int y)
        {
            bool isAvailable = true;
            if (t.Rotation == Rotation.Zero || t.Rotation == Rotation.OneEighty)
            {
                for (int i = 0; i < 4; i++)
                {
                    isAvailable &= g.IsAvailable(x, y + i);
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    isAvailable &= g.IsAvailable(x + i, y);
                }
            }

            return isAvailable;
        }

        public void Place(Grid g, Tetronimo t, int x, int y)
        {
            if (t.Rotation == Rotation.Zero || t.Rotation == Rotation.OneEighty)
            {
                for (int i = 0; i < 4; i++)
                {
                    g.Mark(x, y + i, t.TetronimoType);
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    g.Mark(x + i, y, t.TetronimoType);
                }
            }
        }
    }
}