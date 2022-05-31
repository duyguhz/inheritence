using System;
namespace ClassInheritence
{
    public class Car
    {
        public double CurrentFuel;
        public double FuelCapacity;
        public void AddFuel(double wantedFuel)
           
        {
            if (wantedFuel<=FuelCapacity)
            {
                CurrentFuel += wantedFuel;
            }
            
        }
    }
}
