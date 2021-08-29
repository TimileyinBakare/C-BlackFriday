using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    class MultipleAnonymousMethods
    {
        delegate void Display();
        public delegate void Display2(string msg, int num);
        static void Main(string[] args)
        {
            Display objDisp = delegate ()
            {
                Console.WriteLine("This illustrates one anonymous method");
            };
            objDisp();
            Display2 display2 =  delegate (string msg,int num)
            {
                Console.WriteLine("this is the same illustration with the same method");
            };
            display2("Omo men",30);


            
        }
    }
}
