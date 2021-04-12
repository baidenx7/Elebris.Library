using Elebris.Rpg.Library.CharacterSystems.Core;
using Elebris.Rpg.Library.CharacterValues;

namespace Elebris.Rpg.Library.CharacterSystems.UnitGeneration
{
    public class DataBuilder : IDataBuilder
    {
        public UnitDataHandler ReturnHandler(Unit unit)
        {
            UnitDataHandler handler = new UnitDataHandler(unit);
            Populate(handler);
            return handler;
        }
        private void Populate(UnitDataHandler handler)
        {

        }
    }
}
