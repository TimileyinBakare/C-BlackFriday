using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public partial class StudentDetails
    {
        int _rollNo;
        string _studName;
        public StudentDetails(int number, string name)
        {
            _rollNo = number;
            _studName = name;
        }

        public void getServerConfiguration()
        {
            Console.WriteLine("this guy nah from Nigeria sha");
        }
    }
 
}
