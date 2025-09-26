using Demo.BusnessLayerLogic.DataTransferObject.Departments;
using Demo.DataAcssesLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusnessLayerLogic.Services
{
    public interface IDepartmentService
    {
        DepartmentDetailsResponse GetById(int  id); 
        IEnumerable<DepartmentResponse> GetAll();
        
        int Update(DepartmentUpdateRequest request);
        bool Delete(int id);
        int Add(DepartmentRequest request);



    }
}
