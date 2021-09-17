using System;
using Patrones.Factory.Entities.Delivery;
using Patrones.Factory.Enums;
using Patrones.Factory.Interfaces;

namespace Patrones.Factory.Implementation.Delivery
{
    public sealed class FactoryDelivery
    {
        private static readonly Lazy<FactoryDelivery> lazy = new Lazy<FactoryDelivery>(() => new FactoryDelivery());
        private FactoryDelivery(){}

        public static FactoryDelivery Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        public double Calculate(CountryEnum country, Product product){
             var delivery = (IDelivery)Activator.CreateInstance
              (Type.GetType($"Patrones.Factory.Implementation.Delivery.{Enum.GetName(typeof(CountryEnum), country)}Delivery"));
              return delivery.Calculate(product);

        }
    }
}