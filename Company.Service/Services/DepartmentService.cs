using AutoMapper;
using Company.Data.Models;
using Company.Data.ViewModels;
using Company.Repository.Interfaces;
using Company.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Service.Services
{
    public class DepartmentService : IDepartmentService
    {
        //public readonly IDepartmentRepository _departmentRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentService(IUnitOfWork unitOfWork,IMapper mapper)
        {
           // _departmentRepository = departmentRepository;
           _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(DepartmentViewModel departmentvm)
        {

            //Department department = new Department
            //{
            //    Name=departmentvm.Name,
            //    Code=departmentvm.Code,
            //    CreateAt=departmentvm.CreateAt,

            //};
            Department department = _mapper.Map<Department>(departmentvm);
           _unitOfWork.DepartmentRepository.Add(department);
            _unitOfWork.Complete();
        }   

        public void Delete(DepartmentViewModel departmentvm)
        {
            Department department = _mapper.Map<Department>(departmentvm);
            _unitOfWork.DepartmentRepository.Delete(department);
            _unitOfWork.Complete();
        }

        public IEnumerable<DepartmentViewModel> GetAll()
        {
            var departments= _unitOfWork.DepartmentRepository.GetAll();
            IEnumerable<DepartmentViewModel>mappedDepartments=_mapper.Map<IEnumerable<DepartmentViewModel>>(departments);
            return mappedDepartments;
        }

        public DepartmentViewModel GetById(int? id)

        {

            var departent = _unitOfWork.DepartmentRepository.GetById(id);
            DepartmentViewModel DepartmentViewModel = _mapper.Map<DepartmentViewModel>(departent);
            return DepartmentViewModel;

        }



        //public void Update(Data.Models.Department department)
        //{
        //    _unitOfWork.DepartmentRepository.Update(department);
        //    _unitOfWork.Complete();
        //}

        
    }
}
