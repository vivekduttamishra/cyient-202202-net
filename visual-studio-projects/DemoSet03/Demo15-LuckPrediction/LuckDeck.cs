using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo14_LuckPrediction
{
    class LuckDeck
    {
        public string PickCard(int index)
        {
            if (index <= 100)
                index = index % 5 + 1; //you always get a value between 0-5
                
            string[] cards = {
                "",
                "You have a great day ahead!",
                "Success awaits you",
                "Be careful. Stressful day today",
                "Help others. That will return to you.",
                "Success and failures are ways of life. Don't be disappointed."
            };
            if (index < 0)
                throw new NegativeLuckException(index);

            return cards[index];  //may throw IndexOutOfRangeException
        }
    }
}
