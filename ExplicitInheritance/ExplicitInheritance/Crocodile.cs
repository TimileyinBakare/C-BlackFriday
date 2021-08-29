using System;

namespace ExplicitInheritance
{
    class Crocodile : ITerrestialAnimal
    {
        static void Main(string[] args)
        {
            
        }

        public void eat()
        {
            Console.WriteLine("Them dey chop oooo");
        }

        public void swim()
        {
            Console.WriteLine("swim zef ");
        }

        public void walk()
        {
            Console.WriteLine("see waka");
        }
    }
}
