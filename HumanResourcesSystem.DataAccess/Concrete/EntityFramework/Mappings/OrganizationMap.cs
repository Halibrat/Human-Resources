using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.DataAccess.Concrete.EntityFramework.Mappings
{
     public class OrganizationMap:EntityTypeConfiguration<Organization>
    {
        public OrganizationMap()
        {
            ToTable(@"Organizations", @"dbo");
            HasKey(o => o.Id);

            Property(o => o.OrganizationName).HasColumnName("OrganizationName");
            Property(o => o.TopOrganizationId).HasColumnName("TopOrganizationId");
        }
    }
}
