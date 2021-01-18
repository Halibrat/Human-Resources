using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.DataAccess.Concrete.EntityFramework.Mappings
{
   public class DrivingLicenceMap:EntityTypeConfiguration<DrivingLicence>
    {
        public DrivingLicenceMap()
        {
            ToTable(@"DrivingLicenses", @"dbo");
            HasKey(dl => dl.Id);

            Property(dl => dl.LicenceType).HasColumnName("LicenceType");
        }
    }
}
