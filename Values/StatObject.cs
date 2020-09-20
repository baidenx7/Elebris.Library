using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Elebris.Library.Values
{

    public class StatObject : CharacterValue, IStatObject
    {
        //public StatData statType;
        public AttributeObject[] referenceAttributes;


        public StatObject(float initialBaseValue,AttributeObject[] attributeObjects)
        {
            //removed parameter FlatStatData statData
            this.BaseValue = initialBaseValue;
            //this.statData = statData; // for calculations
            //this.statType = statData; //for comparisons
            this.referenceAttributes = attributeObjects;
            foreach (var item in referenceAttributes)
            {
                item.LinkEvent(this);
            }
        }

        public override void CalculateBaseValue(AttributeObject[] attributeObjects, int level)
        {
            //can reference the static ValuePRogressionTable class instead
            //this.BaseValue = statData.UpdateBaseValue(referenceAttributes);
        }
        public override void DependantEventCalled(int level)
        {
            //instead have this listen in for certain events (relevant attribute) and update at that time
            isDirty = true;
            CalculateBaseValue(referenceAttributes, level);

        }
    }



}