using Elebris.Rpg.Library.Units.Resources.Enforcing;
using Elebris.Rpg.Library.Units.Resources.Models;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Resources.Creation
{
    public interface IResourceBuilder
    {
        Dictionary<Resource, ResourceBarValue> Retrieve();
       
}