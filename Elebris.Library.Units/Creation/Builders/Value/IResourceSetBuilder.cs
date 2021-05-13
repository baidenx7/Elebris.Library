using Elebris.Rpg.Library.Units.Resources.Enforcing;
using Elebris.Rpg.Library.Units.Resources.Models;
using System.Collections.Generic;

namespace Elebris.Library.Units.Creation
{
    public interface IResourceSetBuilder
    {
        Dictionary<string, MeasurementValue> Retrieve();
    }
}