using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Struct
{
    public struct SNumber
    {
        public int Value { get; set; }

        public SNumber(int value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return $"SNumber({Value.ToString()})";
        }
    }
}
