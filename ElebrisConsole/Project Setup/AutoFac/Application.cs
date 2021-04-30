

namespace Elebris
{
    public class Application : IApplication
    {
        public Application(IUnitLogic unitLogic)
        {
            _unitLogic = unitLogic;
        }


        private readonly IUnitLogic _unitLogic;
        public void Run()
        {
            _unitLogic.Process();
        }
    }
}
