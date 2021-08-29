using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    interface IMath<T>
    {
        T Addition(T valOne, T valTwo);
        T Subtraction(T valOne, T valTwo);
    }
}
