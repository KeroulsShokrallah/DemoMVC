using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAcssesLayer.Repositorys
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        #region old implementation

 
        //IEnumerable<Employee> GetAll(bool ChangeTranking = false);

        //Employee GetById(int id);
        //int Add(Employee employee);
        //int Update(Employee employee);
        //int Delete(Employee employee);
        #endregion
    }
}
