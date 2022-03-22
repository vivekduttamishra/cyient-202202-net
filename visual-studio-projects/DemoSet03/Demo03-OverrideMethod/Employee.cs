using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01EmployeeHierarchy
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Salary { get; set; }

        public virtual void Work()
        {
            Console.WriteLine("Employee {0}-{1} works for salary {2}",Id,Name,Salary);
        }

        public string Info
        {
            get
            {
                return string.Format("Employee\tId={0}\tName={1}\tSalary={2}", Id, Name, Salary);
            }
        }
    }
}
