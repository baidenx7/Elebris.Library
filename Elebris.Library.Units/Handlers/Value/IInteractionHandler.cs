using Elebris.Rpg.Library.Units.Resources.Enforcing;
using Elebris.Rpg.Library.Units.Resources.Models;

namespace Elebris.Rpg.Library.Units.Resources.Handlers
{
    public interface IInteractionHandler
    {
        void ModifyMeasurementValue(string resources, float value);
        MeasurementValue RetrieveResourceData(string value);
    }
}