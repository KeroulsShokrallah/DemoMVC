using Demo.DataAcssesLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAcssesLayer.Repositorys
{
    public class EmployeeRepository(CompanyDbContext Context) 
        :BaseRepository<Employee>(Context), IEmployeeRepository
    {
        #region old implementation


        //private CompanyDbContext _DbContext = dbContext;
        //private DbSet<Employee> _employee = Context.Employees;

        //public employeeRepository(CompanyDbContext companyDbContext)
        //{
        //    _DbContext = companyDbContext;
        //}

        //public int Add(Employee employee)
        //{
        //    _employee.Add(employee);
        //    return Context.SaveChanges();
        //}

        //public int Delete(Employee employee)
        //{

        //    _employee.Remove(employee);
        //    return Context.SaveChanges();
        //}



        //public IEnumerable<Employee> GetAll(bool ChangeTranking = false)
        //{
        //    return ChangeTranking ? _employee.ToList() :
        //            _employee.AsNoTracking().ToList();
        //}

        //public Employee GetById(int id)
        //{
        //    return _employee.Find(id);
        //}

        //public int Update(Employee employee)
        //{
        //    _employee.Update(employee);
        //    return Context.SaveChanges();
        //}
        #endregion
    }
}
