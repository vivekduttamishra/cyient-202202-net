using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            CNumber cn=new CNumber(20);
            SNumber sn=new SNumber(20);

            Console.WriteLine(cn);
            Console.WriteLine(sn);
        }
    }
}
