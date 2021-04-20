using Elebris.Rpg.Library.Units.Resources.Enforcing;
using Elebris.Rpg.Library.Units.Resources.Models;

namespace Elebris.Rpg.Library.Units.Resources.Handlers
{
    public interface ICharacterResourceHandler
    {
        void ModifyResourceValue(Resource resources, float value);
        ResourceBarValue RetrieveResourceData(Resource value);
    }
}