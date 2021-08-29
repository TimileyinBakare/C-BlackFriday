using System;
using System.Collections.Generic;
using System.Text;

namespace mrPolitesCrazies
{
    class Product
    {

        private int _quantity;
        private int _price;
        private double _sales;
        string _productName;
        public Product()
        {
            _productName = "Motherboard";
        }
        public void AcceptDetails()
        {
            Console.WriteLine("Enter the number of " + _productName +
            " sold");
            try
            {
                _quantity = Int32.Parse(Console.ReadLine());

            }
            catch (FormatException objFormat)
            {
                Console.WriteLine("Error: " + objFormat);
                return;
            }
            Console.WriteLine("Enter the price of the product");
            if (float.TryParse((Console.ReadLine()), out _price) ==
            true)
            {
                _sales = _price * _quantity;
            }
            else
            {
                Console.WriteLine("Invalid price inserted");
            }
        }
        public void Display()
        {
            Console.WriteLine("Product Name: " + _productName);
            Console.WriteLine("Product Price: " + _price);
            Console.WriteLine("Quantity sold: " + _quantity);
            Console.WriteLine("Total Sale Value: " + _sales);
        }


    }
}
