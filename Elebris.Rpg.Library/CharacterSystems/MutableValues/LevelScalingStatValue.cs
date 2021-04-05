using Elebris.Core.Library.Enums;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using System;

namespace Elebris.Core.Library.CharacterValues.Mutable
{
    public class LevelScalingStatValue : StatManipulationValues
    {
        private readonly StatValue _affectedValue;

        //private bool roundDown;
        private float genericBase; //regardless of attributes, the value will initialize here
        private float genericScale; //regardless of attributes, the value will scale each level by this much

        private float initialScale; //value at level (0)

        private float attributeScale;

        public Attributes GoverningAttribute { get; } //allows Characters to know what attribute(key) to send in (value)


        LevelScalingStatValue(CharacterValueContainer container, StatValue affectedValue,
            Attributes GoverningAttribute = Attributes.None, float genericBase = 0, float genericScale = 0,
            float attributeScale = 0, float initialScale = 0) :base(container)
        {
            
            _affectedValue = affectedValue;
            this.GoverningAttribute = GoverningAttribute;
            this.genericBase = genericBase;
            this.genericScale = genericScale;
            this.initialScale = initialScale;
            this.attributeScale = attributeScale;
        }

        public override void UpdateValues()
        {
            if(_affectedValue != null) _affectedValue.RemoveAllModifiersFromSource(this);
            float level = _container.StoredProgressionValues[ProgressionValues.CharacterExperience].Level;
            float val = (BonusPerLevel * level) + BonusFlat;
            ValueModifier mod = new ValueModifier(val, ValueModEnum.Flat);
            _affectedValue.AddModifier(mod);
        }

        private float BonusPerLevel => (_container.StoredAttributes[GoverningAttribute].TotalValue * attributeScale) + genericScale;

        private float BonusFlat => (_container.StoredAttributes[GoverningAttribute].TotalValue * initialScale) + genericBase;
      
    }
}
