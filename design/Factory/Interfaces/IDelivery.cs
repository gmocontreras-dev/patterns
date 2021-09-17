using Patrones.Factory.Entities.Delivery;
namespace Patrones.Factory.Interfaces
{
    public interface IDelivery
    {
         public double Calculate(Product product);
    }
}