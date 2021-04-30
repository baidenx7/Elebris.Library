using Elebris.Database.Manager.Helpers;
using Elebris.Database.Manager.Models;
using System.Collections.Generic;

namespace Elebris.Database.Manager.DataAccess
{
    public class DefaultCharacterStatData
    {
        private readonly SqlDataAccess _sql;

        public DefaultCharacterStatData()
        {
            _sql = new SqlDataAccess();
        }

        public List<DefaultStatModel> GetAllStatModels()
        {

            var output = _sql.LoadData<DefaultStatModel, dynamic>("dbo.spStat_getAll", new { }, "ElebrisData");
            return output;
        }
    }
}
