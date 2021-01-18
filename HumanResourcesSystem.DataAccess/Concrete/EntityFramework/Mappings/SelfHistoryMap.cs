using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.DataAccess.Concrete.EntityFramework.Mappings
{
   public class SelfHistoryMap:EntityTypeConfiguration<SelfHistory>
    {
        public SelfHistoryMap()
        {
            ToTable(@"SelfHistories", @"dbo");
            HasKey(s => s.Id);

            Property(s => s.FirstName).HasColumnName("FirstName");
            Property(s => s.LastName).HasColumnName("LastName");
            Property(s => s.BirthPlace).HasColumnName("BirthPlace");
            Property(s => s.Phone).HasColumnName("Phone");
            Property(s => s.Email).HasColumnName("Email");
            Property(s => s.Photo).HasColumnName("Photo");



        }
    }
}
