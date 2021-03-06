using Elebris.Data.Manager.Library.Internal.DataAccess;
using Elebris.Data.Manager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Elebris.Data.Manager.Library.DataAccess
{
    public class StatData
    {
        public List<DBCharacterStatModel> GetStatData()
        {
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<DBCharacterStatModel, dynamic>("dbo.spStat_GetAll", new { }, "ElebrisData");
            return output;
        }
        public DBCharacterStatModel GetStatById(int statId)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<DBCharacterStatModel, dynamic>("dbo.spStat_GetById", new { id = statId }, "ElebrisData").FirstOrDefault();
            return output;
        }

        public void SaveCharacterStat(DBCharacterStatModel model, string userId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SaveData<DBCharacterStatModel>("dbo.spStat_Insert", model, "ElebrisData");
        }
    }

}
