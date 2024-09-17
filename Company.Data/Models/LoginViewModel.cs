using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Models
{
	public class LoginViewModel
	{
		[Required(ErrorMessage = "Mail  is Required")]
		[EmailAddress(ErrorMessage = "InValid Format for Email")]
		public string Email { get; set; }
		public string Password { get; set; }
		public bool RemeberMe { get; set; }
	}
}
