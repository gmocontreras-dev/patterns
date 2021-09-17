using Patrones.Factory.Entities.Delivery;
using Patrones.Factory.Interfaces;

namespace Patrones.Factory.Implementation.Delivery
{
    public class BrasilDelivery : IDelivery
    {
        public double Calculate(Product product)
        {
            
            return product.Total * 0.2;
        }
    }
}