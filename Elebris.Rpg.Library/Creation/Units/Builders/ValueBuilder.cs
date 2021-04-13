using Elebris.Rpg.Library.CharacterSystems.Core;
using Elebris.Rpg.Library.CharacterValues;

namespace Elebris.Rpg.Library.CharacterSystems.UnitGeneration
{
    public class ValueBuilder : IValueBuilder
    {
        public UnitValueHandler ReturnHandler(Unit unit)
        {
            UnitValueHandler handler = new UnitValueHandler(unit);
            Populate(handler);
            return handler;
        }

        private void Populate(UnitValueHandler handler)
        {
            
        }
    }



}
