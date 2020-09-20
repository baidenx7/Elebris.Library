using Elebris.Library.Values;

namespace Elebris.Library.Units
{
    public class StatObject : CharacterValue
    {
        //public StatData statType;
        public AttributeObject[] referenceAttributes;

        public StatsEnum statType;


        public StatObject(float initialBaseValue, AttributeObject[] attributeObjects)
        {
            //removed parameter FlatStatData statData
            this.BaseValue = initialBaseValue;
            //this.statData = statData; // for calculations
            //this.statType = statData; //for comparisons
            this.referenceAttributes = attributeObjects;
            foreach (var item in referenceAttributes)
            {
                //item.LinkEvent(this);
            }
        }
        //calculatebasevalue() used to call on each linked stat
        //UpdateLinkedStats() called by the event linked ins tatobject

        //reimpliment Istatobject
    }
}
