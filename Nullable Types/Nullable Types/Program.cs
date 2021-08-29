using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Types
{
    class Program
    {
        static void numberssign()
        {
            double? numbOne = 50;
            numbOne = null;
            double marketValue = 20;
            double? numbOne2 = numbOne + marketValue;
            Console.WriteLine(numbOne2);
           
        }
        static void Main(string[] args)
        {
            numberssign();
        }
    }
}
