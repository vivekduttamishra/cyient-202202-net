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
            string[] grades = new string[names.Length];

            
            for(int i=0; i<marks.Length;i++)
            {
                marks[i] = ReadMarks(names[i],25); //out of 25.
                grades[i] = CalculateGrade(marks[i]*4); //grade is calculated out of 100
            }

            string header = string.Format("Roll\t{0}\tMarks\tGrade", "name".PadRight(30));
            Console.WriteLine(header.ToUpper());

           for(int i=0;i<names.Length;i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", i+1,    //roll shouldn't start with 0                 
                                                   names[i].ToUpper().PadRight(30), //add extra space to make each name 30 char in size
                                                   marks[i],
                                                   grades[i]);
            }


        }

        private static int ReadMarks(string name, int max)
        {
            while(true)
            {
                int marks = Input.ReadInt("Marks for " + name + "(out of 25) :");
                if (marks >= 0 && marks <= 25)
                    return marks;
                Console.WriteLine("Invalid Marks. Enter value between 0-25");
            }
        }

        private static string CalculateGrade(int marks)
        {
           if (marks >= 90)
                return "A+";
            else if (marks >= 80)
                return "A";
            else if (marks >= 70)
                return "B";
            else if (marks >= 60)
                return "C";
            else if (marks >= 40)
                return "D";
            else
                return "F";
        }
    }
}
