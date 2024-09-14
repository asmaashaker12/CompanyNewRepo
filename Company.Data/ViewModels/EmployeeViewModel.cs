using Company.Data.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.ViewModels
{
	public class EmployeeViewModel
	{
        public int ID { get; set; }
        public string Name { get; set; }
		public string Address { get; set; }
		public int Age { get; set; }
		public decimal Salary { get; set; }
		public string? PhonNumber { get; set; }
		public DateTime? HiringDate { get; set; }
		public string? ImageUrl { get; set; }
        public IFormFile Image { get; set; }
        public string ImageName { get; set; }
        public DepartmentViewModel? Department { get; set; }
		public int? DepartmentId { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
