using RPG.CharacterValues;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Library.Values
{
    public interface ILinkableValue
    {
        public void LinkEvent(CharacterValue obj);

        public void UnlinkEvent(CharacterValue obj);
    }
}
