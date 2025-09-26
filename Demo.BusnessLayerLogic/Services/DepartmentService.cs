using Demo.BusnessLayerLogic.DataTransferObject.Departments;
using Demo.DataAcssesLayer.Entites;
using Demo.DataAcssesLayer.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusnessLayerLogic.Services
{
    public class DepartmentService(IRepository<Department> departmentRepositry) : IDepartmentService
    {
        public int Add(DepartmentRequest request)
        {
            var department = request.ToEntity();

            return departmentRepositry.Add(department);
        }

        public bool Delete(int id)
        {
            var department = departmentRepositry.GetById(id);
            if (department is null)
                return false;

            var result = departmentRepositry.Delete(department);
            return result > 0;
        }

        public IEnumerable<DepartmentResponse> GetAll()
        {
            return departmentRepositry.GetAll().Select(x => x.ToResponse());
        }

        public DepartmentDetailsResponse? GetById(int id)
        {
            return departmentRepositry.GetById(id).ToDetailsResponse();

        }

        public int Update(DepartmentUpdateRequest request)
        {
            return departmentRepositry.Update(request.ToEntity());
        }
    }
}
