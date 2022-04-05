using System;
using System.Runtime.Serialization;

namespace Demo14_LuckPrediction
{
    [Serializable]
    internal class NoLuckException : Exception
    {
        public NoLuckException(): base("You are out of  Luck")
        {
        }

        public NoLuckException(string message) : base(message)
        {
        }

    }
}