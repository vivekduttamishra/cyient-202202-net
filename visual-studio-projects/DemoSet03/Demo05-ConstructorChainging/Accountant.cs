using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01EmployeeHierarchy
{
    class Accountant : Employee
    {
        public Accountant(string name, double salary) : base(name, salary)
        {
        }

        public new void Work()
        {
            Console.WriteLine("Accountant {0} works",Name);
        }
    }
}
