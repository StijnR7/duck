using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal abstract class Duck


    {

        protected QuackBehavior quackBehavior;

        protected FlyBehavior flyBehavior;

        protected SwimBehavior swimBehavior;

        public abstract void Display();
        public void PerformFloat() {
            swimBehavior.Float();
        
        }
        public void PerformSink() {
            swimBehavior.Sink();
        }   

        public void PerformQuack()

        {

            quackBehavior.Quack();

        }

        public void PerformFly()

        {

            flyBehavior.Fly();

        }

        public void Swim()

        {

            Console.WriteLine("All ducks float, even decoys!");

        }

    }
}
