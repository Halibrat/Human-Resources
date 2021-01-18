using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.DataAccess.Concrete.EntityFramework.Mappings
{
   public class MaterialMap:EntityTypeConfiguration<Material>
    {
        public MaterialMap()
        {
            ToTable(@"Materials", @"dbo");
            HasKey(m => m.Id);

            Property(m => m.MaterialName).HasColumnName("MaterialName");
            Property(m => m.OrganizationName).HasColumnName("OrganizationName");
            Property(m => m.Quantity).HasColumnName("Quantity");
        }
    }
}
