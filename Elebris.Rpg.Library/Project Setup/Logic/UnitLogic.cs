using Elebris.Rpg.Library.Units.Core.Creation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elebris.Rpg.Library.Project_Setup.Logic
{
    public class UnitLogic : IUnitLogic
    {
        private readonly ICharacterFactory _characterFactory;

        public UnitLogic(ICharacterFactory characterFactory)
        {
            _characterFactory = characterFactory;
        }
        public void Process()
        {

        }
    }
}
