using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurotialC_.QuackBehaviour
{
    public class QuackSound : IQuackBehavior
    {
        public QuackSound() { }
        public void Quack()
        {
            Console.WriteLine("Quack");
        }

    }
}
