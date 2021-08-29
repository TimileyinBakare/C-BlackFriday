using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessiion6APP
{
    class objInitializer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }

        public void myMain()
        {
            objInitializer initializer = new objInitializer()
            {
                Name = "John Doe",
                Age = 24,
                Designation = "Sales Person"

            };
            Console.WriteLine("Name: {0}, Age: {1}, Designation: {2}", initializer.Name, initializer.Age, initializer.Designation);

        }
    }
}
