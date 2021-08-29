using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Ghana : Who
    {
        public Ghana(int casuality, int recoveries)
        {
            base.casualities = casuality;
            base.recoveries = recoveries;
        }
        public override void agencies()
        {
            Console.WriteLine("The Ghana Health Service (GHS) is an autonomous Executive Agency responsible" +
                " for implementation of national policies under the control of the Minister for Health through its governing Council - " +
                "the Ghana Health Service Council.");
        }

        public override void casualityCase()
        {
            Console.WriteLine("The Number of Casualities in Ghana is close to over " + base.casualities);
        }

        public override void RecoveryState()
        {
            Console.WriteLine("So far more than " + base.recoveries + " has recovered from these Disease");
        }
    }
}
