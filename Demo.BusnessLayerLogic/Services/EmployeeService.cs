using AutoMapper;
using Demo.BusnessLayerLogic.DataTransferObject.Employees;
using Demo.DataAcssesLayer.Entites;
using Demo.DataAcssesLayer.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusnessLayerLogic.Services
{
    public class EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper) : IEmployeeService
    {
        public int Add(EmployeeRequest request)
        {
            var Employee = mapper.Map<EmployeeRequest, Employee>(request);

            return employeeRepository.Add(Employee);
        }

        public bool Delete(int id)
        {
            var employee = employeeRepository.GetById(id);
            if (employee is null)
                return false;

            var result = employeeRepository.Delete(employee);
            return result > 0;
        }

        public IEnumerable<EmployeeResponse> GetAll()
        {
            var employees = employeeRepository.GetAll();
            return mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeResponse>>(employees);
        }

        public EmployeeDetailsResponse? GetById(int id)
        {
            var employee = employeeRepository.GetById(id);
            return mapper.Map<Employee, EmployeeDetailsResponse?>(employee);

        }

        public int Update(EmployeeUpdateRequest request)
        {
            //      var employee = mapper.Map<EmployeeUpdateRequest, Employee>(request);
            //return employeeRepository.Update(employee);

            return employeeRepository.Update(mapper.Map<EmployeeUpdateRequest, Employee>(request));
        }

    }
}
