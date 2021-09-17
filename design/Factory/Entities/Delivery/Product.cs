namespace Patrones.Factory.Entities.Delivery
{
    public class Product
    {
        public string Name { get; set; } 
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get{
         return Quantity * Price;    
        } 
        }        
    }
}