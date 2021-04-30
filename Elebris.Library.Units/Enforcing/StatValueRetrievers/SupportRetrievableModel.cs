namespace Elebris.Rpg.Library.Units.Actions.Models
{
    public struct SupportRetrievableModel : IRetrievableValue
    {
        //Incoming and outgoing heal, buff, shield, status
        private readonly SupportType _type;
        private readonly SupportCategory _category;
        private readonly Direction _direction
            ;

        public SupportRetrievableModel(SupportType type, SupportCategory category, Direction direction)
        {
            _type = type;
            _category = category;
            _direction = direction;
        }

        public enum Direction
        {
            Incoming,
            Outgoing
        }
        public enum SupportType
        {
            Shield,
            Buff,
            Debuff,
            Heal,

        }

        public enum SupportCategory
        {
            Duration,
            AmountMultiplier,

        }

        public string FormattedString
        {
            get
            {

                string str = $"{_direction}_{_type}_{_category}";
                return str;
            }
        }
    }
}