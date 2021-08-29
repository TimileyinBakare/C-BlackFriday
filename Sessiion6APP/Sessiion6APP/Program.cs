using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sessiion6APP
{
    class Program
    {
        static void Main(string[] args)
        {

            objInitializer innit = new objInitializer();
            innit.myMain();

            Students author = new Students();
            author.FirstName = "";
            author.LastName = "";
            author.PhoneNumber = "";
            author.Email = "";

            ValidationContext context = new ValidationContext(author, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(author, context, validationResults, true);
            if(!valid)
            {
                foreach(ValidationResult validationResult in validationResults)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine("{0}", validationResult.ErrorMessage);

                }
                foreach(ValidationResult validationResult in validationResults)
                {
                    Console.WriteLine("{0}", validationResult.ErrorMessage);
                }
            }
            Console.ReadKey();
        }
    }
}
