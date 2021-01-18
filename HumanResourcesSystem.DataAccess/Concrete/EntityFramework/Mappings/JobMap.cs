using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.DataAccess.Concrete.EntityFramework.Mappings
{
   public class JobMap:EntityTypeConfiguration<Job>
    {
        public JobMap()
        {
            ToTable(@"Jobs", @"dbo");
            HasKey(j => j.Id);

            Property(j => j.JobName).HasColumnName("JobName");
            Property(j => j.OrganizationName).HasColumnName("OrganizationName");
        }
    }
}
