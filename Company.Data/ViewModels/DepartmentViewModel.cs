using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.ViewModels
{
	public class DepartmentViewModel
	{
        public int ID { get; set; }
        public string Name { get; set; }
		public string Code { get; set; }
        public DateTime CreateAt { get; set; }
    
    }

}
