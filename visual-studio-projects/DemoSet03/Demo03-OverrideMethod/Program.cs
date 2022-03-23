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

          
            Manager manager = new Manager(){ Id = 3,   Name = "Aman", Salary = 200000,  //Employee properties
                            Project="R&D"      //manager specific properties
            };




            manager.AddToTeam(new Accountant() { Name = "Subhash" });
            manager.AddToTeam(new Employee() { Name = "Vivek" });

            Employee e = manager;

            Console.WriteLine(e.Info);
        }

        public static void TestEmployee(Employee e)
        {
            e.Work();
        }

      
    }
}
