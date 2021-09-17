using System.Collections.Generic;
using Patrones.Factory.Entities.Database;

namespace Patrones.Factory.Interfaces
{
    public interface IDatabaseConnection
    {
         public bool Connect(string connectionString);
         public List<Table> GetTables();
         public List<Column> GetColumns(string tableName);
         public bool Disconnect();

    }
}