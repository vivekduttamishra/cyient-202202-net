using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11_Collection
{
    class CountryInfo
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }

        public override string ToString()
        {
            return $"{Name}\t{Capital}\t{Currency}";
        }
    }
}
