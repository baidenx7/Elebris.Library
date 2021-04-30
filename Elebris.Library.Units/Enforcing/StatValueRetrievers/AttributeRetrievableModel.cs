using Elebris.Rpg.Library.Units.Values.Enforcing;

namespace Elebris.Rpg.Library.Units.Actions.Models
{
    public struct AttributeRetrievableModel : IRetrievableValue
    {
        private readonly CharacterAttributes _attribute;
        public AttributeRetrievableModel(CharacterAttributes attribute)
        {
            _attribute = attribute;
        }

        public string FormattedString
        {
            get
            {
                return $"{_attribute}";
            }
        }
    }
}
