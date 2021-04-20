using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Values.Handlers;

namespace Elebris.Rpg.Library.Units.Values.Creation
{
    public interface IValueHandlerFactory
    {
        ICharacterValueHandler ReturnHandler(Character character);

    }

}