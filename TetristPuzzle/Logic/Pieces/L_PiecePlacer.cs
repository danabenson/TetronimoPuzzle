using TetristPuzzle.Interfaces;
using TetristPuzzle.Models;

namespace TetristPuzzle.Logic.Pieces
{
    class L_PiecePlacer : PiecePlacerBase, IPiecePlacer
    {
        public bool CanPlace(Grid g, Tetronimo t, int x, int y)
        {
            var isAvailable = true;
            if (t.Rotation == Rotation.Zero)
            {
                for (int i = 0; i < 3; i++)
                {
                    isAvailable &= g.IsAvailable(x, y + i);
                }
                isAvailable &= g.IsAvailable(x + 1, y + 2);
            }
            else if (t.Rotation == Rotation.Ninety)
            {
                for (int i = 0; i < 3; i++)
                {
                    isAvailable &= g.IsAvailable(x + i, y);
                }
                isAvailable &= g.IsAvailable(x, y + 1);
            }
            else if (t.Rotation == Rotation.OneEighty)
            {
                for (int i = 0; i < 3; i++)
                {
                    isAvailable &= g.IsAvailable(x + 1, y + i);
                }
                isAvailable &= g.IsAvailable(x, y);
            }
            else if (t.Rotation == Rotation.TwoSeventy)
            {
                for (int i = 0; i < 3; i++)
                {
                    isAvailable &= g.IsAvailable(x + i, y);
                }
                isAvailable &= g.IsAvailable(x + 2, y + 1);
            }
            
            return isAvailable;
        }

        public void Place(Grid g, Tetronimo t, int x, int y)
        {
            if (t.Rotation == Rotation.Zero)
            {
                for (int i = 0; i < 3; i++)
                {
                    g.Mark(x, y + i, t.TetronimoType);
                }
                g.Mark(x + 1, y + 2, t.TetronimoType);
            }
            else if (t.Rotation == Rotation.Ninety)
            {
                for (int i = 0; i < 3; i++)
                {
                    g.Mark(x + i, y, t.TetronimoType);
                }
                g.Mark(x, y + 1, t.TetronimoType);
            }
            else if (t.Rotation == Rotation.OneEighty)
            {
                for (int i = 0; i < 3; i++)
                {
                    g.Mark(x + 1, y + i, t.TetronimoType);
                }
                g.Mark(x, y, t.TetronimoType);
            }
            else if (t.Rotation == Rotation.TwoSeventy)
            {
                for (int i = 0; i < 3; i++)
                {
                    g.Mark(x + i, y, t.TetronimoType);
                }
                g.Mark(x + 2, y + 1, t.TetronimoType);
            }
        }
    }
}
