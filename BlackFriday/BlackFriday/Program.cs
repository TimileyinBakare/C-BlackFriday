using System;

namespace BlackFriday
{
    class Program
    {
        string[] food = { "RiceBag", "CornBeef", "GarriBag", "Milk" };
        float[] price = { 30000, 20000, 15000, 10000 };
        int i;
        int j;
        DateTime FridayValue;
        DayOfWeek friday = DayOfWeek.Friday;
        DateTime[] fridaysArrays = new DateTime[]
            {
            new DateTime(2020,12,4),
            new DateTime(2020,12,11),
            new DateTime(2020,12,18),
            new DateTime(2020,12,25)

            };

          


        static void mesain(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWELCOME TO BLACK BOY SHOP YOU BLOOD BROKE ASSES");
            Program objProgram = new Program();
            objProgram.foodPrices();
            objProgram.validations();

        }


        public bool validations()
        {
            return true;
        }

        public void foodPrices()
        {
            for (i = 0; i < food.Length; i++)
            {
                Console.WriteLine("Products Available for this friday " + food[i] + " " + " and their prices " + "N" + price[i]);
            }

        }

    }
}
 