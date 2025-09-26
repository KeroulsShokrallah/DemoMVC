using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAcssesLayer.Context.Configrations
{
    internal class EmployeeConfigrations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired();
            builder.Property(x => x.Email)
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired(false);
            builder.Property(x => x.PhoneNumber)
                .HasColumnType("char")
                .HasMaxLength(11)
                .IsRequired(false);
            builder.Property(x => x.Salary)
                .HasColumnType("decimal(10,2)")
                .IsRequired();
            builder.Property(x => x.Gender)
                .HasConversion(x => x.ToString(), s => Enum.Parse<Gender>(s));
            builder.Property(x => x.EmployeeType)
                .HasConversion(x => x.ToString(), s => Enum.Parse<EmployeeType>(s));
        }
    }
}
