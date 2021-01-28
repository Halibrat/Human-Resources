using DevFramework.Core.DataAccess.EntityFramework;
using HumanResourcesSystem.DataAccess.Abstract;
using HumanResourcesSystem.Entities.ComplexType;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.DataAccess.Concrete.EntityFramework
{
   public class EfUserDal:EfEntityRepositoryBase<User,HumanResourcesContext>,IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (HumanResourcesContext context = new HumanResourcesContext ())
            {
                var result = from ur in context.UserRoles join r in context.Roles on ur.UserId equals user.Id   where ur.UserId == user.Id where user.RoleName==r.RoleName select new UserRoleItem { RoleName = r.RoleName };
                return result.ToList();
            }
        }
    }
}
