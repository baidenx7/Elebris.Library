using Elebris.Rpg.Library.Units.Resources.Enforcing;
using Elebris.Rpg.Library.Units.Resources.Models;

namespace Elebris.Rpg.Library.Units.Resources.Handlers
{
    public interface IExternalInteractionHandler
    {
        void ModifyResourceValue(string resources, float value);
        ResourceBarValue RetrieveResourceData(string value);
    }
}