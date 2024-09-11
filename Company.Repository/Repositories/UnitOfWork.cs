
using Company.Data.Context;
using Company.Repository.Interfaces;

namespace Company.Repository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CompanyDbContext _dbContext;
        public UnitOfWork(CompanyDbContext dbContext)
        {
            _dbContext = dbContext;
            EmployeeRepository = new EmployeeRepository(dbContext);
            DepartmentRepository = new DepartmentRepository(dbContext);
        }
        public IEmployeeRepository EmployeeRepository { get ; set; }
        public IDepartmentRepository DepartmentRepository { get; set; }

        public int Complete()
        
           => _dbContext.SaveChanges();   
        
    }
}
