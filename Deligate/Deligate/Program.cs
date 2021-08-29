using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligate
{
    class Program
    {
        public delegate void Calculate(int numOne, int numTwo);


        static void Addition(int numOne, int numTwo)
        {
            Console.WriteLine(numOne + numTwo);
        }

        static void Subtraction(int numOne, int numTwo)
        {
            Console.WriteLine(numOne - numTwo);
        }
        static void multiplication(int numOne, int numTwo)
        {
            Console.WriteLine(numOne * numTwo);
        }

        static void Main(string[] args)
        {

            Calculate objcalculate = null;
            Console.WriteLine("Enter your nonsense symbol abeg");
            String userInput;
            userInput = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                if (userInput.Equals("+"))
                {
                    objcalculate = new Calculate(Addition);
                }
                else if (userInput.Equals("-"))
                {
                    objcalculate += new Calculate(Subtraction);
                }
                else if (userInput.Equals("*"))
                {
                    objcalculate += new Calculate(multiplication);
                }
                else
                {
                    Console.WriteLine("Enter better symbol jare");
                }
                objcalculate(10, 5);
                Console.ReadLine();
            }
        }
    }
}
