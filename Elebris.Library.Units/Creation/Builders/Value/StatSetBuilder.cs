
using Elebris.Database;
using Elebris.Database.Manager;
using Elebris.Rpg.Library.Units.Core.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Library.Units.Creation
{
    public class StatSetBuilder : IStatSetBuilder
    {
        readonly Dictionary<string, CharacterStatValue> _defaultCharacterStats;
        private readonly IStatData _statData;

        public StatSetBuilder(IStatData data)
        {

            _statData = data;
            _defaultCharacterStats = Populate();
        }
        private Dictionary<string, CharacterStatValue> Populate()
        {
            List<DBStatModel> list = _statData.GetAllStatModels();
             return list.ToDictionary(entry => entry.Name,
                entry => new CharacterStatValue(entry.Value));
        }
        public Dictionary<string, CharacterStatValue> GenerateStatSet()
        {

            Dictionary<string, CharacterStatValue> dict = new();
            dict = _defaultCharacterStats.ToDictionary(entry => entry.Key,
               entry => entry.Value);
            return dict;
        }


    }
}
