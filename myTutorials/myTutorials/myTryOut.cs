using System;
using System.Collections.Generic;
using System.Text;

namespace myTutorials
{
    class myTryOut
    {
        static void tryOut()
        {
            byte numOne = 255;
            byte numTwo = 1;
            byte result = 0;
            try
            {
                //This code throws an overflow         // exception 
                //checked  
                {
                    result = (byte)(numOne + numTwo);
                }
                Console.WriteLine("Result: " +
                result);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
