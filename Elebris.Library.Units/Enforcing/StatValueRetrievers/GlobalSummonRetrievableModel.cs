namespace Elebris.Rpg.Library.Units.Actions.Models
{
    public struct GlobalSummonRetrievableModel : IRetrievableValue
    {
        private readonly SummonType _type;
        public enum SummonType
        {
            Capacity,
            Damage,
            MoveSpeed,
            AttackSpeed,
            AttackRange,
            TetherRange,
            Duration,
            Health
        }

        public string FormattedString
        {
            get
            {

                string str = $"Summon_{_type}";
                return str;
            }
        }
    }
}

