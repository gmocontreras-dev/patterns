using Patrones.Factory.Enums;
using Patrones.Factory.Interfaces;
using System;

namespace Patrones.Factory.Implementation.Database
{
    public class FactoryDataBase
    {
         private static readonly Lazy<FactoryDataBase> lazy = new Lazy<FactoryDataBase>(() => new FactoryDataBase());
        private FactoryDataBase(){}

        public static FactoryDataBase Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        public IDatabaseConnection GetConnection(DatabaseEnum database){
          
            var databaseConnection = (IDatabaseConnection)Activator.CreateInstance
              (Type.GetType($"Patrones.Factory.Implementation.Database.{Enum.GetName(typeof(DatabaseEnum), database)}DBConnection"));
            return databaseConnection;
        }
    }
}