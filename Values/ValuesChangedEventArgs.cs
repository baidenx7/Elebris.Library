
using System;
using System.Collections.Generic;

namespace RPG.CharacterValues
{
    public class ValuesChangedEventArgs : EventArgs
    {
        public List<AttributeObject> CharacterAttributes { get; set; }
        public List<StatObject> CharacterStats { get; set; }

    }
}