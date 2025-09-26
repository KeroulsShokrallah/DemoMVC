using Demo.BusnessLayerLogic.DataTransferObject.Departments;
using Demo.BusnessLayerLogic.DataTransferObject.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusnessLayerLogic.Services
{
    public interface IEmployeeService
    {
        EmployeeDetailsResponse GetById(int id);
        IEnumerable<EmployeeResponse> GetAll();

        int Update(EmployeeUpdateRequest request);
        bool Delete(int id);
        int Add(EmployeeRequest request); 
    }
}
