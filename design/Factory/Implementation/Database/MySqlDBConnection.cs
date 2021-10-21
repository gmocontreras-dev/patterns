using System.Collections.Generic;
using Patrones.Factory.Entities.Database;
using Patrones.Factory.Interfaces;

namespace Patrones.Factory.Implementation.Database
{
    public class MySqlDBConnection : IDatabaseConnection
    {
        public bool Connect(string connectionString)
        {
            throw new System.NotImplementedException();
        }

        public bool Disconnect()
        {
            throw new System.NotImplementedException();
        }

        public List<Column> GetColumns(string tableName)
        {
            throw new System.NotImplementedException();
        }

        public string GetStatus()
        {
            return "MySqlDBConnection Status";
        }

        public List<Table> GetTables()
        {
            throw new System.NotImplementedException();
        }
    }
}