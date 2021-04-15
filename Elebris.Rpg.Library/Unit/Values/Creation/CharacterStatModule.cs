using Elebris.Rpg.Library.CharacterSystems.MutableValues;
using Elebris.UnitCreation.Library.StatGeneration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Rpg.Library.Creation.Units.Modules
{
    class CharacterStatModule : IStatModule
    {

        public Dictionary<Stats, StatValue> Populate()
        {
            Dictionary<Stats, StatValue> dict = new Dictionary<Stats, StatValue>();
            //handler.StoredStats = _storedDefaultBaseStats.ToDictionary(entry => entry.Key,
            //    entry => entry.Value);
            return dict;
        }
    }
}
