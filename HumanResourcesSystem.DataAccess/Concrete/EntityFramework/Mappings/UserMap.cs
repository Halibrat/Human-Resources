using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.DataAccess.Concrete.EntityFramework.Mappings
{
   public class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable(@"Users", @"dbo");
            HasKey(u => u.Id);

            Property(u => u.TckNo).HasColumnName("TckNo");
            Property(u => u.FirstName).HasColumnName("FirstName");
            Property(u => u.LastName).HasColumnName("LastName");
            Property(u => u.UserName).HasColumnName("UserName");
            Property(u => u.Password).HasColumnName("Password");
            Property(u => u.RoleName).HasColumnName("RoleName");
            Property(u => u.Email).HasColumnName("Email");
            Property(u => u.Photo).HasColumnName("Photo");
            Property(u => u.BirthDate).HasColumnName("BirthDate");
            Property(u => u.PhoneNumber).HasColumnName("PhoneNumber");
           


        }
    }
}
