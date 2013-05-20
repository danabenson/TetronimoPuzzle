using System;
using TetristPuzzle.Logic.Pieces;
using TetristPuzzle.Models;

namespace TetristPuzzle.Logic
{
    public class PlacerBase
    {
        protected bool CanPlace(Grid grid, Tetronimo t, int x, int y)
        {
            switch (t.TetronimoType)
            {
                case TetronimoType.L:
                    return new L_PiecePlacer().CanPlace(grid, t, x, y);
                    break;
                case TetronimoType.S:
                    return new S_PiecePlacer().CanPlace(grid, t, x, y);
                    break;
                case TetronimoType.T:
                    return new T_PiecePlacer().CanPlace(grid, t, x, y);
                    break;
                case TetronimoType.I:
                    return new I_PiecePlacer().CanPlace(grid, t, x, y);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected void CommitPlacement(Grid grid, Tetronimo t, int x, int y)
        {
            switch (t.TetronimoType)
            {
                case TetronimoType.L:
                    new L_PiecePlacer().Place(grid, t, x, y);
                    break;
                case TetronimoType.S:
                    new S_PiecePlacer().Place(grid, t, x, y);
                    break;
                case TetronimoType.T:
                    new T_PiecePlacer().Place(grid, t, x, y);
                    break;
                case TetronimoType.I:
                    new I_PiecePlacer().Place(grid, t, x, y);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}