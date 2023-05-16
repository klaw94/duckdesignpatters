using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurotialC_.FlyBehaviors;
using TurotialC_.QuackBehaviour;

namespace TurotialC_
{
    public class MallardDuck : Duck
    {
       
        public MallardDuck()
        {
            quackBehavior = new QuackSound();
            flyBehavior = new FlyWithWings();
        }



        public override void Display()
        {
            Console.WriteLine("I am a real Mallard Duck");
        }
    }
}
