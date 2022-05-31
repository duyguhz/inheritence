using System;

namespace classtask
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone(3000)
            {
                Brand = "Apple",
                Name = "Iphone 13",
                Camera = 14,
                SimCount = 2
                 
             };
            phone.ShowInfo();



        }

    }
}
