using System;

namespace Session9
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryDetails objSal = new SalaryDetails();
            objSal.EmployeeName = "Timileyin";
            Console.WriteLine("Employee " + objSal.EmployeeName);

        }
    }
}
