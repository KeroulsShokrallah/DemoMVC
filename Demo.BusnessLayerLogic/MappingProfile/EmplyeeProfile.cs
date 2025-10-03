using AutoMapper;
using Demo.BusnessLayerLogic.DataTransferObject.Employees;
using Demo.DataAcssesLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusnessLayerLogic.MappingProfile
{
    public class EmplyeeProfile:Profile
    {
        public EmplyeeProfile()
        {
            CreateMap<EmployeeRequest, Employee>();
            CreateMap<EmployeeUpdateRequest, Employee>();
            CreateMap<Employee, EmployeeDetailsResponse>();
            CreateMap<Employee, EmployeeResponse>();
            CreateMap<EmployeeDetailsResponse, EmployeeUpdateRequest>();
            CreateMap<EmployeeUpdateRequest, EmployeeRequest>();

        }
    }
}
