using TetristPuzzle.Interfaces;
using TetristPuzzle.Models;

namespace TetristPuzzle.Logic.Pieces
{
    public class S_PiecePlacer : PiecePlacerBase, IPiecePlacer
    {
        public bool CanPlace(Grid g, Tetronimo t, int x, int y)
        {
            if (t.Rotation == Rotation.Zero)
            {
                bool isAvailable = true;
                isAvailable &= g.IsAvailable(x, y);
                isAvailable &= g.IsAvailable(x + 1, y);
                isAvailable &= g.IsAvailable(x + 1, y + 1);
                isAvailable &= g.IsAvailable(x + 2, y + 1);
                return isAvailable;
            }

            if (t.Rotation == Rotation.Ninety)
            {
                bool isAvailable = true;
                isAvailable &= g.IsAvailable(x, y);
                isAvailable &= g.IsAvailable(x, y + 1);
                isAvailable &= g.IsAvailable(x + 1, y + 1);
                isAvailable &= g.IsAvailable(x + 1, y + 2);
                return isAvailable;
            }
            if (t.Rotation == Rotation.OneEighty)
            {
                bool isAvailable = true;
                isAvailable &= g.IsAvailable(x, y);
                isAvailable &= g.IsAvailable(x + 1, y);
                isAvailable &= g.IsAvailable(x + 1, y + 1);
                isAvailable &= g.IsAvailable(x + 2, y + 1);
                return isAvailable;
            }
            if (t.Rotation == Rotation.TwoSeventy)
            {
                bool isAvailable = true;
                isAvailable &= g.IsAvailable(x, y);
                isAvailable &= g.IsAvailable(x, y + 1);
                isAvailable &= g.IsAvailable(x + 1, y + 1);
                isAvailable &= g.IsAvailable(x + 1, y + 2);
                return isAvailable;
            }

            return false;
        }

        public void Place(Grid g, Tetronimo t, int x, int y)
        {
            if (t.Rotation == Rotation.Zero)
            {
                g.Mark(x, y, t.TetronimoType);
                g.Mark(x + 1, y, t.TetronimoType);
                g.Mark(x + 1, y + 1, t.TetronimoType);
                g.Mark(x + 2, y + 1, t.TetronimoType);
            }

            if (t.Rotation == Rotation.Ninety)
            {
                g.Mark(x, y, t.TetronimoType);
                g.Mark(x, y + 1, t.TetronimoType);
                g.Mark(x + 1, y + 1, t.TetronimoType);
                g.Mark(x + 1, y + 2, t.TetronimoType);
            }
            if (t.Rotation == Rotation.OneEighty)
            {
                g.Mark(x, y, t.TetronimoType);
                g.Mark(x + 1, y, t.TetronimoType);
                g.Mark(x + 1, y + 1, t.TetronimoType);
                g.Mark(x + 2, y + 1, t.TetronimoType);
            }
            if (t.Rotation == Rotation.TwoSeventy)
            {
                g.Mark(x, y, t.TetronimoType);
                g.Mark(x, y + 1, t.TetronimoType);
                g.Mark(x + 1, y + 1, t.TetronimoType);
                g.Mark(x + 1, y + 2, t.TetronimoType);
            }
        }
    }
}