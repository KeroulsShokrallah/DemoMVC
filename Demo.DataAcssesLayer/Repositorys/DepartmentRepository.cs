using Demo.DataAcssesLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAcssesLayer.Repositorys
{
    public class DepartmentRepository(CompanyDbContext dbContext) : IDepartmentRepository
    {
        private CompanyDbContext _DbContext = dbContext;
        private DbSet<Department> _department = dbContext.Departmens;

        //public DepartmentRepository(CompanyDbContext companyDbContext)
        //{
        //    _DbContext = companyDbContext;
        //}

        public int Add(Department department)
        {
            _department.Add(department);
            return _DbContext.SaveChanges();
        }

        public int Delete(Department department)
        {
            _department.Remove(department);
            return _DbContext.SaveChanges();
        }



        public IEnumerable<Department> GetAll(bool ChangeTranking = false)
        {
        return    ChangeTranking ? _department.ToList() : 
                _department.AsNoTracking().ToList();
        }

        public Department GetById(int id)
        {
            return _department.Find(id);
        }

        public int Update(Department department)
        {
            _department.Update(department);
            return _DbContext.SaveChanges();
        }
    }
}
