using Company.Data.Models;
using Company.Repository.Interfaces;
using Company.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Service.Services.Department
{
    public class DepartmentService : IDepartmentService
    {
        //public readonly IDepartmentRepository _departmentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DepartmentService(IUnitOfWork unitOfWork)
        {
           // _departmentRepository = departmentRepository;
           _unitOfWork = unitOfWork;
        }

        public void Add(Data.Models.Department department)
        {
           _unitOfWork.DepartmentRepository.Add(department);
            _unitOfWork.Complete();
        }

        public void Delete(Data.Models.Department department)
        {
            _unitOfWork.DepartmentRepository.Delete(department);
            _unitOfWork.Complete();
        }

        public IEnumerable<Data.Models.Department> GetAll()
        {
            return _unitOfWork.DepartmentRepository.GetAll();
        }

        public Data.Models.Department GetById(int? id)
        
           =>_unitOfWork.DepartmentRepository.GetById(id);
        

        public void Update(Data.Models.Department department)
        {
            _unitOfWork.DepartmentRepository.Update(department);
            _unitOfWork.Complete();
        }

        
    }
}
