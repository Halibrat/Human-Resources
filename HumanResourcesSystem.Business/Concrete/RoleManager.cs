using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using HumanResourcesSystem.Business.Abstract;
using HumanResourcesSystem.Business.ValidationRules.FluentValidation;
using HumanResourcesSystem.DataAccess.Abstract;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private IRoleDal _role;
        public RoleManager(IRoleDal role)
        {
            _role = role;
        }
        [FluentValidationAspect(typeof(RoleValidator))]
        public void Add(Role role)
        {
            _role.Add(role);
        }

        public void Delete(Role role)
        {
            _role.Delete(role);
        }

        public List<Role> GetAll()
        {
            return _role.GetList();
        }

        public Role GetById(int id)
        {
            return _role.Get(r => r.RoleId == id);
        }

        public void Update(Role role)
        {
            _role.Update(role);
        }
    }
}
