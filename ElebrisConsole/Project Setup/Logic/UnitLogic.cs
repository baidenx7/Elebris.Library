using Elebris.Library.Units.Creation;

namespace Elebris
{
    public class UnitLogic : IUnitLogic
    {
        private readonly ICharacterFactory _characterFactory;

        public UnitLogic(ICharacterFactory characterFactory)
        {
            _characterFactory = characterFactory;
        }
        public void Process()
        {

        }
    }
}
