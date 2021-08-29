using System;

namespace mrPolitesCrazies
{
    class Program
    {
        string phoneNumber;
        string subPhone;
        string replace;
        string m_Number;
        int subPhoneConvert;
        int add = 0;
        int userCode;

        public void validateNumber()
        {
            Console.WriteLine("Specify Your Number? ");
            phoneNumber = Console.ReadLine();
            subPhone = phoneNumber.Substring(3, 4);
            replace = phoneNumber.Replace(subPhone, "****");
            Console.WriteLine(replace);

        }

        public void sendVerificationCode()
        {
            m_Number = Console.ReadLine();

            if (subPhone == m_Number)
            {
                Console.WriteLine("Welcome back Werey,Your number as been verified" + " " + phoneNumber);
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }


        }

        public void validateEmail()
        {


            Console.WriteLine("Enter Email");
            string email;
            email = Console.ReadLine();

            if (email.Contains("@") && (email.Contains(".")))
            {
                Console.WriteLine("The Email is valid");
            }
            else
            {
                Console.WriteLine("Werey,the Email is not valid");
            }
        }

        public void addTheAsterics()
        {
            subPhoneConvert = Convert.ToInt32(subPhone = phoneNumber.Substring(3, 4));
            Console.WriteLine(subPhoneConvert);
            for (int i = 0; i < subPhone.Length; i++)
            {
                add += Convert.ToInt32(subPhone.Substring(i, 1));
            }
            Console.WriteLine(add);

            if (add >= 1 && add <= 10)
            {
                add += 1;
                Console.WriteLine("The number nah between One and ten ,so Guy i don add 1 =" + " " + add);
            }
            else if (add > 10 && add <= 20)
            {
                add += 2;
                Console.WriteLine("The number nah between ten and twenty ,so Guy i don add 2 =" + " " + add);
            }
            else if (add > 20 && add <= 30)
            {
                add += 3;
                Console.WriteLine("The number nah between twenty and thirty ,so Guy i don add 3 =" + " " + add);
            }
            else
            {
                add += 4;
                Console.WriteLine("The number nah between thirty and forty ,so Guy i don add 4 =" + " " + add);
            }
        }

        public static void ternaryoperator()
        {
            int a = 100;
            int b = 30;
            int val = 50;
            int totalval;
            if (a > b)
            {
                totalval = val >= 50 ? val = 200 : 300;
                Console.WriteLine(totalval);
            }
            else
            {
                val = 10;
                Console.WriteLine(val);
            }
        }
        // Enum Usage Reason Am
        enum myDays
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Sarturday, Sunday
        }
        myDays objmydays = myDays.Sarturday;

        public void switchCase()
        {
            switch (objmydays)
            {
                case myDays.Sarturday:
                    Console.WriteLine("omo todaynah Saturdays");
                    break;
                default:
                    Console.WriteLine("");
                    break;

            }
        }

        public void whileLoops()
        {
            int i = 0;
            int j;
            while (i < 5)
            {
                Console.WriteLine("e dey work");
                j = 0;
                while (j <= i)
                {
                    j++;
                    Console.Write("*" + j);
                }
                i++;
                Console.WriteLine();
                
            }



            // do while
            int num = 1;
            Console.WriteLine("EvenNumbers"); do
            {
                if ((num % 2) == 0)
                {
                    Console.WriteLine(num);
                }
                num = num + 1;
            } while (num <= 11);


        }


        public void forLopsWithoutIncreament()
        {
            int investment;
            int returns;
            int expenses;
            int profit;
            int counter = 0;

            for (investment = 1000, returns = 0; returns < investment;)
            {
                Console.WriteLine("Enter the monthly expenditure");
                expenses = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the monthly profit");
                profit = Convert.ToInt32(Console.ReadLine());

                investment += expenses;
                returns += profit;
                counter++;
            }
            Console.WriteLine("Number of months to break even: "
           + counter);
        }

        public void forLoopsWithoutBody()
        {
            {
                int fact = 1;
                int num, i;
                Console.WriteLine("Enter the number whose factorial you wish to calculate");
                num = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= num; fact *= i++) ;
                Console.WriteLine("Factorial: " + fact);
            }

        }

        public void forEach()
        {
            string[] employeeNames = { "Maria", "Wilson", "Elton", "Garry" };
            int[] courseCode = { 103, 104, 105, 106, 107, 108 };
            Console.WriteLine("Employee Names");
            foreach (string names in employeeNames)
            {
                Console.WriteLine(names);
            }
            foreach (int numbers in courseCode)
            {
                Console.WriteLine(numbers);
            }
        }

        public void breakStatement()
        {
            int numOne = 17;
            int numTwo = 2;
            while (numTwo <= (numOne - 1))
            {
                if (numOne % numTwo == 0)
                {
                    Console.WriteLine("Not a Prime Number");
                    break;
                }
                numTwo++;
            }
            if (numTwo == numOne)
            {
                Console.WriteLine("Prime Number");
            }

        }

        public void pickWetinYouWant()
        {
            Console.WriteLine("Enter the Number you want ?");
            int number;
            number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {

                case 1:


                    break;

                case 2:

                    break;

                case 3:

                    break;
                default:
                    Console.WriteLine("Werey you no wan do anything ni");
                    break;
            }

            


        }

        public static void printName(int enrollmentNumber, String fullName)
        {
            Console.WriteLine("First Name = {0}, Last Name = {1}",
            enrollmentNumber, fullName);
        }

        public void printMessage(String message = "timi")
        {
            Console.WriteLine(message);
        }

        
        public void discountOffer(String name,int usercode,int discount = 5)
        {
            if(userCode ==101)
            {
                Console.WriteLine("you've just gotten " + discount);
            }
            else if(userCode == 102)
            {
                Console.WriteLine("You've just gotten " + discount);
            }
            else if (userCode == 103)
            {
                Console.WriteLine("You've just gotten " + discount);
            }
            else
            {
                Console.WriteLine("Omo your Product code don loss ooo");
            }
        }

        static void testingError()
        {
            int numOne = 133;
            int numTwo = 0;
            int result;
            try
            {
                result = numOne / numTwo;
            }
            catch (DivideByZeroException objDivide)
            {
                Console.WriteLine("Exception caught: " + objDivide);
            }
        }

        static void ThrowException(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Name textfield cannot be empty....put Something jare,Werey");
            }
        }


        static void Main(string[] args)
        {
            Program objProgram = new Program();

            Product objGoods = new Product();
            objGoods.AcceptDetails();
            objGoods.Display();

            // objProgram.pickWetinYouWant();
            //postional
            //   printName(5,"tobilobe");
            //named Arguements
            ////  printName(fullName:"tobeee" ,enrollmentNumber:55);
            // objProgram.printMessage();
            //    Console.WriteLine("Enter your product code? ");
            //  objProgram.userCode = Convert.ToInt32(Console.ReadLine());
            //   objProgram.discountOffer(name: "rice",objProgram.userCode);
            //objProgram.whileLoops();
            //testingError();

        }
    }
}
