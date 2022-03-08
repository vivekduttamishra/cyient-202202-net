using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10
{
    class Student
    {
        int roll;
        string name;
        int marks1;
        int marks2;
        int marks3;
       

        public Student(int roll, string name, int marks1=0,int marks2=0, int marks3=0)
        {
            this.roll = roll;
            this.name = name;
            this.marks1 = marks1;
            this.marks2 = marks2;
            this.marks3 = marks3;
        }

        public int Roll { get { return roll;  } }

        public int Marks1
        {
            get
            {
                return marks1;
            }

            set
            {
                if (ValidateMarks(value))
                    marks1 = value;

                //ignore invalid value
            }
        }

        private bool ValidateMarks(int value)
        {
            return value >= 0 && value <= 25;
        }

        public int Marks2
        {
            get
            {
                return marks2;
            }

            set
            {
                if (ValidateMarks(value))
                    marks2 = value;

                //ignore invalid value
            }
        }

        public int Marks3
        {
            get
            {
                return marks3;
            }
            set
            {
                if (ValidateMarks(value))
                    marks3 = value;
            }
        }
    
        public string Grade1
        {
            get
            {
                return CalculateGrade(marks1, 25);
            }
        }

        public String Grade2
        {
            get
            {
                return CalculateGrade(marks2, 25);
            }
        }

        public String Grade3
        {
            get
            {
                return CalculateGrade(marks3, 25);
            }
        }


        public int Total
        {
            get
            {
                return marks1 + marks2 + marks3;
            }
        }

        public int TotalPercent
        {
            get
            {
                return (int)( Total * 100.0 / 75);
            }
        }


        public string Grade
        {
            get
            {
                if (Grade1 == "F" || Grade2 == "F" || Grade3 == "F")
                    return "F";
                else
                    return CalculateGrade(Total, 75);
            }
        }

        private string CalculateGrade(int marks, int max)
        {
            double percent = marks * 100.0 / max;
            if (percent >= 90)
                return "A+";
            else if (percent >= 80)
                return "A";
            else if (percent >= 70)
                return "B";
            else if (percent >= 60)
                return "C";
            else if (percent >= 40)
                return "D";
            else
                return "F";
        }
    
    
        public string Info
        {
            get
            {
                return string.Format("{0}\t{1,-15}\t{2,2} {3,-2}\t{4,2} {5,-2}\t{6,2} {7,-2}\t{8,2} {9,-2}\t",

                        Roll, name,
                        Marks1, Grade1,
                        Marks2, Grade2,
                        Marks3, Grade3,
                        TotalPercent, Grade

                    );
            }
        }
    
    
    
    }
}
