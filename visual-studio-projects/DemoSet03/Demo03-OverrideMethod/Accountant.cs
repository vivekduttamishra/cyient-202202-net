using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01EmployeeHierarchy
{
    class Accountant : Employee
    {
        public new void Work()
        {
            Console.WriteLine("Accountant {0} works",Name);
        }
    }
}
