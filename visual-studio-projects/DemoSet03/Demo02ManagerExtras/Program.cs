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

            //manager has property of regular Employee
            Console.WriteLine("Id:"+manager.Id);
            Console.WriteLine("Name:"+manager.Name);
            Console.WriteLine("Salary:"+manager.Salary);


            //but we can call manager specific functionality also
            Console.WriteLine("Project:"+manager.Project);
            manager.AddToTeam(new Employee() { Id = 2, Name = "Sanjay", Salary = 20000 });
            manager.AddToTeam(new Accountant() { Id = 3, Name = "Sumit", Salary = 20000 });
            manager.AddToTeam(new Employee() { Id =4, Name = "Shweta", Salary = 20000 });
            manager.AddToTeam(new Manager() { Id = 5, Name = "Shivesh", Salary = 20000, Project="Project221" });

            Console.WriteLine("Team Size:"+manager.TeamSize);
            Console.WriteLine("Team Members:");
            for(var i=0;i<manager.TeamSize;i++)
                Console.WriteLine("\t"+manager.Team[i].Name);


            manager.Work();
            TestEmployee(manager);




            Console.WriteLine("Manager's Team size is {0} ",manager.TeamSize);
            Employee emp = manager;   //manager is an Employee. 
            Console.WriteLine("Id:"+emp.Id); //works
            Console.WriteLine("Team Size:"+ emp.TeamSize  );
           
        }

        public static void TestEmployee(Employee e)
        {
            e.Work();
        }

      
    }
}
