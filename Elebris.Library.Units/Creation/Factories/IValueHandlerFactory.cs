using Elebris.Library.Units.Containers;
using Elebris.Rpg.Library.Units.Values.Handlers;

namespace Elebris.Library.Units.Creation
{
    public interface IValueHandlerFactory
    {
        ICharacterValueHandler ReturnHandler(Character character);

    }

}