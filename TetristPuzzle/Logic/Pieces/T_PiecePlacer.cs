using TetristPuzzle.Interfaces;
using TetristPuzzle.Models;

namespace TetristPuzzle.Logic.Pieces
{
    class T_PiecePlacer : PiecePlacerBase, IPiecePlacer
    {
        public bool CanPlace(Grid g,Tetronimo t, int x, int y)
        {
            if (t.Rotation == Rotation.Zero)
            {
                var isAvailable = true;
                isAvailable &= g.IsAvailable(x, y);
                isAvailable &= g.IsAvailable(x + 1, y);
                isAvailable &= g.IsAvailable(x + 2, y);
                isAvailable &= g.IsAvailable(x + 1, y + 1);
                return isAvailable;
            }
            if (t.Rotation == Rotation.Ninety)
            {
                var isAvailable = true;
                isAvailable &= g.IsAvailable(x, y);
                isAvailable &= g.IsAvailable(x + 1, y);
                isAvailable &= g.IsAvailable(x + 1, y + 1);
                isAvailable &= g.IsAvailable(x + 1, y - 1);
                return isAvailable;
            }
            if (t.Rotation == Rotation.OneEighty)
            {
                var isAvailable = true;
                isAvailable &= g.IsAvailable(x, y);
                isAvailable &= g.IsAvailable(x + 1, y);
                isAvailable &= g.IsAvailable(x + 2, y);
                isAvailable &= g.IsAvailable(x + 1, y + 1);
                return isAvailable;
            }
            if (t.Rotation == Rotation.TwoSeventy)
            {
                var isAvailable = true;
                isAvailable &= g.IsAvailable(x, y);
                isAvailable &= g.IsAvailable(x, y + 1);
                isAvailable &= g.IsAvailable(x, y + 2);
                isAvailable &= g.IsAvailable(x + 1, y + 1);
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
                g.Mark(x + 2, y, t.TetronimoType);
                g.Mark(x + 1, y + 1, t.TetronimoType);
            }
            if (t.Rotation == Rotation.Ninety)
            {
                g.Mark(x, y, t.TetronimoType);
                g.Mark(x + 1, y, t.TetronimoType);
                g.Mark(x + 1, y + 1, t.TetronimoType);
                g.Mark(x + 1, y - 1, t.TetronimoType);
            }
            if (t.Rotation == Rotation.OneEighty)
            {
                g.Mark(x, y, t.TetronimoType);
                g.Mark(x + 1, y, t.TetronimoType);
                g.Mark(x + 2, y, t.TetronimoType);
                g.Mark(x + 1, y + 1, t.TetronimoType);
            }
            if (t.Rotation == Rotation.TwoSeventy)
            {
                g.Mark(x, y, t.TetronimoType);
                g.Mark(x, y + 1, t.TetronimoType);
                g.Mark(x, y + 2, t.TetronimoType);
                g.Mark(x + 1, y + 1, t.TetronimoType);
            }

          
        }
    }
}
