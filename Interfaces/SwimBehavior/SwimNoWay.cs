using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.SwimBehavior
{
    internal class SwimNoWay : SwimBehavior
    {
        public void Float()
        {
            Console.WriteLine("I float!");
        }
        public void Sink() {
            Console.WriteLine("I sink!");
        }

    }
}
