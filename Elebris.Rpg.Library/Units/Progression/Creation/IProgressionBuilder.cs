using Elebris.Core.Library.CharacterValues.Mutable;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Progression.Creation
{
    public interface IProgressionBuilder
    {
        Dictionary<ProgressionValues, ProgressionValue> Retrieve();
    }
}