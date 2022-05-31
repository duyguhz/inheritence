using System;

namespace ClassInheritence2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee-lerin sayini daxil edin:");
            string EmployeeCountStr = Console.ReadLine();
            int EmployeeCount = Convert.ToInt32(EmployeeCountStr);

            Employee[] employees = new Employee[EmployeeCount];
            for (int i = 0; i < EmployeeCount; i++)
            {
                Console.WriteLine($"{i + 1}. Employeenin adi:");
                string fullname = Console.ReadLine();

                Console.WriteLine($"{i + 1}. employeenin yasi :");
                string age = Console.ReadLine();

                Console.WriteLine($"{i + 1}. emoloyeenin vezifesi:");
                string position = Console.ReadLine();

                Console.WriteLine($"{i + 1}. employeenin maasi:");
                string salary = Console.ReadLine();

            }
            Console.WriteLine("filterleme aparmaq isteyirsiniz?");
            string filterStr = Console.ReadLine();
            
           
            
            }




           
        }
    }
}
