using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDefineDelegate
{
    class Program
    {
        delegate void getLength(string s);
        public static void Main(string[] args)
        {
            getLength len = name =>
            {
                int n = name.Length;
                Console.WriteLine(n.ToString());
            };
            len("Timi");
        }

        public void queryExpression()
        {
            string[] names = {"Timi", "Gbolu","Kenneth"};
            IEnumerable<string> myWord = from T in names where T.EndsWith("i") select T;
            foreach (var s in myWord.OrderBy(name => name))
            {
                Console.WriteLine(s);
            }
        }
    }
}
