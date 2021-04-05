using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elebris.Data.Manager.Library.Internal.DataAccess
{
    internal class SqlDataAccess : IDisposable
    {
        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public string GetConnectionString(string name)
        {
            return _config.GetConnectionString(name);
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
        public void SaveData<T>(string storedProcedure, T parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

            }
        }


        //Use the following methods to enforce successful database commits on multi-part calls
        //https://www.youtube.com/watch?v=QVkpzuiiVtw&list=PLLWMQd6PeGY0bEMxObA6dtYXuJOGfxSPx&index=25

        private IDbConnection _connection;
        private IDbTransaction _transaction;
        public void StartTransaction(string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);
            _connection = new SqlConnection(connectionString);
            _transaction = _connection.BeginTransaction();

            isClosed = false;
        }

        public void SaveDataInTransaction<T>(string storedProcedure, T parameters, string connectionStringName)
        {
                _connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure, transaction:_transaction);

        }
        public List<T> LoadDataInTransaction<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            
                List<T> rows = _connection.Query<T>(storedProcedure, parameters,
                    commandType: CommandType.StoredProcedure, transaction: _transaction).ToList();

                return rows;
           
        }

        private bool isClosed = false;
        private readonly IConfiguration _config;

        public void CommitTransaction()
        {
            _transaction?.Commit();
            _connection?.Close();

            isClosed = true;
        }
        public void RollBackTransaction()
        {
            _transaction?.Rollback();
            _connection?.Close();
            isClosed = true;
        }

        public void Dispose()
        {
            if(!isClosed)
            {
                try
                {

                    CommitTransaction();
                }
                catch (Exception)
                {
                    //TODO log this issue
                }
            }
        }
    }
}
