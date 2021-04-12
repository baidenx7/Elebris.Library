
using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Core.Library.Enums;
using Elebris.Rpg.Library.CharacterValues;
using Elebris.Rpg.Library.Enums;
using Elebris.UnitCreation.Library.StatGeneration;
using System;

namespace Elebris.Rpg.Library.CharacterSystems.MutableValues
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
              Unit container
            , Stats affectedValue
            , Attributes GoverningAttribute = Attributes.None
            , float genericBase = 0
            , float genericScale = 0
            , float attributeScale = 0
            , float initialScale = 0
            ) : base(container)
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
            if (!_container.ValueHandler.StoredStats.ContainsKey(_affectedValue)) return;
            
            _container.ValueHandler.StoredStats[_affectedValue].RemoveAllModifiersFromSource(this);
            
            float level = _container.ProgressionHandler.StoredProgressionValues[ProgressionValues.CharacterExperience].Level;
            float val = BonusPerLevel * level + BonusFlat;
            ValueModifier mod = new ValueModifier(val, ValueModEnum.Flat);
            _container.ValueHandler.StoredStats[_affectedValue].AddModifier(mod);
        }

        private float BonusPerLevel => _container.ValueHandler.RetrieveValue(GoverningAttribute) * attributeScale + genericScale;

        private float BonusFlat => _container.ValueHandler.RetrieveValue(GoverningAttribute) * initialScale + genericBase;

    }
}
