namespace RPG.CharacterValues
{
    public class ScalingStatObject : StatObject
    {
        ScalingStatData statData;
        public ScalingStatObject(float initialBaseValue, ScalingStatData statData)
        {
            this.BaseValue = initialBaseValue;
            this.statType = statData; //for comparisons
            this.statData = statData; //for recalculating
            //work on linking stats directly to attributes later
            //foreach (var item in referenceAttributes)
            //{
            //    item.LinkEvent(this);
            //}
        }

        public override void CalculateBaseValue(AttributeObject[] attributeObjects,int level)
        {
           this.BaseValue = statData.UpdateBaseValue(referenceAttributes, level);
        }

    }



}