using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_StudentInfoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names =
            {
                "Amit Singh",
                "Fagun Pandya",
                "Vivek Dutta Mishra",
                "Dushyant Pandya",
                "Mahesh Rajput"
            };

            int[] marks = new int[names.Length];
            
            for(int i=0; i<marks.Length;i++)
            {
                marks[i] = Input.ReadInt("Marks for " + names[i] + ": ");
            }

            string header = string.Format("Roll\t{0}\tMarks", "name".PadRight(30));
            Console.WriteLine(header.ToUpper());

           for(int i=0;i<names.Length;i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}", i+1,    //roll shouldn't start with 0                 
                                                   names[i].ToUpper().PadRight(30), //add extra space to make each name 30 char in size
                                                   marks[i]);
            }


        }
    }
}
