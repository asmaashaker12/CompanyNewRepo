using Company.Data.Models;
using Company.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Service.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeViewModel> GetEmployeeByName(string searchtxt);
        EmployeeViewModel GetById(int? id);
        IEnumerable<EmployeeViewModel> GetAll();
        void Add(EmployeeViewModel employee);
        void Update(EmployeeViewModel  employee);
        void Delete(EmployeeViewModel employee);
    }
}
