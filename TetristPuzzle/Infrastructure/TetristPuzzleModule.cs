using Ninject.Modules;
using TetristPuzzle.Interfaces;
using TetristPuzzle.Logic;

namespace TetristPuzzle.Infrastructure
{
    public class TetristPuzzleModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IInputImporter>().To<InputImporter>();
        }
    }
}
