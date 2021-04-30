using Elebris.Rpg.Library.Units.Actions.Models;
using Elebris.Rpg.Library.Units.Core.Models;

namespace Elebris.Rpg.Library.Units.Values.Handlers
{
    public interface ICharacterValueHandler
    {
        StatValue RetrieveValue(IRetrievableValue storable);
    }
}