public struct CharacterTrait 
{
    public float weight; // current Weight

    private float initialValue; // stores the initial state for priority (between interactions)

    private float successPriorityValue; // value used to determine how much a success recovers weight

    private float failurePriorityValue; // value used to determine how much a failure effects weight

    private float weightRecovery; // how much the skill recovers each tick

    private int stressValue; //name is mutable, but the idea is lower your sanity/higher your stress the more irrationally youll react
    public CharacterTrait(float initialValue, float successPriorityValue, float failurePriorityValue, float weightRecovery, int stressValue)
    {
        this.weight = initialValue;
        this.initialValue = initialValue;
        this.successPriorityValue = successPriorityValue;
        this.failurePriorityValue = failurePriorityValue;
        this.weightRecovery = weightRecovery;
        this.stressValue = stressValue;
    }
    public void RecoverWeight()
    {
       weight += weightRecovery;
    }

    public void Success()
    {
         //get random value from stressValue
        //add value of stressValue to successPriorityValue
        //result added to weight
    }
    public void Failure()
    {
        //get random value from stressValue
        //add value of stressValue to failurePriorityValue
        //result subtracted from weight
    }


}