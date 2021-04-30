using Elebris.Core.Library.Enums;
using Elebris.Library.Units.Containers;
using Elebris.Library.Units.Creation;
using Elebris.Rpg.Library.Units.Actions.Models;
using Elebris.Rpg.Library.Units.Combat.Models;
using Elebris.Rpg.Library.Units.Core.Handlers;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Combat.Handlers
{
    public class CombatHandler : CharacterHandler
    {
        public CombatHandler(Character container, Dictionary<string, WeaknessValue> weaknessSet) : base(container)
        {
            StoredWeaknesses = weaknessSet;
        }
        private Dictionary<string, WeaknessValue> StoredWeaknesses { get; set; }

        public WeaknessValue RetrieveWeaknessValue(Elements element)
        {
            return StoredWeaknesses[element.ToString()];
        }

        public float RetrieveCritChance(CombatRetrievalModel model)
        {
            return 0;
        }
        public float RetrieveCritMultiplier(CombatRetrievalModel model)
        {

           
            return 1;
        }

        public float RetrieveArmorValue(CombatRetrievalModel model)
        {
            return 0;

        }
        public float RetrieveMitigation(CombatRetrievalModel model)
        {
         
            return 0;
        }
        public float RetrieveDamage(CombatRetrievalModel model)
        {
           
            return 0;
        }
    }
}
