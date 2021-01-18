using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.DataAccess.Concrete.EntityFramework.Mappings
{
   public class UserRoleMap:EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            ToTable(@"UserRoles", @"dbo");
            HasKey(ur => ur.Id);
           
            Property(ur => ur.RoleId).HasColumnName("RoleId");
            Property(ur => ur.UserId).HasColumnName("UserId");
        }
    }
}
