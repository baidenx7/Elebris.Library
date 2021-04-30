using Elebris.Library.Units.Containers;
using System;

namespace Elebris.Library.Units.Creation
{
    public interface ICharacterFactory
    {
        Character CreateCharacter();
        Character CreateUnit(Guid guid);
    }
}