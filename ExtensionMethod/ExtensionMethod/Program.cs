using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class Program
    {
        static void Main(string[] args)
        {
            int number = 50;
            Console.WriteLine(number.Addition(10));
            List<string> cities = new List<string>();
            cities.Add("Seoul");
            cities.Add("Beijing");
            cities.Add("Berlin");
            cities.Add("Istanbul");
            cities.Add("Seoul");
            cities.Add("Istanbul");
            cities.Add("Paris");
            // Invoke the Extension method, RemoveDuplicate(). 
            List<string> result = cities.RemoveDuplicate();
            foreach (string city in result)
                Console.WriteLine(city);


        }

        public static int Addition(this int val , int val2)
        {
            return val * val2;
        }

        public static List<T> RemoveDuplicate<T>(this List<T> citys)
        {
            return val * val2;
        }
    }
}
