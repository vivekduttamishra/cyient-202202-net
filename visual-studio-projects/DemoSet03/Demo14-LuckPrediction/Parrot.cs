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

            if (luckyNumber == 0)
                throw new NoLuckException();
            else
                return deck.PickCard(luckyNumber);
            
        }
    }
}
