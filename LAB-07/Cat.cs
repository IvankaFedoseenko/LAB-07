using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_07
{
    internal class Cat: Mammal, IWalkable
    {
        public Cat() { }

        public void Move()
        {
            Console.WriteLine("Walk like a cat");
        }
        public void Sound()
        {
            Console.WriteLine("Meow");
        }
        public void ThrowOfTheTable()
        {
            Console.WriteLine("Cat's paw drops a glass");
        }
        public override void ProduceMilk()
        {
            base.ProduceMilk();
        }
        //Zadanie 3
        public void Walk()
        {
            Console.WriteLine("I like walking on furniture and tables.");
        }
        public override string ToString()
        {
            return "I'm a Cat, I do Meow";
        }
    }
}
