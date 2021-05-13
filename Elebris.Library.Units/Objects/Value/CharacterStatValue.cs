namespace Elebris.Rpg.Library.Units.Core.Models
{
    public class CharacterStatValue : StatValue
    {
        public CharacterStatValue() : base()
        {

        }
        public CharacterStatValue(float baseValue) : base(baseValue)
        {

        }

        public void RebaseValue(float val)
        {
            baseValue = val;
        }
    }

}
