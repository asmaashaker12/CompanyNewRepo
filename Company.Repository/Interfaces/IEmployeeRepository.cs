using Company.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repository.Interfaces
{
    public interface IEmployeeRepository:IBaseRepository<Employee>
    {
      public IEnumerable<Employee> GetEmployeeByName(string searchtxt);

    }
}
