using AutoMapper;
using Company.Data.Models;
using Company.Data.ViewModels;
using Company.Repository.Interfaces;
using Company.Service.Helper;
using Company.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        //public readonly IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeService(IUnitOfWork unitOfWork,IMapper mapper)
        {
               // _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void Add(EmployeeViewModel employeeVm)
        {
            //Employee employee = new Employee
            //{
            //    Name= employeeVm.Name,
            //    Address= employeeVm.Address,
            //    Age= employeeVm.Age,
            //    ImageUrl=DocumentSettings.UploadFile(employeeVm.Image,"Images"),
            //    CreateAt=employeeVm.CreateAt,
            //    PhonNumber= employeeVm.PhonNumber,
            //    HiringDate= employeeVm.HiringDate,
            //    Salary= employeeVm.Salary,
            //    DepartmentId= employeeVm.DepartmentId,
            //};
            employeeVm.ImageUrl = DocumentSettings.UploadFile(employeeVm.Image, "Images");
            Employee employee=_mapper.Map<Employee>(employeeVm);
           _unitOfWork.EmployeeRepository.Add(employee);
            _unitOfWork.Complete();
        }

        public void Delete(EmployeeViewModel employeeVm)
        {

            Employee employee = new Employee
            {
                Name = employeeVm.Name,
                Address = employeeVm.Address,
                Age = employeeVm.Age,
                ImageUrl = employeeVm.ImageUrl,
                CreateAt = employeeVm.CreateAt,
                PhonNumber = employeeVm.PhonNumber,
                HiringDate = employeeVm.HiringDate,
                Salary = employeeVm.Salary,
                DepartmentId = employeeVm.DepartmentId,
            };

            _unitOfWork.EmployeeRepository.Delete(employee);
            _unitOfWork.Complete();
        }

        public IEnumerable<EmployeeViewModel> GetAll()
        {
            var employeees = _unitOfWork.EmployeeRepository.GetAll();
            //var mappedEmployee = employeees.Select(x => new EmployeeViewModel
            //{
            //    Name= x.Name,
            //    Address= x.Address,
            //    Age= x.Age,
            //    ImageUrl= x.ImageUrl,
            //    CreateAt= x.CreateAt,
            //    PhonNumber = x.PhonNumber,
            //    HiringDate = x.HiringDate,
            //    Salary = x.Salary,
            //    DepartmentId = x.DepartmentId,

            //});
            IEnumerable<EmployeeViewModel> mappedEmployees = _mapper.Map<IEnumerable<EmployeeViewModel>>(employeees);
            return mappedEmployees;

        }
       public  IEnumerable<EmployeeViewModel> GetEmployeeByName(string searchtxt)
        {
          var employees=  _unitOfWork.EmployeeRepository.GetEmployeeByName(searchtxt);
            //var mappedEmployee = employees.Select(x => new EmployeeViewModel
            //{
            //    Name = x.Name,
            //    Address = x.Address,
            //    Age = x.Age,
            //    ImageUrl = x.ImageUrl,
            //    CreateAt = x.CreateAt,
            //    PhonNumber = x.PhonNumber,
            //    HiringDate = x.HiringDate,
            //    Salary = x.Salary,
            //    DepartmentId = x.DepartmentId,

            //});

           IEnumerable<EmployeeViewModel> mappedEmployees = _mapper.Map<IEnumerable<EmployeeViewModel>>(employees);

            return mappedEmployees;
        }

        
        public EmployeeViewModel GetById(int? id)
        {
            var employee= _unitOfWork.EmployeeRepository.GetById(id.Value);
            EmployeeViewModel employeeViewModel = new EmployeeViewModel
            {
                Name = employee.Name,
                Address = employee.Address,
                Age = employee.Age,
                ImageUrl = employee.ImageUrl,
                CreateAt = employee.CreateAt,
                PhonNumber = employee.PhonNumber,
                HiringDate = employee.HiringDate,
                Salary = employee.Salary,
                DepartmentId = employee.DepartmentId,
            };

            return employeeViewModel;
        }

        public void Update(EmployeeViewModel employee)
        {
            //_unitOfWork.EmployeeRepository.Update(employee);
            _unitOfWork.Complete();
        }
    }
}
