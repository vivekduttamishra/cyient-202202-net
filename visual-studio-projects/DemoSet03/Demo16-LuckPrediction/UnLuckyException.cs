using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo16_LuckPrediction
{
    public class UnLuckyException:Exception
    {
        public int LuckyNumber { get; private set; }

        public UnLuckyException(int luckyNumber, string message="You are Unlucky"):base(message)
        {
            LuckyNumber = luckyNumber;
        }
    }
}
