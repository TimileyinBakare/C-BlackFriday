using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Dog : mammals,IAnimalInterface 
    {
        public void animalSound()
        {
            Console.WriteLine("Dog dey nah werey");
        }
        public string breed(string type)
        {
            return type;
        }

        public override void eat()
        {
            base.show();
        }
 
    }
}
