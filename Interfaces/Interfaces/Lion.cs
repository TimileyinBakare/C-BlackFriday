using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Lion : IAnimalInterface
    {
        public void animalSound()
        {
            Console.WriteLine("Lion dey Roar nah olodo");
        }
        public String breed(string type)
        {
            return type;
        }
    }
}
