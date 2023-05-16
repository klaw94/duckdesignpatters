using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurotialC_.FlyBehaviors;

namespace TurotialC_
{
    public class FlyNoWay : IFlyBehavior
    {
        public FlyNoWay()
        {
        }

        public void Fly()
        {
            Console.WriteLine("I can't fly :(");
        }
    }
}