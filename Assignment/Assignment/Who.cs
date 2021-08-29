using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    abstract class Who
    {
        public int casualities = 0;
        public int recoveries = 0;

        public void healthRepost()
        {
            Console.WriteLine("Maintain at least a 1-metre distance between yourself" +
                " and others to reduce your risk of infection when they cough, " +
                "sneeze or speak. Maintain an even greater distance between yourself and others when indoors." +
                " The further away, the better, " +
                "Make wearing a mask a normal part of being around other people." +
                "The appropriate use, storage and cleaning or disposal are essential to make masks as effective as possible.");
        }

        public abstract void agencies();
        public abstract void casualityCase();
        public abstract void RecoveryState();

    }
}
