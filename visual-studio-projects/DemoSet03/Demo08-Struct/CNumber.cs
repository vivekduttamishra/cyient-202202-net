using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Struct
{
    public class CNumber
    {
        public int Value { get; set; }

        public CNumber(int value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return $"CNumber({Value.ToString()})";
        }
    }
}
