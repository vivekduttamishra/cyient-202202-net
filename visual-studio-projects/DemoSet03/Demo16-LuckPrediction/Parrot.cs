using Demo15_LuckPrediction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo14_LuckPrediction
{
    class Parrot
    {
                
        public string GetLuckCard(LuckDeck deck, int luckyNumber )
        {
            try
            {
                if (luckyNumber == 0)
                    throw new NoLuckException();
                else
                    return deck.PickCard(luckyNumber);
            }
            catch(IndexOutOfRangeException ex)
            {
                throw new OverAmbitiousException(luckyNumber,"You are too ambitious for your own good");
            }
            
           

            
            
        }
    }
}
