using System;
namespace classtask
{
    public class Product
    {   public Product(double price)
        {
            this.Price = price;
        }
        public string Brand;
        public string Name;
        public double Price;


        public void ShowInfo()
        {
            Console.WriteLine($"brand:{Brand}-name:{Name}-price:{Price}");
        }

    }
}
