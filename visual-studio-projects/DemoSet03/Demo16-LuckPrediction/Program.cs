using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo14_LuckPrediction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var astrologer = new Astrologer();
            while(true)
            {
                try
                {
                    var luckyNumber = Input.ReadString("Enter your Luck Number:");
                    astrologer.TellMeLuck(luckyNumber);
                }
                catch(Exception ex) //any exception
                {
                    Console.WriteLine("Something went wrong:"+ex.Message);
                }
                
            }
        }
    }
}
