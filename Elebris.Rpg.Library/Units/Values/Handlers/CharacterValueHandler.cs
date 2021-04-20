using Elebris.Rpg.Library.Creation.Units.Modules;
using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Actions.Models;
using Elebris.Rpg.Library.Units.Core.Handlers;
using Elebris.Rpg.Library.Units.Core.Models;
using Elebris.Rpg.Library.Units.Values.Creation;
using Elebris.Rpg.Library.Units.Values.Enforcing;
using Elebris.Rpg.Library.Units.Values.Enforcing.MutableValues;
using Elebris.Rpg.Library.Units.Values.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Elebris.Rpg.Library.Units.Values.Handlers
{

    public class CharacterValueHandler : CharacterHandler, ICharacterValueHandler
    {
        private Dictionary<Attributes, StatValue> StoredAttributes { get; set; }
        private Dictionary<string, StatValue> StoredStats { get; set; }
        private List<IManipulationValue> StoredManipulationValues { get; set; } //values that manupulate val x based on val y
        public CharacterValueHandler(Character character, IAttributeFactory attributefactory, ICharacterStatFactory statfactory) : base(character)
        {
            StoredAttributes = attributefactory.Retrieve();
            StoredStats = statfactory.Retrieve();
            StoredManipulationValues = new List<IManipulationValue>();

        }


        public StatValue RetrieveValue(IRetrievableValue storable)
        {
            if(!StoredStats.ContainsKey(storable.FormattedString))
            {
               StoredStats[storable.FormattedString] = new StatValue(SetDefaultValue(storable.FormattedString));
            }

            return StoredStats[storable.FormattedString];

        }

        private float SetDefaultValue(string str)
        {
            
            if (str.Contains("Multiplier"))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


    }
}
