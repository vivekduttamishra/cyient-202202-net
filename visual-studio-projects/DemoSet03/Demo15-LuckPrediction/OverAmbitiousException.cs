using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo15_LuckPrediction
{
    class OverAmbitiousException: Exception
    {
        public int LuckyNumber { get; private set; }
        public OverAmbitiousException(int luckyNumber, string message="You are over ambitious"):base(message)
        {
            LuckyNumber = luckyNumber;
        }
    }
}
