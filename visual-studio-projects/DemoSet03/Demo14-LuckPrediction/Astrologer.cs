using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo14_LuckPrediction
{
    class Astrologer
    {
        Parrot parrot = new Parrot();
        LuckDeck deck = new LuckDeck();
        
        public void TellMeLuck(int luckyNumber)
        {
            try
            {
                string luck = parrot.GetLuckCard(deck, luckyNumber);
                Console.WriteLine("Your Luck: " + luck);
            } 
            catch(NoLuckException ex)
            {
                Console.WriteLine("Your Luck is Foggy To Me.");
            }
            catch(IndexOutOfRangeException ex)
            {
                if(luckyNumber<0)
                    Console.WriteLine("There is too much of negativity around you!");
                else
                    Console.WriteLine("You are over ambitious");
            }
            
        }
    }
}
