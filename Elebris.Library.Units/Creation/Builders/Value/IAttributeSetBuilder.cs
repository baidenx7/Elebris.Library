using Elebris.Rpg.Library.Units.Core.Models;
using Elebris.Rpg.Library.Units.Values.Enforcing;
using System.Collections.Generic;

namespace Elebris.Library.Units.Creation
{
    public interface IAttributeSetBuilder
    {
        Dictionary<string, CharacterStatValue> GenerateClassAttributeSet();
        Dictionary<string, CharacterStatValue> GenerateClassAttributeSet(params CharacterAttributes[] classAttributes);
    }
}