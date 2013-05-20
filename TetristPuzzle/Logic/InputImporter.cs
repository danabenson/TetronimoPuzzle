using System;
using System.Collections.Generic;
using System.IO;
using TetristPuzzle.Interfaces;
using TetristPuzzle.Models;

namespace TetristPuzzle.Logic
{
    public class InputImporter : IInputImporter
    {
        public Input Import(string path)
        {
            var input = new Input();
            input.TetronimoSequence = new List<Tetronimo>();
            foreach (string line in File.ReadAllLines(path))
            {
                var t = new Tetronimo();
                t.TetronimoType = (TetronimoType) Enum.Parse(typeof (TetronimoType), line);
                input.TetronimoSequence.Add(t);
            }
            return input;
        }
    }
}