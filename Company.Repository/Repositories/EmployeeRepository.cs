using Company.Data.Context;
using Company.Data.Models;
using Company.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repository.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        private readonly CompanyDbContext _context;

        public EmployeeRepository(CompanyDbContext context):base(context)
        {
           _context = context;
        }

        public IEnumerable<Employee> GetEmployeeByName(string searchtxt)
            => _context.Employees.Where(x => x.Name.Trim().ToLower().Contains(searchtxt.Trim().ToLower()));
        
    }
}
