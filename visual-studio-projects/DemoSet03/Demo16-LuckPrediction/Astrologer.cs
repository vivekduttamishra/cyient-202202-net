
using Demo15_LuckPrediction;
using Demo16_LuckPrediction;
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
        
        public void TellMeLuck(string luckyValue)
        {
            try
            {
                int luckyNumber = int.Parse(luckyValue);
                string luck = parrot.GetLuckCard(deck, luckyNumber);
                Console.WriteLine("Your Luck: " + luck);
            } 
            
            catch( UnLuckyException ex)
            {
                Console.WriteLine($"{ex.Message} : {ex.LuckyNumber}");
            }
            
            finally
            {
                Console.WriteLine("Thats all I can say");
            }

            Console.WriteLine("end of prediction");


            
        }
    }
}
