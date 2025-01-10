using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_07
{
    internal class Dog: Mammal, ISwim
    {
        public override void ProduceMilk()
        {
            base.ProduceMilk();
        }
        public void Swim()
        {
            Console.WriteLine("I swim poorly");
        }
        public override string ToString()
        {
            return "I'm a Dog, I do Woof";
        }
    }
}
