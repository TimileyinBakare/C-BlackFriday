using System;

namespace Indexes
{
    class Account
    {
        string[,] accountDetails = new string[4, 2];
        public string this[int pos, int column]
        {
            get { return (accountDetails[pos, column]); }
            set { accountDetails[pos, column] = value; }
        }

        static void Main(string[] args)
        {
            Account objAccount = new Account();
            string[] id = new string[3] { "1001", "1002", "1003" };
            string[] name = new string[3] { "John", "Peter", "Patrick" };
            int counter = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    objAccount[i, j] = id[counter];
                    objAccount[i, j + 1] = name[counter++];
                }
            }
            Console.WriteLine("ID Name");
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(objAccount[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }

}
 
