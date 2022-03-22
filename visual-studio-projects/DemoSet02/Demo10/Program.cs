using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = GetStudents();


            PrintMarkList(students);
            

           


            
        }

        private static void PrintMarkList(Student[] students)
        {
            Console.WriteLine("Roll\t{0,15}\tPaper1\tPaper2\tPaper3\tTotal","Name");
            foreach(Student student in students)
            {
                Console.WriteLine(student.Info);
            }
        }

        private static Student[] GetStudents()
        {
            string[] names = { "Fagun", "Amit", "Chetan", "Dushyant", "Ketan" };

            Student[] students =new Student[names.Length];
            int roll = 0;
            Random random = new Random();


            for(int i=0;i<names.Length;i++)
            {
                int min = random.Next(100) > 20 ? 10 : 0; //80% cases we choose min marks as 10.
                roll++;

                Student s = new Student(roll, names[i]);
                s.Marks1 = random.Next(min, 26);
                s.Marks2 = random.Next(min, 26);
                s.Marks3 = random.Next(min, 26);

                students[i] = s; //add new student to my list of students
            }

            return students;
        }


        
    }
}
