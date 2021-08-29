using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class UnitedKingdom : Who
    {
        public UnitedKingdom(int casuality, int recoveries)
        {
            base.casualities = casuality;
            base.recoveries = recoveries;
        }

        public override void agencies()
        {
            Console.WriteLine("Health care in the United Kingdom is a devolved matter, with England, Northern Ireland, " +
                "Scotland and Wales each having their own systems of publicly funded healthcare, " +
                "funded by and accountable to separate governments and parliaments," +
                " together with smaller private sector and voluntary provision. " +
                "As a result of each country having different policies and priorities, " +
                "a variety of differences now exist between these systems.");
        }

        public override void casualityCase()
        {
            Console.WriteLine("The Number of Casualities in United kingdom is close to over " + base.casualities);

        }

        public override void RecoveryState()
        {
            Console.WriteLine("So far more than " + base.recoveries + " has recovered from these Disease");

        }
    }
}
