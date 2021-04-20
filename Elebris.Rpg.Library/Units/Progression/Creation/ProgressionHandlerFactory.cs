using Elebris.Core.Library.CharacterValues.Mutable;
using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Progression.Creation;
using Elebris.Rpg.Library.Units.Progression.Handlers;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Rpg.Library.Units.Progression
{
    public class ProgressionHandlerFactory : IProgressionHandlerFactory
    {
        IProgressionBuilder defaultProgressionFactory = new ProgressionBuilder();
        public CharacterProgressionHandler ReturnHandler(Character character)
        {
            CharacterProgressionHandler handler = new CharacterProgressionHandler(character, defaultProgressionFactory);
            
            return handler;
        }

    }



}
