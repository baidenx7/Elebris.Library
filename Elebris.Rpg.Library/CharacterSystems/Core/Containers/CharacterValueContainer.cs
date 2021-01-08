using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Core.Library.Enums;
using Elebris.Core.Library.Objects;
using Elebris.Rpg.Library.CharacterSystems.Core;
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
            StoredResourceBars = new Dictionary<ResourceStats, ResourceBarValue>();
            StoredAttributes = new Dictionary<Attributes, StatValue>();
            StoredStats = new Dictionary<string, StatValue>();
            StoredBaseValues = new Dictionary<string, BaseStatValue>();
            StoredProgressionValues = new Dictionary<ProgressionValues, ProgressionValue>();
            StoredWeaknesses = new Dictionary<Elements, WeaknessValue>();
            StoredClasses = new Dictionary<string, CharacterClassHolder>();
            StoredProfessions = new Dictionary<string, CharacterProfessionHolder>();
        }

        public CharacterDataHandler DataHandler { get; set; } 
        internal Dictionary<ResourceStats, ResourceBarValue> StoredResourceBars { get; set; }
        internal Dictionary<Attributes, StatValue> StoredAttributes { get; set; }
        internal Dictionary<string, StatValue> StoredStats { get; set; }
        internal Dictionary<string, BaseStatValue> StoredBaseValues { get; set; }
        internal Dictionary<ProgressionValues, ProgressionValue> StoredProgressionValues { get; set; }
        internal Dictionary<Elements, WeaknessValue> StoredWeaknesses { get; set; }

        internal Dictionary<string, CharacterClassHolder> StoredClasses { get; set; }
        internal Dictionary<string, CharacterProfessionHolder> StoredProfessions { get; set; }



    }
}
