using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Business.Abstract
{
   public interface ITopOrganizationService
    {
        void Add(TopOrganization topOrganization);
        void Delete(TopOrganization topOrganization);
        void Update(TopOrganization topOrganization);
        List<TopOrganization> GetAll();
        TopOrganization GetById(int id);
    }
}
