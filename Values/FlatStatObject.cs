namespace RPG.CharacterValues
{
    public class FlatStatObject : StatObject
    {
        FlatStatData statData;

        public FlatStatObject(float initialBaseValue,AttributeObject[] attributeObjects,FlatStatData statData)
        {
            this.BaseValue = initialBaseValue;
            this.statData = statData; // for calculations
            this.statType = statData; //for comparisons
            this.referenceAttributes = attributeObjects;
            foreach (var item in referenceAttributes)
            {
                item.LinkEvent(this);
            }
        }

        public override void CalculateBaseValue(AttributeObject[] attributeObjects, int level)
        {
            this.BaseValue = statData.UpdateBaseValue(referenceAttributes);
        }

    }



}