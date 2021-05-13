using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elebris.Configuration.Components
{
    public class UnitService
    {
        private readonly ILogger<UnitService> _log;
        private readonly IConfiguration _config;

        public UnitService(ILogger<UnitService> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }
    }
}
