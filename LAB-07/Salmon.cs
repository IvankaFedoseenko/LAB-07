using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_07
{
    internal class Salmon : Animal, ISwim
    {
        public void Swim()
        {
            Console.WriteLine("I can swim really fast!");
        }
        public override string ToString()
        {
            return "I'm a Salmon, I do Glub";
        }
    }
}
