using Elebris.Rpg.Library.Units.Core.Models;
using Elebris.Rpg.Library.Units.Values.Enforcing;
using System.Collections.Generic;

namespace Elebris.Library.Units.Creation
{
    public interface IAttributeSetBuilder
    {
        Dictionary<string, StatValue> GenerateClassAttributeSet();
        Dictionary<string, StatValue> GenerateClassAttributeSet(params CharacterAttributes[] classAttributes);
    }
}