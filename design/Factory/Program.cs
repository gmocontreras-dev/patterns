using System;
using Patrones.Factory.Entities.Delivery;
using Patrones.Factory.Implementation.Database;
using Patrones.Factory.Implementation.Delivery;
using Patrones.Factory.Interfaces;

namespace Patrones.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            RunDatabase();
            Console.ReadKey();
        }
        private static void RunDatabase()
        {
           IDatabaseConnection databaseConnection = FactoryDataBase.Instance.GetConnection(Enums.DatabaseEnum.SqlServer);
            Console.WriteLine($"{databaseConnection.GetStatus()}");
        }
        private static void RunDelivery(){
            Product product = new Product{
                Name="p1",
                Price=10,
                Quantity=1
            };
            //Patrones usados
            /*
            1.- Singleton
            2.- Fachada 
            3.- Factory dinamica pos wey
            */
            IDelivery argentinaDelivery = new ArgentinaDelivery();
            IDelivery brasilDelivery = new BrasilDelivery();
            IDelivery chileDelivery = new ChileDelivery();
            Console.WriteLine($"Argentina: { FactoryDelivery.Instance.Calculate(Enums.CountryEnum.Argentina,product)}");
            Console.WriteLine($"Brasil: {FactoryDelivery.Instance.Calculate(Enums.CountryEnum.Brasil,product)}");
            Console.WriteLine($"Chile: {FactoryDelivery.Instance.Calculate(Enums.CountryEnum.Chile,product)}");
        }
    }
}
