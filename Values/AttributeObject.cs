

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Elebris.Library.Values
{
    public interface IAttributeObject1
    {
        void LinkEvent(CharacterValue obj);
        void UnlinkEvent(CharacterValue obj);
    }

    public interface IAttributeObject
    {
        void LinkEvent(CharacterValue obj);
        void UnlinkEvent(CharacterValue obj);
    }

    //Save to character, if not found create from AttributeData (In characterSaveData
    [Serializable]
    public class AttributeObject : CharacterValue, IAttributeObject
    {
        public AttributeData attributeType;
        public float attributeValue;

        public AttributeObject(AttributeData attributeType, float attributeValue)
        {
            this.attributeType = attributeType;
            this.attributeValue = attributeValue;
        }
        public void LinkEvent(CharacterValue obj)
        {
            //values that depend on this need to pass themselves in
            ValueModifiedEvent += DependantEventCalled;

            //Have the dependant value pass itself in (Attribute.Linkevent(this);)
        }

        public void UnlinkEvent(CharacterValue obj)
        {
            //values that depend on this but are removed (ondisable etc) need to remove themselves
            ValueModifiedEvent -= DependantEventCalled;
        }
    }
}


