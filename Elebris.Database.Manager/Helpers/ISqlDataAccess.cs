using System.Collections.Generic;

namespace Elebris.Database.Manager
{
    public interface ISqlDataAccess
    {
        string GetConnectionString(string name);
        List<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName);
    }
}