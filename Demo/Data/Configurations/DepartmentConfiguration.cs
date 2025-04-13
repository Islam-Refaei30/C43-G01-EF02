using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using EFCoreFluentApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.Configurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.DeptID);

            builder.Property(d => d.DeptID).UseIdentityColumn(10, 1);
            //-----------------
            builder
                .Property(d => d.Name).HasColumnName("DepartmentName")
                .HasColumnType("varchar")
                .IsRequired();
            //-----------------
            builder
                .Property(d => d.CreationDate)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
