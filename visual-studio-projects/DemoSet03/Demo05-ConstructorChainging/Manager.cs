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
        public Employee[] Team { get; set; } 
        public int TeamSize { get; private set; } //can't be changed from outside

        public Manager(string name, double salary, string project):base(name,salary)
        {
            Project = project;
            Team = new Employee[10];
            TeamSize = 0;
        }

        public override string Info
        {
            get
            {
                var baseInfo = base.Info; //get info from base overriden info

                var updatedInfo = baseInfo.Replace("Employee", "Manager"); //replace Empoyee word in String with manager

                return string.Format("{0}\tProject={1}\tTeam Size={2}",
                                                updatedInfo, Project, TeamSize);
            }
        }

      

        public void AddToTeam(Employee emp)
        {
            Team[TeamSize] = emp; //Add employee to the Team
            TeamSize++;  //increase Team Size
        }

        public override void Work()
        {
            Console.WriteLine("Manager {0} Works with a Team of {1} member on Project {2}",Name, TeamSize, Project);
        }
       
    }
}
