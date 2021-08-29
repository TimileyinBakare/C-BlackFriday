using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Model1Container dbContext = new Model1Container())
            {
                Console.Write("Enter Customer name: ");
                var name = Console.ReadLine();
                Console.Write("Enter Customer Address: ");
                var address = Console.ReadLine();
                Console.Write("Enter Order Cost:");
                var cost = Console.ReadLine();
                var customer = new Customer { Name = name, Address = address };
                var order = new Order { Cost = cost };
                customer.Orders.Add(order);
                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();
                Console.WriteLine("Customer and Order Information added successfully.");
            }

        }
    }
}
