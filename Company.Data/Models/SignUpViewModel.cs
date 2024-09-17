using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Models
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage ="First Name is Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Mail  is Required")]
        [EmailAddress(ErrorMessage ="InValid Format for Email")]
        public string Email { get; set; }
        public string Password { get; set; }
        [Required(ErrorMessage ="Confirm Password Required")]
        [Compare(nameof(Password),ErrorMessage ="Confirm Password Doenot Match")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage ="Required to agree")]
        public bool IsAgree { get; set; }
    }
}
