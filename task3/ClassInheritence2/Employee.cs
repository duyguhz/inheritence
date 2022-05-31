using System;
namespace ClassInheritence2
{
    public class Employee:Human
    {
        public Employee(string fullname) : base(fullname)
        {

        }
        public string Position;
        public int Salary;
       
    }
}
