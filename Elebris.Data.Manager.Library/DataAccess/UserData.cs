using Elebris.Data.Manager.Library.Internal.DataAccess;
using Elebris.Data.Manager.Library.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Elebris.Data.Manager.Library.DataAccess
{
    public class UserData
    {
        private readonly IConfiguration _config;

        public UserData(IConfiguration config)
        {
            _config = config;
        }
        public List<UserModel> GetUserById(string Id)
        {
            SqlDataAccess sql = new SqlDataAccess(_config);
            var p = new { Id = Id };
            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "ElebrisData");
            return output;
        }
    }
}
