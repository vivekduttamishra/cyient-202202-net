using Demo07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals =
            {
                //we can store all animals here                
                new Tiger(),
                new Horse(),
               // new Animal(),
                new Cat(),
                new Snake(),
                new Eagle(),
                new Dog(),
                new Camel(),
                new Cow(),
                new Parrot(),
               // new Bird(),
              //  new Reptile(),
                new Leopard()
            };


            foreach(var animal in animals)
            {
                Console.WriteLine(animal);
                Console.WriteLine("\t" + animal.Eat());
                Console.WriteLine("\t" + animal.Move());
                Console.WriteLine("\t" + animal.Breed());

                //animal.Hunt();

                //HuntIfYouAreATiger(animal);

                HuntIfYouAreAHunter(animal);

                Console.WriteLine("\t" + animal.Die());
                Console.WriteLine();
            }
        }

        private static void HuntIfYouAreAHunter(Animal animal)
        {
            var hunter = animal as Hunter; //converts type or returns null
            if(hunter!=null)
                Console.WriteLine("\t{0}", hunter.Hunt());
        }

        private static void HuntIfYouAreATiger(Animal animal)
        {
            //Tiger tiger = animal; 
            if (animal is Tiger)
            {
                Tiger tiger = (Tiger)animal;
                Console.WriteLine("\t" + tiger.Hunt());
            }
        }
    }
}
