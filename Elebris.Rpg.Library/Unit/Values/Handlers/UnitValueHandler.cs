using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using Elebris.Core.Library.CharacterValues.Mutable;
using System.Collections.Generic;
using Elebris.Rpg.Library.Enums;
using Elebris.Rpg.Library.CharacterSystems.MutableValues;

namespace Elebris.Rpg.Library.CharacterSystems.Core
{

    public class UnitValueHandler : CharacterHandler
    {
        private Dictionary<Attributes, StatValue> StoredAttributes { get; set; }
        private Dictionary<Stats, StatValue> StoredStats { get; set; }
        private List<IManipulationValue> StoredManipulationValues { get; set; } //values that manupulate val x based on val y
        public UnitValueHandler(Unit container) : base(container)
        {
            StoredAttributes = new Dictionary<Attributes, StatValue>();
            StoredStats = new Dictionary<Stats, StatValue>();
            StoredManipulationValues = new List<IManipulationValue>();

        }

        public float RetrieveValue(Stats stat)
        {
            StatValue cur = StoredStats[stat];

            return cur.TotalValue;
        }
        public float RetrieveValue(Attributes attribute)
        {
            if (attribute == Attributes.None) return 0;
            StatValue cur = StoredAttributes[attribute];

            return cur.TotalValue;
        }

       
        public StatValue CopyStat(Stats stat)
        {
            StatValue cur = StoredStats[stat];
            StatValue val = new StatValue(cur.BaseValue);
            foreach (var modifier in cur.ValueModifiers)
            {
                val.AddModifier(modifier);
            }
            return val;
        }




    }
}
