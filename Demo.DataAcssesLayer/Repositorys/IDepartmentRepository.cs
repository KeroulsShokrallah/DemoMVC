using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAcssesLayer.Repositorys
{
    public interface IDepartmentRepository :IRepository<Department>
    {
        #region old implementation



        //IEnumerable<Department> GetAll(bool ChangeTranking = false);

        //Department GetById(int id);
        //int Add(Department department);
        //int Update(Department department);
        //int Delete(Department department);
        #endregion

       

    }
}
