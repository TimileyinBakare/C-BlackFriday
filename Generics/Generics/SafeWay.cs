using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class SafeWay
    {
        public void addNewPatient()
        {
            General<string> objPatient1 = new General<string>(3);
            objPatient1.Add("John");
            objPatient1.Add("Patrick");
            objPatient1.Display();

            General<double> objPatient2 = new General<double>(2);
            objPatient2.Add(200);
            objPatient2.Add(35);
            objPatient2.Display();

        }

        public void insertToDatabse()
        {

        }
    }
}
