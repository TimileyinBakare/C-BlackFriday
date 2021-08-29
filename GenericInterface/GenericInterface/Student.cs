using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    class Student : IDetails
    {
        string _studName;
        int _studID;
        public Student(string name, int num)
        {
            _studName = name;
            _studID = num;
        }
        public void GetDetails()
        {
            Console.WriteLine(_studID + "\t" + _studName);
        }

    }
}
