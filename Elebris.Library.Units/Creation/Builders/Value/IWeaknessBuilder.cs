using Elebris.Rpg.Library.Units.Combat.Models;
using System.Collections.Generic;

namespace Elebris.Library.Units.Creation
{
    public interface IWeaknessBuilder
    {
        Dictionary<string, WeaknessValue> Retrieve();
    }
}