using Demo.DataAcssesLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusnessLayerLogic.DataTransferObject
{
    internal static class DepartmentFactory
    {
        public static DepartmentResponse ToResponse(this Department department)
        {
            return new()
            {
                Id = department.Id,
                Name = department.Name,
                Descreption = department.Description,
                CreatedAt = department.CreatedAt,
                Code = department.Code
            };
        }
        public static DepartmentDetailsResponse ToDetailsResponse(this Department department)
        {
            return new() { 
            Id = department.Id,
            Name = department.Name,
            Description = department.Description,
            CreateBy = department.CreatedBy,
            CreateOn = department.CreateOn,
            IsDeleted = department.IsDeleted,
            Code = department.Code,
            LastModifyBy = department.LastModifyBy,
            LastModifyOn = department.LastModifyOn,
          CreatedAt = department.CreatedAt
            
            };

        }

        public static Department ToEntity(this DepartmentRequest departmentRequest)
        {
            return new()
            {
                Name = departmentRequest.Name,
                Description = departmentRequest.Description,
                Code = departmentRequest.Code,
                CreatedAt = departmentRequest.CreatedAt
            };

        }

        public static Department ToEntity(this DepartmentUpdateRequest departmentRequest)
        {
            return new()
            {
                Id = departmentRequest.Id,
                Name = departmentRequest.Name,
                Description = departmentRequest.Description,
                Code = departmentRequest.Code,
                CreatedAt = departmentRequest.CreatedAt
            };

        }

        public static DepartmentUpdateRequest ToUpdateRequest(this DepartmentDetailsResponse departmentRequest)
        {
            return new()
            {
                Id = departmentRequest.Id,
                Name = departmentRequest.Name,
                Description = departmentRequest.Description,
                Code = departmentRequest.Code,
                CreatedAt = departmentRequest.CreatedAt
            };
        }

        public static DepartmentRequest ToRequest(this DepartmentUpdateRequest departmentRequest)
        {
            return new()
            {
                
                Name = departmentRequest.Name,
                Description = departmentRequest.Description,
                Code = departmentRequest.Code,
                CreatedAt = departmentRequest.CreatedAt
            };

        }

    }
}
