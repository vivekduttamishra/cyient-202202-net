using Demo16_LuckPrediction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo15_LuckPrediction
{
    class OverAmbitiousException: UnLuckyException
    {
        
        public OverAmbitiousException(int luckyNumber, string message="You are over ambitious")
            :base(luckyNumber,message)
        {
            
        }
    }
}
