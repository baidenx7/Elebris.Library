namespace Elebris.Rpg.Library.Units.Actions.Models
{
    public struct WeaponAttackRetreivalModel : IRetrievableValue
    {
        public enum Type
        {
            Global,
            Light,
            Heavy,
            Modified //essentially Attacks initiated in any way besides using the light/heavy attack button .
        }

        public enum Category
        { 
            Windup,
            Range,
            Recovery,

            ChargeTimeReduction,
            ChargeCostReduction,

            ChargeMoveSpeedModifier,
            ChargeValueIncrease,
            
        }

        public string FormattedString => throw new System.NotImplementedException();
    }


}
