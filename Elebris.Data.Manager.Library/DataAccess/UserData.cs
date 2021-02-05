using Elebris.Data.Manager.Library.Internal.DataAccess;
using Elebris.Data.Manager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elebris.Data.Manager.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserByID(string Id)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new { Id = Id };
            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "ElebrisData");
            return output;
        }
    }
}
