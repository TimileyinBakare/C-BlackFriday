using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Nigeria : Who
    {
       public Nigeria(int casuality,int recoveries)
        {
            base.casualities = casuality;
            base.recoveries = recoveries;
        }
        public override void agencies()
        {
            Console.WriteLine("The Nigeria Centre for Disease Control is the country’s national public health institute," +
                " with the mandate to lead the preparedness, detection and response to infectious disease outbreaks and public health emergencies. " +
                "The first formal step to establish the NCDC took place in 2011 when some departments in the Ministry of Health, " +
                "including the Epidemiology Division, the Avian Influenza Project and its laboratories; and the Nigeria Field Epidemiology and Laboratory Training Programme (NFELTP) were moved to form the nucleus of the agency." +
                " The Bill for an Act to establish NCDC was signed into law in November 2018, by President Muhammadu Buhari.");
        }

        public override void casualityCase()
        {
            Console.WriteLine("The Number of Casualities in Nigeria is close to over " + base.casualities);
        }

        public override void RecoveryState()
        {
            Console.WriteLine("So far more than " + base.recoveries + " has recovered from these Disease");
        }
    }
}
