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

            Employee employee = new Employee()  { Id = 1, Name = "Prabhat",  Salary = 100000  };
            Accountant accountant = new Accountant() {Id = 2, Name = "Sanjay", Salary = 100000 };
            Manager manager = new Manager(){ Id = 3,   Name = "Aman", Salary = 200000      };

            TestEmployee(employee);
            TestEmployee(accountant);
            TestEmployee(manager);
        }

        private static void TestEmployee(Employee employee)
        {
          
            Console.WriteLine("current employee is "+employee);
            Console.WriteLine("Is He An    Employee: {0}", employee is Employee);
            Console.WriteLine("Is He A      Manager: {0}", employee is Manager);
            Console.WriteLine("Is He An  Accountant: {0}", employee is Accountant);
            Console.WriteLine();

        }
    }
}
