using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 23;
            int numTwo = 45;
            Numbers objInterface = new Numbers();
            Console.Write("Addition of two integer values is: ");
            Console.WriteLine(objInterface.Addition(numOne, numTwo));
            Console.Write("Subtraction of two integer values is: ");
            Console.WriteLine(objInterface.Subtraction(numOne, numTwo));
        }
    }
}
