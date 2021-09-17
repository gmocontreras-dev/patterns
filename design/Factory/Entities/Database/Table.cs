using System.Collections.Generic;

namespace Patrones.Factory.Entities.Database
{
    public class Table
    {
        public string Name { get; set; }
        public string Schema { get; set; }
        public List<Column> Columns { get; set; }
    }
}