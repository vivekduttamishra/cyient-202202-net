using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01EmployeeHierarchy
{
    class Manager : Employee
    {
        public string Project { get; set; }
        public Employee[] Team { get; set; } = new Employee[10]; //max 10 employee
        public int TeamSize { get; private set; } //can't be changed from outside

        public void AddToTeam(Employee emp)
        {
            Team[TeamSize] = emp; //Add employee to the Team
            TeamSize++;  //increase Team Size
        }

        public void Work()
        {
            Console.WriteLine("Manager {0} Works with a Team of {1} member on Project {2}",Name, TeamSize, Project);
        }
       
    }
}
