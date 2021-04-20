using Elebris.Rpg.Library.Creation.Units.Modules;
using Elebris.Rpg.Library.Units.Core.Models;
using Elebris.Rpg.Library.Units.Values.Enforcing;
using Elebris.Rpg.Library.Units.Values.Models;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Values.Creation
{
    class CharacterStatFactory : ICharacterStatFactory
    {
        //PlayerDict = PlayerStatModule.RetrieveStats;?
        //EnemyDict = new Dictionary<Stats, StatValue>(); ?
        public Dictionary<string, StatValue> Retrieve()
        {
            Dictionary<string, StatValue> dict = new Dictionary<string, StatValue>();
            //dict = _storedDefaultBaseStats.ToDictionary(entry => entry.Key,
            //    entry => entry.Value);
            return dict;
        }
    }
}
