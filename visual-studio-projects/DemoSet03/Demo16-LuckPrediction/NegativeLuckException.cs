using Demo16_LuckPrediction;
using System;
using System.Runtime.Serialization;

namespace Demo14_LuckPrediction
{
    [Serializable]
    internal class NegativeLuckException : UnLuckyException
    {
      


        public NegativeLuckException(int luckyNumber):base(luckyNumber,$"You have a Negative Luck:{luckyNumber}")
        {
           
        }

        public NegativeLuckException(int luckyNumber,string message) : base(luckyNumber,message)
        {
            
        }

       
    }
}