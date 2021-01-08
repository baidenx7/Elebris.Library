namespace Elebris.UnitCreation.Library.StatGeneration
{
    //this is not my recommended way of enforcing types, I would recommend passing "StatData" references around from Scriptable objects(in unity) if possible.

    //a value of none is for things that are unmodifiable by attributes

    public enum Attributes
    {
        None,
        Agility,
        Expertise,
        Strength,
        Constitution,
        Wisdom,
        Intelligence
    }

}