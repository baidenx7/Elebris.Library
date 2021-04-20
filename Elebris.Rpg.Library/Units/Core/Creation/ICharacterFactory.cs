using Elebris.Rpg.Library.Unit.Core.Containers;
using System;

namespace Elebris.Rpg.Library.Units.Core.Creation
{
    public interface ICharacterFactory
    {
        Character CreateCharacter();
        Character CreateUnit(Guid guid);
    }
}