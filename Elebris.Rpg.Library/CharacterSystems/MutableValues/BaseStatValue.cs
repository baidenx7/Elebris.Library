using Elebris.Rpg.Library.CharacterValues;
using Elebris.UnitCreation.Library.StatGeneration;
using System;

namespace Elebris.Core.Library.CharacterValues.Mutable
{
    //the model by which a value-per-level is calculated
    public class BaseStatValue
    {
        //private bool roundDown;
        private float genericBase; //regardless of attributes, the value will initialize here
        private float genericScale; //regardless of attributes, the value will scale each level by this much

        private float initialScale; //value at level (0)

        private float attributeScale;

        internal CharacterValueContainer _container;

        internal event Action<float> OnBaseUpdated;

        internal void SubjectUpdated(float value)
        {
            float val = value * initialScale + genericBase;
            if (OnBaseUpdated != null) OnBaseUpdated(val);
        }
        
        internal Attributes GoverningAttribute { get; } //allows Characters to know what attribute(key) to send in (value)

        internal BaseStatValue(CharacterValueContainer container, Attributes governingAttribute = Attributes.None, float genericBase = 0, float genericScale = 0, float attributeScale = 0, float initialScale = 0)
        {
            GoverningAttribute = governingAttribute;
            //this.roundDown = roundDown;
            this.genericBase = genericBase;
            this.genericScale = genericScale;
            this.initialScale = initialScale;
            this.attributeScale = attributeScale;
            _container = container;

        }
        private float CalculatedBase()
        {
            float val = _container.StoredAttributes[(Attributes)GoverningAttribute].TotalValue * initialScale + genericBase;
            if(OnBaseUpdated != null) OnBaseUpdated(val);
            return val;
        }

        private float BonusPerLevel => _container.StoredAttributes[(Attributes)GoverningAttribute].TotalValue * attributeScale + genericScale;
        internal float Get => BonusPerLevel * (_container.StoredProgressionValues[ProgressionValues.CharacterExperience].Level - 1) + CalculatedBase();



    }
}
