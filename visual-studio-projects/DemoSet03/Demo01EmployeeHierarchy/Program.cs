using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01EmployeeHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Accountant();
            emp1.Name = "Sanjay";
            emp1.Salary = 50000;
            emp1.Id = 1;

            Employee emp2 = new Accountant()
            {
                Id = 2,
                Name = "Prabhat",
                Salary = 100000
            };



            TestEmployee(emp1);
        }

        private static void TestEmployee(Employee emp1)
        {
            emp1.Work();
            Console.WriteLine(emp1.Info);
        }
    }
}
