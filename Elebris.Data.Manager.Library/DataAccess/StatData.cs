using Elebris.Data.Manager.Library.Internal.DataAccess;
using Elebris.Data.Manager.Library.Models;
using System.Collections.Generic;

namespace Elebris.Data.Manager.Library.DataAccess
{
    public class StatData
    {
        public List<CharacterStatModel> GetStatData()
        {
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<CharacterStatModel, dynamic>("dbo.spStat_GetAll", new { }, "ElebrisData");
            return output;
        }
    }

}
