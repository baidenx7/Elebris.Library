using Elebris.Library.Units.Containers;
using Elebris.Rpg.Library.Units.Actions.Models;
using Elebris.Rpg.Library.Units.Values.Enforcing.MutableValues;
using Elebris.Rpg.Library.Units.Values.Handlers;

namespace Elebris.Rpg.Library.Units.Values.Models
{
    public class LevelScalingStatValue : StatManipulationValues, IManipulationValue
    {
        private readonly IRetrievableValue _affectedValue;

        //private bool roundDown;
        private float genericBase; //regardless of attributes, the value will initialize here
        private float genericScale; //regardless of attributes, the value will scale each level by this much

        private float initialScale; //value at level (0)

        private float attributeScale;

        public IRetrievableValue GoverningValue { get; } //allows Characters to know what attribute(key) to send in (value)


        public LevelScalingStatValue(
              CharacterValueHandler handler
            , IRetrievableValue affectedValue
            , AttributeRetrievableModel GoverningAttribute
            , float genericBase = 0
            , float genericScale = 0
            , float attributeScale = 0
            , float initialScale = 0
            ) : base(handler)
        {

            _affectedValue = affectedValue;
            this.GoverningValue = GoverningAttribute;
            this.genericBase = genericBase;
            this.genericScale = genericScale;
            this.initialScale = initialScale;
            this.attributeScale = attributeScale;

            //link to event at construction
        }

        public void UpdateLinkedValue(float characterlevel)
        {

        }

        private float BonusPerLevel => _handler.RetrieveValue(GoverningValue).TotalValue * attributeScale + genericScale;

        private float BonusFlat => _handler.RetrieveValue(GoverningValue).TotalValue * initialScale + genericBase;

    }
}
