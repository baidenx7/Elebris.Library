using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Progression;
using Elebris.Rpg.Library.Units.Values.Enforcing;
using Elebris.Rpg.Library.Units.Values.Enforcing.MutableValues;

namespace Elebris.Rpg.Library.Units.Values.Models
{
    public class LevelScalingStatValue : StatManipulationValues, IManipulationValue
    {
        private readonly Stats _affectedValue;

        //private bool roundDown;
        private float genericBase; //regardless of attributes, the value will initialize here
        private float genericScale; //regardless of attributes, the value will scale each level by this much

        private float initialScale; //value at level (0)

        private float attributeScale;

        public Attributes GoverningAttribute { get; } //allows Characters to know what attribute(key) to send in (value)


        public LevelScalingStatValue(
              Character character
            , Stats affectedValue
            , Attributes GoverningAttribute = Attributes.None
            , float genericBase = 0
            , float genericScale = 0
            , float attributeScale = 0
            , float initialScale = 0
            ) : base(character)
        {

            _affectedValue = affectedValue;
            this.GoverningAttribute = GoverningAttribute;
            this.genericBase = genericBase;
            this.genericScale = genericScale;
            this.initialScale = initialScale;
            this.attributeScale = attributeScale;

            //link to event at construction
        }

        public void UpdateLinkedValue()
        {
            //if (!_character.ValueHandler.StoredStats.ContainsKey(_affectedValue)) return;

            //_character.ValueHandler.StoredStats[_affectedValue].RemoveAllModifiersFromSource(this);

            //float level = _character.ProgressionHandler.StoredProgressionValues[ProgressionValues.CharacterExperience].Level;
            //float val = BonusPerLevel * level + BonusFlat;
            //ValueModifier mod = new ValueModifier(val, ValueModEnum.Flat);
            //_character.ValueHandler.StoredStats[_affectedValue].AddModifier(mod);
        }

        private float BonusPerLevel => _character.ValueHandler.RetrieveValue(GoverningAttribute) * attributeScale + genericScale;

        private float BonusFlat => _character.ValueHandler.RetrieveValue(GoverningAttribute) * initialScale + genericBase;

    }
}
