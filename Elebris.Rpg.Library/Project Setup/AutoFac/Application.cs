using Elebris.Rpg.Library.Project_Setup.Logic;
using Elebris.Rpg.Library.Units.Core.Creation;

namespace Elebris.Rpg.Library.AutoFac
{
    public class Application : IApplication
    {


        public Application(IUnitLogic unitLogic)
        {
            UnitLogic = unitLogic;
        }

        public IUnitLogic UnitLogic { get; }

        public void Run()
        {
            UnitLogic.Process();
        }
    }
}
