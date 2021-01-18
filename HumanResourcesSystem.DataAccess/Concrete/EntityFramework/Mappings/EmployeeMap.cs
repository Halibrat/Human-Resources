using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.DataAccess.Concrete.EntityFramework.Mappings
{
   public class EmployeeMap:EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            ToTable(@"Employees", @"dbo");
            HasKey(e => e.Id);

            Property(e => e.FirstName).HasColumnName("FirstName");
            Property(e => e.LastName).HasColumnName("LastName");
            Property(e => e.SgkNo).HasColumnName("SgkNo");
            Property(e => e.TckNo).HasColumnName("TckNo");
            Property(e => e.InagurationDate).HasColumnName("InagurationDate");
            Property(e => e.CheckInTime).HasColumnName("CheckInTime");
            Property(e => e.CheckInOut).HasColumnName("CheckInOut");


        }
    }
}
