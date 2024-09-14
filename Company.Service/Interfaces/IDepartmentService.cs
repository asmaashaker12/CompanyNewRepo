using Company.Data.Models;
using Company.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Service.Interfaces
{
    public interface IDepartmentService
    {
		DepartmentViewModel GetById(int? id);
        IEnumerable<DepartmentViewModel> GetAll();
        void Add(DepartmentViewModel department);
        //void Update(DepartmentViewModel department);
        void Delete(DepartmentViewModel department);
    }
}
