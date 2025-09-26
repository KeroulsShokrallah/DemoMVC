using Demo.BusnessLayerLogic.Services;
using Demo.DataAcssesLayer.Context;
using Demo.DataAcssesLayer.Entites;
using Demo.DataAcssesLayer.Repositorys;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Core;

namespace Demo.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
           builder.Services.AddScoped<IDepartmentService, DepartmentService>();
            //builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            //builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            //builder.Services.AddScoped<IRepository<Department>, BaseRepository<Department>>();
            builder.Services.AddScoped(typeof(IRepository<>) ,typeof(BaseRepository<>));


            //register auto mapper and add assembly from bussiness logic layer 
            builder.Services.AddAutoMapper(typeof(BusnessLayerLogic.AssemblyRefrences).Assembly);



            //builder.Services.AddScoped<CompanyDbContext>();
            //builder.Services.AddScoped<CompanyDbContext>(provider=>
            //{
            //    var builder = new DbContextOptionsBuilder<CompanyDbContext>();
            //    builder.UseSqlServer("");
            //    return new CompanyDbContext(builder.Options);
            //});

            builder.Services.AddDbContext<CompanyDbContext>(options =>
            {
                var connectinString = builder.Configuration.GetConnectionString("DefalutConnection");
                //var connectinString2 = builder.Configuration["ConnectionStrings: DefalutConnection"];
                //var connectinString3 = builder.Configuration.GetSection("ConnectionStrings")["DefalutConnection"];
                options.UseSqlServer(connectinString);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
