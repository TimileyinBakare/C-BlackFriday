using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Nigeria myCountry = new Nigeria(700,200);
            myCountry.casualityCase();
            myCountry.RecoveryState();

            Console.WriteLine("");

            Ghana banku = new Ghana(400,120);
            banku.casualityCase();
            banku.RecoveryState();

            Console.WriteLine("");

            UnitedKingdom kingdom = new UnitedKingdom(1500,900);
            kingdom.casualityCase();
            kingdom.RecoveryState();

        }
    }
}
