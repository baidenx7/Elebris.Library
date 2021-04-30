using Elebris.Database.Manager.DataAccess;
using Elebris.Database.Manager.Models;
using Elebris.Rpg.Library.Units.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Library.Units.Creation
{
    public class StatSetBuilder : IStatSetBuilder
    {
        readonly Dictionary<string, StatValue> _defaultStats;

        public StatSetBuilder()
        {
            DefaultCharacterStatData statData = new();
            List<DefaultStatModel> list = statData.GetAllStatModels();
            _defaultStats = list.ToDictionary(entry => entry.Name,
                entry => new StatValue(entry.Value));

        }
        //EnemyDict = new Dictionary<Stats, StatValue>(); ?
        public Dictionary<string, StatValue> GenerateStatSet()
        {

            Dictionary<string, StatValue> dict = new();
            dict = _defaultStats.ToDictionary(entry => entry.Key,
               entry => entry.Value);
            return dict;
        }
    }
}
