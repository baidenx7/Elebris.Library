
using System;
using System.Collections.Generic;

namespace Elebris.Library.Values
{
    public class ValuesChangedEventArgs : EventArgs
    {
        public List<AttributeObject> CharacterAttributes { get; set; }
        public List<StatObject> CharacterStats { get; set; }

    }
}