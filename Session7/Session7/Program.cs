using System;

namespace Session7
{
    class Program
    {
        int _empId = 1;
        string _empName = "JamesAnderson";
        int _age = 25;
        public void Display()
        {
            Console.WriteLine("EmployeeID:" + _empId);
            Console.WriteLine("EmployeeName:" + _empName);
        }

        class Department : Program
        {
            int _deptId = 501;
            string _deptName = "Sales";

            new void Display()
            {
                base.Display();
                Console.WriteLine("DepartmentID:" + _deptId);
                Console.WriteLine("DepartmentName:" + _deptName);
            }

            static void Main(string[] args)
            {
                Department objDepartment = new Department();
                objDepartment.Display();

                Animal objAnim = new Animal();
                
            }
        }
    }
}
