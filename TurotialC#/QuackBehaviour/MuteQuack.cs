using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurotialC_.QuackBehaviour
{
    public class MuteQuack : IQuackBehavior
    {
        public MuteQuack()
        {
        }

        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}
