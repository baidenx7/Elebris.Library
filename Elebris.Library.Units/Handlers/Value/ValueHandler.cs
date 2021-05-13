
using Elebris.Rpg.Library.Units.Actions.Models;
using Elebris.Rpg.Library.Units.Core.Handlers;
using Elebris.Rpg.Library.Units.Core.Models;
using Elebris.Rpg.Library.Units.Values.Enforcing.MutableValues;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Values.Handlers
{

    public class ValueHandler : IValueHandler
    { private Dictionary<string, CharacterStatValue> StoredStats { get; set; }
        private List<IManipulationValue> StoredManipulationValues { get; set; } //values that manupulate val x based on val y
        public ValueHandler(Dictionary<string, CharacterStatValue> statSet)
        {
          
            StoredStats = statSet;
            StoredManipulationValues = new List<IManipulationValue>();
        }


        public StatValue RetrieveValue(string retrievableValue)
        {
          
            return StoredStats[retrievableValue];

        }



    }
}
