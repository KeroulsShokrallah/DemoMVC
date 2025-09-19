
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAcssesLayer.Context
{
    public class CompanyDbContext(DbContextOptions<CompanyDbContext> options) : DbContext(options)
    {
        public DbSet<Department> Departmens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompanyDbContext).Assembly);
        }
    }
}
