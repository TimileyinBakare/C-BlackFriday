using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessiion6APP
{
    class Students
    {
        [Range(typeof(DateTime),"01/01/1000","01/01/2014",
        ErrorMessage ="Valid dates for the Properties{0} between {1} and {2}")]
        public DateTime EntryDate { get; set; }


        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
         ErrorMessage = "FirstName should be minimum of 3 characters and the maximum of 50 characters")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
         ErrorMessage = "LastName should be minimum of 3 characters and the maximum of 50 characters")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }


        public bool isValid
        {
            get;set;
        }




    }
}
