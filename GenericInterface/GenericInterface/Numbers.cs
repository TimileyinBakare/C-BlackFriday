using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    class Numbers : IMath<int>
    {
        public int Addition(int valOne, int valTwo)
        {
            return valOne + valTwo;

        }

        public int Subtraction(int valOne, int valTwo)
        {
            if (valOne > valTwo)
            {
                return (valOne - valTwo);
            }
            else
            {
                return (valTwo - valOne);
            }

        }
    }
}
