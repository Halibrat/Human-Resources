using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.DataAccess.Concrete.EntityFramework.Mappings
{
   public class JobPostingMap:EntityTypeConfiguration<JobPosting>
    {
        public JobPostingMap()
        {
            ToTable(@"JobPostings", @"dbo");
            HasKey(jp => jp.Id);

            Property(jp => jp.Position).HasColumnName("Position");
            Property(jp => jp.Description).HasColumnName("Description");
            Property(jp => jp.CreatedTime).HasColumnName("CreatedTime");
        }
    }
}
