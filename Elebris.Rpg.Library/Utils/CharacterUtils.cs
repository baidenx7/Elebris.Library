using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Rpg.Library.Utils
{
    public static class CharacterUtils
    {
        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

    }
}
