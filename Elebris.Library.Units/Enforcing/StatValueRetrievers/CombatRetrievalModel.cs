using Elebris.Library.Units.Enforcing.Combat;

namespace Elebris.Rpg.Library.Units.Actions.Models
{
    public struct CombatRetrievalModel : IRetrievableValue
    {
        private readonly Category _interactionType;
        private readonly DamageType _damageType;
        public enum Category
        {
            Damage,
            Penetration, //Flat damage increase at the end
            CriticalMultiplier,
            CriticalChance,



            Armor, //
            PercentMitigation, // % damage reduction added to reduc from armor
            FlatMitigation, // Flat Damage Reduction at the end
        }

        public CombatRetrievalModel(Category statType, DamageType damageType)
        {
            _interactionType = statType;
            _damageType = damageType;
        }

        public string FormattedString
        {
            get
            {
                string str = $"{_damageType}_{_interactionType}";
                return str;
            }
        }
    }


}
