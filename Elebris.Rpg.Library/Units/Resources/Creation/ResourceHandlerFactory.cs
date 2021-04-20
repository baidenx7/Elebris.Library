using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Resources.Creation;
using Elebris.Rpg.Library.Units.Resources.Enforcing;
using Elebris.Rpg.Library.Units.Resources.Handlers;
using Elebris.Rpg.Library.Units.Resources.Models;
using System.Collections.Generic;

namespace Elebris.Rpg.Library.Units.Resources
{
    public class ResourceHandlerFactory : IResourceHandlerFactory
    {
        Creation.IResourceBuilder resourceFactory = new Creation.ResourceFactory();
        public CharacterResourceHandler ReturnHandler(Character character )
        {
            CharacterResourceHandler handler = new CharacterResourceHandler(character, resourceFactory);
            return handler;
        }
      
       

    }



}
