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
            var srManager = new Manager("Prabhat", 600000, "R%D");


            var accountant = new Accountant("Amit", 200000);
            var officeAssistant = new Employee("Subodh", 30000);
            var jrManager = new Manager("Sanjay", 500000, "R&D Project1");


            srManager.AddToTeam(accountant);
            srManager.AddToTeam(jrManager);
            jrManager.AddToTeam(officeAssistant);

            PrintEmployeeInfo(srManager);
            
        }

        private static void PrintManagerInfo(Manager manager)
        {
            Console.WriteLine("Project:"+manager.Project);
            Console.WriteLine("Team:"+manager.TeamSize);
            for(int i=0; i < manager.TeamSize; i++)
            {
                var member = manager.Team[i];
                PrintEmployeeInfo(member);
            }                
        }

        private static void PrintEmployeeInfo(Employee employee)
        {
            Console.WriteLine(employee.Info);
            if (employee is Manager)
                PrintManagerInfo((Manager)employee);
        }
    }
}
