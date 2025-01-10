namespace LAB_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            Cat cat = new Cat();
            cat.ThrowOfTheTable();
            cat.Move();
            cat.Sound();

            //Zadanie 2
            Dog dog = new Dog();
            dog.ProduceMilk();
            cat.ProduceMilk();
            
            //Zadanie 3
            cat.Walk();

            //Zadanie 4
            Salmon salmon = new Salmon();
            salmon.Swim();
            dog.Swim();

            //Zadanie 5
            Animal[] animals = new Animal[]
            {
                new Cat(),
                new Dog(),
                new Salmon()
            };
            foreach (var animal in animals)
            {
                if (animal is Mammal mammal)
                {
                    mammal.ProduceMilk();
                }
                if (animal is ISwim swimable)
                {
                    swimable.Swim();
                }
            }

            //Zadanie 6
            Console.WriteLine(cat.ToString());
            Console.WriteLine(dog.ToString());
            Console.WriteLine(salmon.ToString());
        }
    }
}
