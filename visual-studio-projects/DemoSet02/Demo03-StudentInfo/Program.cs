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
            //we will store actual details from row 1 onward
            //row 0 will not be used.
            //so roll 1 will be on index 1. roll 2 will be index 2 and so on


            string[] names =
            {
                null,  //row 0 is left blank. It will not be used to match roll number and index
                "Amit Singh",   //roll 1
                "Fagun Pandya", //roll 2
                "Vivek Dutta Mishra",
                "Dushyant Pandya",
                "Mahesh Rajput"
            };

            int [][] marks = new int[names.Length][]; //specify the total rows
            //now specify the content of each column as an array of 3 int
            //we have 3 subjects. we are going to create 4 columns
            //column 0 will contain total marks.
            //colum 1 onward will represent each susbject
            


            for (int i = 0; i < marks.Length; i++)
                marks[i] = new int[4];


            string[][] grades = new string[names.Length][];
            for (int i = 0; i < grades.Length; i++)
                grades[i] = new string[4];


            //Step #1 Read the marks of each student in each paper 
            for(int roll=1;roll<names.Length;roll++) //note we are not using row 0
            {
                Console.WriteLine("Enter Marks for Roll {0} \t {1}",roll, names[roll]);

                for(int paper=1; paper< marks[roll].Length;paper++)
                {
                    Console.Write("\t");
                    marks[roll][paper] = ReadMarks(paper, 25);
                }

                Console.WriteLine();

            }

            //Step #2 calculate total and grade


            //Step #3 Display the result
            string header = string.Format("Roll\t{0}\tPaper1\tPaper2\tPaper3\tTotal\tGrade", "Name".PadRight(20));
            Console.WriteLine(header.ToUpper());
            for( int roll = 1; roll < names.Length; roll++)
            {
                Console.Write("{0}\t{1}\t",roll, names[roll].PadRight(20));
                int total = 0;
                for(int paper=1; paper<marks[roll].Length;paper++)
                {
                    Console.Write("{0}\t", marks[roll][paper]);
                    total += marks[roll][paper];
                }
                Console.WriteLine("{0}",total);
            }

           

        }

        private static int ReadMarks(int paper, int max)
        {
            while(true)
            {
                int marks = Input.ReadInt("Marks for Subject#" + paper + "(out of 25) :");
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
