using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyMain
    {
        static void Main(string[] args)
        {
            General<string> objGeneral = new General<string>(3);
            objGeneral.Add("John");
            objGeneral.Add("Patrick");
            objGeneral.Display();

            General<int> objGeneral2 = new General<int>(2);
            objGeneral2.Add(200);
            objGeneral2.Add(35);
            objGeneral2.Display();

        }
    }
}
