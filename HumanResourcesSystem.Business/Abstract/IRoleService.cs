using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Abstract
{
    interface IRoleService
    {
        void Add(Role role);
        void Delete(Role role);
        void Update(Role role);
        List<Role> GetAll();
        Role GetById(int id);
    }
}
