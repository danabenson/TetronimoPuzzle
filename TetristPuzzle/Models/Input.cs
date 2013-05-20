using System.Collections.Generic;

namespace TetristPuzzle.Models
{
    public class Input
    {
        public List<Tetronimo> TetronimoSequence { get; set; }

        public int StartIndex { get; set; }
    }
}