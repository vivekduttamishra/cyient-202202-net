using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Animals
{
    public sealed class Tiger: Cat // is automatically a Hunter because it is a Cat
    {
        //no need to define any specifics right now.

        public override string Move()
        {
            return this + " moves in jungle";
        }         
    }

    public class BengalTiger : Tiger
    {

    }
}
 