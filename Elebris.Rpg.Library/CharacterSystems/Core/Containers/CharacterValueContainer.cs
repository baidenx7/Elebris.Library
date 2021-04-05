using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Core.Library.Enums;
using Elebris.Core.Library.Objects;
using Elebris.Rpg.Library.CharacterSystems.Core;
using Elebris.Rpg.Library.CharacterSystems.Core.UnitEvents;
using Elebris.Rpg.Library.StatGeneration;
using Elebris.UnitCreation.Library.StatGeneration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Rpg.Library.CharacterValues
{
    public class CharacterValueContainer
    {
        public CharacterValueContainer()
        {
            DataHandler = new CharacterDataHandler(this);
            TriggerHandler = new UnitTriggerHandler();
            
            StoredResourceBars = new Dictionary<ResourceStats, ResourceBarValue>();
            StoredAttributes = new Dictionary<Attributes, StatValue>();
            StoredStats = new Dictionary<Stats, StatValue>();
            StoredProgressionValues = new Dictionary<ProgressionValues, ProgressionValue>();

            StoredWeaknesses = new Dictionary<Elements, WeaknessValue>();
            StoredClasses = new Dictionary<string, CharacterClassHolder>();
            StoredProfessions = new Dictionary<string, CharacterProfessionHolder>();
            StoredManipulationValues = new List<ITriggerableValue>();
        }

        public CharacterDataHandler DataHandler { get; set; } 
        public UnitTriggerHandler TriggerHandler { get; set; }
        internal Dictionary<ResourceStats, ResourceBarValue> StoredResourceBars { get; set; }
        internal Dictionary<Attributes, StatValue> StoredAttributes { get; set; }
        internal Dictionary<Stats, StatValue> StoredStats { get; set; }
        internal List<ITriggerableValue> StoredManipulationValues { get; set; }
        internal Dictionary<ProgressionValues, ProgressionValue> StoredProgressionValues { get; set; }
        internal Dictionary<Elements, WeaknessValue> StoredWeaknesses { get; set; }
        internal Dictionary<string, CharacterClassHolder> StoredClasses { get; set; }
        internal Dictionary<string, CharacterProfessionHolder> StoredProfessions { get; set; }



    }
}
