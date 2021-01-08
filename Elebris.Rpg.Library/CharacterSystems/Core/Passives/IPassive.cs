using Elebris.Rpg.Library.CharacterValues;

namespace Elebris.Rpg.Library.CharacterSystems.Core.Passives
{
    public interface IPassive
    {
        void Attach(CharacterValueContainer container);
        void Detach();
    }
}