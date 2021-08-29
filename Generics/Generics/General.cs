using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class General<T>
    {
        List<T> obj;
        T[] values;
        int _counter = 0;
        public General(int max)
        {
            values = new T[max];
        }


        public Object Add(T val)
        {
            obj = new List<T>();
            obj.Add(val);
            if (_counter < values.Length)
            {
                values[_counter] = val;
                _counter++;

            }

            return obj;
        }

        public void Display()
        {
            Console.WriteLine("Constructed Class is of type: " + typeof(T));
            Console.WriteLine("Values stored in the object of constructed class are : "); 
           for (int i = 0; i<values.Length; i++) 
           { 
            Console.WriteLine(values[i]); 
           }
        }

        public void insertToDatabse()
        {

        }

    }
}
