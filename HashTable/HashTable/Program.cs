using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace myHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable objTable = new Hashtable();
            objTable.Add(001, "Timi");
            objTable.Add(002, "Tami");
            objTable.Add(003, "Temi");
            objTable.Add(004, "Tomi");
            Console.WriteLine("Number of elements in the hash table: " + objTable.Count);

            //ICollection objCollection = objTable.Keys;
            //Console.WriteLine("Original values stored in hashtable are:");

            foreach (int i in objTable)
            {
                Console.WriteLine(i + " : " + objTable[i]);
            }





        }
    }
}
