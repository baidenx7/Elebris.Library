
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Elebris.Database.Manager
{

    public class StatData : IStatData
    {
        private readonly ISqlDataAccess _sql;

        public StatData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<DBStatModel> GetAllStatModels()
        {
            var output = _sql.LoadData<DBStatModel, dynamic>("dbo.spStat_GetAllCharacterDefaults", new { }, "ElebrisData");
            return output;
        }
      
    }
}
