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


            string[] names = AdmitStudents();

            int[][] marks = GetRandomStudentMarks(names); //create marks array and return


            string[][] grades = CalculateResult(marks); //create grades array and return



            //Step #3 Display the result
            PrintMarkSheet(names, marks,grades);

        }

        private static void PrintMarkSheet(string[] names, int[][] marks,string [][] grades)
        {

            string header = string.Format("Roll\t{0}", "Name".PadRight(20));

            for(int i=1; i< marks[0].Length; i++)
            {
                header += String.Format("\tPaper {0,3}", i );
            }

            header += "\tTotal\tGrade";

            
            Console.WriteLine(header.ToUpper());
            for (int roll = 1; roll < names.Length; roll++)
            {
                Console.Write("{0}\t{1}\t", roll, names[roll].PadRight(20));
               
                for (int paper = 1; paper < marks[roll].Length; paper++)
                {
                    //TODO: display individual paper grade also here
                    Console.Write("{0,2}  {1,5}  \t", marks[roll][paper],grades[roll][paper]);
                    
                }

                //total = marks[roll][0] + marks[roll][1] + marks[roll][2];

                Console.WriteLine("{0}\t{1}", marks[roll][0],grades[roll][0]); //total is calculated and stored on 0 index;
            }
        }

        private static string[][] CalculateResult(int[][] marks)
        {
            string[][] grades = new string[marks.Length][]; //same length as total rows in marks table
            for(int i = 0; i < grades.Length; i++)
            {
                grades[i] = new string[marks[0].Length]; //same number of columns as marks table 0 (any) row has 
            }

            //now we have string table with same length as marks table

            //lets do calcualtion for each student one by one

            for(int roll = 1; roll < marks.Length; roll++)
            {
                //now calculate total and grade for each roll
                int total = 0;
                string overallGrade = null;  //we don't know overall grade yet;

                for(int paper=1;paper<marks[roll].Length;paper++)
                {
                    //what is the percent marks for current roll in current paper?
                    int percent = marks[roll][paper] * 4;
                    //what is the grade for this marks?
                    string grade = CalculateGrade(percent);
                    //save this grade in the grade table

                    grades[roll][paper] = grade; //grade is added to grade table

                    //check if overallGrade is not calculated and current Grade is "F"
                    if (grade == "F" )
                        overallGrade = "F"; //Now overall grade will be fail
                    //update the total
                    total += marks[roll][paper]; //total is getting calculated by adding marks in each subject
                }

                //let us store the total and overall grade of this roll
                marks[roll][0] = total;  //total marks is updated
                int totalPapers = marks[roll].Length - 1;

                int totalPercent = total * 100 / (25 * totalPapers); //total subject count                                  
                // Console.WriteLine("{0}/{1} = {2} %", total, 25* totalPapers,totalPercent);                
                //overallGrade null here means student has not got 'F' grade in any paper
                if (overallGrade == null)
                    overallGrade = CalculateGrade(totalPercent); //Calculate actual grade

                grades[roll][0] = overallGrade; //total grade is included
            }

            return grades;

        }

        private static string[] AdmitStudents()
        {
            string[] names =
            {
                null,  //row 0 is left blank. It will not be used to match roll number and index
                "Amit Singh",   //roll 1
                "Fagun Pandya", //roll 2
                "Vivek Dutta Mishra",
                "Dushyant Pandya",
                "Mahesh Rajput"
            };
            return names;
        }

        static int[][] GetStudentMarks(string [] names)
        {
            int[][] marks = new int[names.Length + 1][]; //remember we will not use index 0

            int subjectCount = Input.ReadInt("How many Papers?");

            for (int i = 0; i < marks.Length; i++)
                marks[i] = new int[subjectCount + 1]; //remember 0 index will hold the total marks.


            
            for (int roll = 1; roll < names.Length; roll++) //note we are not using row 0
            {
                Console.WriteLine("Enter Marks for Roll {0} \t {1}", roll, names[roll]);

                for (int paper = 1; paper < marks[roll].Length; paper++)
                {
                    Console.Write("\t");
                    marks[roll][paper] = ReadMarks(paper, 25);
                }

                Console.WriteLine();

            }

            return marks;
        }


        static int[][] GetRandomStudentMarks(string[] names)
        {
            int[][] marks = new int[names.Length + 1][]; //remember we will not use index 0
            Random random = new Random();
            int subjectCount = Input.ReadInt("How many Papers?");

            for (int i = 0; i < marks.Length; i++)
                marks[i] = new int[subjectCount + 1]; //remember 0 index will hold the total marks.



            for (int roll = 1; roll < names.Length; roll++) //note we are not using row 0
            {
                Console.WriteLine("Marks for Roll {0} \t {1}", roll, names[roll]);

                for (int paper = 1; paper < marks[roll].Length; paper++)
                {
                    //Console.Write("\t");
                    //marks[roll][paper] = ReadMarks(paper, 25);
                    marks[roll][paper] = random.Next(0, 26); //will genrate value between 0 and 25
                    Console.WriteLine("\tpaper#1: "+marks[roll][paper]);
                }

                Console.WriteLine();

            }

            return marks;
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
