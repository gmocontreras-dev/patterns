using Patrones.Factory.Entities.Database;
using System.Collections.Generic;

namespace Patrones.Factory.Interfaces
{
    public interface IDatabaseConnection
    {
         public bool Connect(string connectionString);
         public List<Table> GetTables();
         public List<Column> GetColumns(string tableName);
         public bool Disconnect();
         public string GetStatus();

    }
}