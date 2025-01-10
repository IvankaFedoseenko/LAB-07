using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_07
{
    internal class Mammal : Animal
    {
        public virtual void ProduceMilk()
        {
            Console.WriteLine("milk is produced");
        }
    }
}
