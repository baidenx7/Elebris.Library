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
            //Dictionary<Stats, StatValue> dict = new Dictionary<Stats, StatValue>();
            //handler.StoredStats = _storedDefaultBaseStats.ToDictionary(entry => entry.Key,
            //    entry => entry.Value);
            //return dict;
        }
    }



}
