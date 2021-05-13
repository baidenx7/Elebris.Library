using Elebris.Library.Units.Creation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Elebris
{
    public class UnitLogic : IUnitLogic
    {
        private readonly ICharacterFactory _characterFactory;
        private readonly ILogger<UnitLogic> _log;
        private readonly IConfiguration _config;

        public UnitLogic(ICharacterFactory characterFactory, ILogger<UnitLogic> log, IConfiguration config)
        {
            _characterFactory = characterFactory;
            _log = log;
            _config = config;
        }
        public void Process()
        {

        }
    }
}
