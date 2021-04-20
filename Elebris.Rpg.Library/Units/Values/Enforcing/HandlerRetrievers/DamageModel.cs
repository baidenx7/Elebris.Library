using Elebris.Core.Library.Enums.Tags;
using Elebris.Rpg.Library.Units.Combat;
using Elebris.Rpg.Library.Units.Core.Models;
using Elebris.Rpg.Library.Units.Values.Models;

namespace Elebris.Rpg.Library.Units.Actions.Models
{
    public struct DamageModel : IRetrievableValue
    {
        private readonly CombatInteractionType _interactionType;
        private readonly DamageType _damageType;

        public enum DamageType
        {
            Global,
            Physical,
            Ranged,
            Spell,
        }
        public enum CombatInteractionType
        {
            Damage,
            Penetration, //Flat damage increase at the end
            CriticalDamage,
            CriticalChance,
            //Leech



            Armor, //
            CriticalArmor,
            PercentMitigation, // % damage reduction added to reduc from armor
            FlatMitigation, // Flat Damage Reduction at the end
        }

        public DamageModel(CombatInteractionType statType, DamageType damageType)
        {
            _interactionType = statType;
            _damageType = damageType;
        }

        public string FormattedString
        {
            get
            {
                string str = $"Combat_{_damageType}_{_interactionType}";
                return str;
            }
        }
    }


}
