using System;
using System.Collections.Generic;
using System.Text;

namespace Session7
{
     class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor without parameters");
        }
        public Animal(String name)
        {
            Console.WriteLine("Animal constructor with a string parameter");
        }

        public void iSeeISaw()
        {
            Canine objCanine = new Canine();
            
        }

        class Canine : Animal
        {
            //base()takes a string value called "Lion"
            public Canine() : base("Lion")
            {
                Console.WriteLine("DerivedCanine");
            }
        }


    }
}
