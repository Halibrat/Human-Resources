using HumanResourcesSystem.Entities.ComplexType;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Abstract
{
   public interface IUserService
    {
        void Add(User user);
        void Delete(User user);
        void Update(User user);
        List<User> GetAll();
        User GetById(int id);
        User GetByUserNameAndPassword(string userName, string password);
        User GetByUserRoleName(string roleName);
        List<UserRoleItem> GetUserRoles(User user);
    }
}
