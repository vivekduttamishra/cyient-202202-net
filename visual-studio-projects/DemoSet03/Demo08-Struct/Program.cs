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
            CNumber cn1=new CNumber(20);
            SNumber sn1=new SNumber(20);

            CNumber cn2 = cn1;
            SNumber sn2 = sn1;

            Console.WriteLine(cn1);
            Console.WriteLine(cn2);

            Console.WriteLine(sn1);
            Console.WriteLine(sn2);

            cn2.Value = 100;
            sn2.Value = 100;

            Console.WriteLine("After changing values");

            Console.WriteLine(cn1);
            Console.WriteLine(cn2);

            Console.WriteLine(sn1);
            Console.WriteLine(sn2);

            //CNumber cn3 = new CNumber(); //no zero arg constructor
            //SNumber sn3 = new SNumber(); //default zero arg constructor exists


            string str1="hello";

            String str2="hi";

            object o1="hello";

            Object o2="hi";


            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(o1);
            Console.WriteLine(o2);

        }
    }
}
