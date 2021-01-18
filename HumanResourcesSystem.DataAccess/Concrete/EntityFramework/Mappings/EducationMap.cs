using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.DataAccess.Concrete.EntityFramework.Mappings
{
   public class EducationMap:EntityTypeConfiguration<Education>
    {
        public EducationMap()
        {
            ToTable(@"Educations", @"dbo");
            HasKey(e => e.Id);

            Property(e => e.HighSchoolName).HasColumnName("HighSchoolName");
            Property(e => e.UniversityName).HasColumnName("UniversityName");
            Property(e => e.Section).HasColumnName("Section");
            Property(e => e.StartingDate).HasColumnName("StartingDate");
            Property(e => e.EndDate).HasColumnName("EndDate");
        }
    }
}
