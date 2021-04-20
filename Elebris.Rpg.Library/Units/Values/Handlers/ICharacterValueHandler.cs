using Elebris.Rpg.Library.Units.Actions.Models;
using Elebris.Rpg.Library.Units.Core.Models;
using Elebris.Rpg.Library.Units.Values.Enforcing;

namespace Elebris.Rpg.Library.Units.Values.Handlers
{
    public interface ICharacterValueHandler
    {
        StatValue RetrieveValue(IRetrievableValue storable);
    }
}