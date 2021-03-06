﻿using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Elebris.Database.Manager
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _conn;

        public SqlDataAccess(IConfiguration conn)
        {
            _conn = conn;
        }
        public string GetConnectionString(string name)
        {
            return _conn.GetConnectionString(name);
        }

        public List<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(storedProcedure, parameters,
                    commandType: CommandType.StoredProcedure).ToList();

                return rows;
            }
        }
    }
}
