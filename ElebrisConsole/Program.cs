using Elebris.Rpg.Library.CharacterValues;
using Elebris.Rpg.Library.Factories;
using Elebris.UnitCreation.Library.StatGeneration;
using System;

namespace ElebrisConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit character = UnitFactory.CreateUnit();


            Console.WriteLine("CharacterCreated");
            bool contained = character.ValueHandler.StoredStats.ContainsKey(Stats.MoveSpeed);

            Console.WriteLine($"Found movespeed {contained}");

            float actual = character.ValueHandler.RetrieveValue(Stats.MoveSpeed);
            Console.WriteLine($"Found movespeed {actual}");
        }
    }
}
