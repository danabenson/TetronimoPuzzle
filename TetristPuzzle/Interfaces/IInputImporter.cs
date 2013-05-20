using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetristPuzzle.Models;

namespace TetristPuzzle.Interfaces
{
    public interface IInputImporter
    {
        Input Import(string path);
    }
}
