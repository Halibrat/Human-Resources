using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.DataAccess.Concrete.EntityFramework.Mappings
{
   public class PayrollMap:EntityTypeConfiguration<Payroll>
    {
        public PayrollMap()
        {
            ToTable(@"Payrolls", @"dbo");
            HasKey(p => p.Id);

            Property(p => p.GrossSalary).HasColumnName("GrossSalary");
            Property(p => p.LaborShare).HasColumnName("LaborShare");
            Property(p => p.UIShare).HasColumnName("UIShare");
            Property(p => p.IncomeTaxBase).HasColumnName("IncomeTaxBase");
            Property(p => p.IncomeTaxAmount).HasColumnName("IncomeTaxAmount");
            Property(p => p.StampDutAmount).HasColumnName("StampDutAmount");
            Property(p => p.SumOfDeductions).HasColumnName("SumOfDeductions");
            Property(p => p.NetWage).HasColumnName("NetWage");
            Property(p => p.EmployerShare).HasColumnName("EmployerShare");
            Property(p => p.UIEShare).HasColumnName("UIEShare");
        }
    }
}
