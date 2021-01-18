using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.DataAccess.Concrete.EntityFramework.Mappings
{
   public class TopOrganizationMap:EntityTypeConfiguration<TopOrganization>
    {
        public TopOrganizationMap()
        {
            ToTable(@"TopOrganizations", @"dbo");
            HasKey(t => t.Id);

            Property(t => t.TopOrganizationName).HasColumnName("TopOrganizationName");
        }
    }
}
