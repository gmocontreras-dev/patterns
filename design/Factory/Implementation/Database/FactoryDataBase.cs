using Patrones.Factory.Enums;

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
        public IDatabaseConnection GetDatabase(DatabaseEnum database){
            
        }
    }
}