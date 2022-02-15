using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Utils
{
    public class Input
    {
        public static string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int ReadInt(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            return int.Parse(input);
        }


        public static double ReadDouble(string prompt)
        {
            return double.Parse(ReadString(prompt));
        }

        public static bool ReadBoolean(string prompt)
        {
            string answer = ReadString(prompt);

            answer = answer.ToLower(); //convert string to all lower case Yes --> yes   NO --> no


            if (answer == "true" || answer == "t" || answer == "yes" || answer == "y" || answer == "ok")
                return true;
            else
                return false;

        }



    }
}
