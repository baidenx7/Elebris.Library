namespace Elebris.UnitCreation.Library.Handlers
{
    public class ValueProgressionTable
    {
        //create a script that generates the values for each stat levels 1-20 so that units can reference their particular stat value to update on levelup, rather than recalculating each stat individually

        //there should be one table per stat ,the tables X axis should be stat value, the Y
        //Axis should be the level.

        //for instance, using HP as an example, if level 0(base) is 300, and you get 20 per level + some scaling from constitution (lets say 2) your value at level 10 for 5 constitution would be: 600 (300 base + 200 from level + 100 for constitution)

        // 15 constitution at level 10 would be: 800 (300 base + 200 from level + 300 for constitution)

        //this should run a one-time generation of each stat , with a parameter for max level, the  CharacterValue (containing a base value, level-scaling value and relevant attribute-scaling value)

        //store either in a local database or in a scriptableobject? (SO should be fine, and can just be updated if the game ever updates/patches and values need to change for everyone)
    }

}
