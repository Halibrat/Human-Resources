using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Abstract
{
   public interface IOrganizationService
    {
        void Add(Organization organization);
        void Delete(Organization organization);
        void Update(Organization organization);
        List<Organization> GetAll();
        Organization GetById(int id);
    }
}
