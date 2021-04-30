namespace Elebris.Rpg.Library.Units.Actions.Models
{
    public struct AfflictionRetrievableModel : IRetrievableValue
    {
        private readonly Type _type;
        private readonly Category _category;
        private readonly Direction _direction;

        public AfflictionRetrievableModel(Type type, Category category, Direction direction)
        {
            _type = type;
            _category = category;
            _direction = direction;
        }

        public enum Direction
        {
            Self,
            Outgoing
        }

        public enum Type
        {
            Bleed,
            Poison,
            Sleep,
            GravelyWound,

        }

        public enum Category
        {
            Duration,
            AmountMultiplier,
            RecoveryRate,
            ResistanceWindow
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
