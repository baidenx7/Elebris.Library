using Elebris.Data.Manager.Library.Internal.DataAccess;
using Elebris.Data.Manager.Library.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Data.Manager.Library.DataAccess
{
    public class StatData
    {
        private readonly IConfiguration _config;

        public StatData(IConfiguration config)
        {
            _config = config;
        }
        //rollback functionality was used here in vid 24. I declined to implement it
        public List<DBCharacterStatModel> GetStatData()
        {
            SqlDataAccess sql = new SqlDataAccess(_config);
            var output = sql.LoadData<DBCharacterStatModel, dynamic>("dbo.spStat_GetAll", new { }, "ElebrisData");
            return output;
        }
        public DBCharacterStatModel GetStatById(int statId)
        {
            SqlDataAccess sql = new SqlDataAccess(_config);
            var output = sql.LoadData<DBCharacterStatModel, dynamic>("dbo.spStat_GetById", new { id = statId }, "ElebrisData").FirstOrDefault();
            return output;
        }

        public void SaveCharacterStat(DBCharacterStatModel model, string userId)
        {
            SqlDataAccess sql = new SqlDataAccess(_config);

            sql.SaveData("dbo.spStat_Insert", model, "ElebrisData");
        }

    }

}
