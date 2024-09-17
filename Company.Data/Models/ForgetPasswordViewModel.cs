using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Models
{
    public class ForgetPasswordViewModel
    {
        [Required(ErrorMessage = "Mail  is Required")]
        [EmailAddress(ErrorMessage = "InValid Format for Email")]
        public string Email { get; set; }
    }
}
