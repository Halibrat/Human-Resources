using DevFramework.Core.DataAccess.EntityFramework;
using HumanResourcesSystem.DataAccess.Abstract;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.DataAccess.Concrete.EntityFramework
{
  public  class EfTopOrganizationDal:EfEntityRepositoryBase<TopOrganization,HumanResourcesContext>,ITopOrganizationDal
    {
    }
}
