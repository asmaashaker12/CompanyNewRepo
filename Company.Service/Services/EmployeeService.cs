using Company.Data.Models;
using Company.Repository.Interfaces;
using Company.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Service.Services.Employee
{
    public class EmployeeService : IEmployeeService
    {
        //public readonly IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
               // _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
        }
        public void Add(Data.Models.Employee employee)
        {
           _unitOfWork.EmployeeRepository.Add(employee);
            _unitOfWork.Complete();
        }

        public void Delete(Data.Models.Employee employee)
        {
            _unitOfWork.EmployeeRepository.Delete(employee);
            _unitOfWork.Complete();
        }

        public IEnumerable<Data.Models.Employee> GetAll()
        {
            return _unitOfWork.EmployeeRepository.GetAll();

        }
      public  IEnumerable<Data.Models.Employee> GetEmployeeByName(string searchtxt)
        =>_unitOfWork.EmployeeRepository.GetEmployeeByName(searchtxt);

        
        public Data.Models.Employee GetById(int? id)
        {
            return _unitOfWork.EmployeeRepository.GetById(id);
        }

        public void Update(Data.Models.Employee employee)
        {
            _unitOfWork.EmployeeRepository.Update(employee);
            _unitOfWork.Complete();
        }
    }
}
