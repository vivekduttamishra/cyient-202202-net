using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Shapes
{
    public class ShapeException : Exception
    {
        public ShapeException(string message): base(message)
        {

        }
    }
}
