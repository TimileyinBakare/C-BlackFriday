using System;

namespace refAndOutExample
{
    class Program
    {
        static void Calculate(out int numValueOne, out int numValueTwo)
        {
            
            numValueOne = 2;
            numValueTwo = 4;  

        }

        static void Main(string[] args)
        {
            int numOne = 10;
            int numTwo = 20;
            Console.WriteLine("Value of Num1 and Num2 before calling method "
                + numOne
                + ", "
                +numTwo);
            Calculate(out numOne, out numTwo);
            Console.WriteLine("Value of Num1 and Num2 after calling method " 
                + numOne 
                + ", " 
                +numTwo);

        }
    }
}
