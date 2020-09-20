using Elebris.Library.Values;
using System;

namespace Elebris.Library.Units
{
    //Save to character, if not found create from AttributeData (In characterSaveData
    [Serializable]
    public class AttributeObject : CharacterValue
    {
        public AttributesEnum attributeType;
        public float attributeValue;

        public AttributeObject(AttributesEnum attributeType, float attributeValue)
        {
            this.attributeType = attributeType;
            this.attributeValue = attributeValue;
        }
        //reimpliment IUpdateable
    }
}
