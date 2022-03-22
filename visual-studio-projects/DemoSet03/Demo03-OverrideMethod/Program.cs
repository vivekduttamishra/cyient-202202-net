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

         
            

            manager.Work();   //manager's work

            TestEmployee(manager);  //manager's work

            Accountant a = new Accountant() { Name = "Sanjeev" };
            a.Work();  //account's work

            TestEmployee(a); //employee's work
        }

        public static void TestEmployee(Employee e)
        {
            e.Work();
        }

      
    }
}
