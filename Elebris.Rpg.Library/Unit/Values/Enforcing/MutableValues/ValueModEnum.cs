namespace Elebris.Core.Library.Enums
{
    public enum ValueModEnum
    {
        Flat = 100,
        PercentAdd = 200,
        PercentMult = 300, //these values are calculated one at a time, rather then added and then multiplied as one lump amount
    }
}