using System;
using System.Runtime.Serialization;

namespace Demo14_LuckPrediction
{
    [Serializable]
    internal class NegativeLuckException : Exception
    {
        public int LuckyNumber { get; private set; }


        public NegativeLuckException(int index):base($"You have a Negative Luck:{index}")
        {
            this.LuckyNumber = index;
        }

        public NegativeLuckException(int index,string message) : base(message)
        {
            this.LuckyNumber = index;
        }

       
    }
}