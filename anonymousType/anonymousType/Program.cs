using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School;
namespace anonymousType
{
    class Program
    {

       
        static void Main(string[] args)
        {
            StudentDetails myStudents = new StudentDetails(1, "TImileyin");
            myStudents.getServerConfiguration();
            var stock = new
            {
                Name = "Michgan Enterprises",
                Code = 1301,
                Price = 35056.75
            };
            Console.WriteLine("Stock Name: " + stock.Name);
            Console.WriteLine("Stock Code: " + stock.Code);
            Console.WriteLine("Stock Price: " + stock.Price);

            Employee Timi = new Employee();
            Timi.DisplayDetails(new {
                FirstName = "tim",
                LastName = "BAKARE",
                Age = 40
            } );
        }

       
        
    }
}
