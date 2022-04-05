using Demo16_LuckPrediction;
using System;
using System.Runtime.Serialization;

namespace Demo14_LuckPrediction
{
    [Serializable]
    internal class NoLuckException : UnLuckyException
    {
        public NoLuckException(string message="You are out of Luck") : base(0,message)
        {
        }

    }
}