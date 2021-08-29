using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Tiger : IAnimalInterface
    {
        public void animalSound()
        {
            Console.WriteLine("tiger dey grrrrr ode");
        }
        public string breed(string type)
        {
            return type;
        }
    }
}
