﻿using DevFramework.Core.DataAccess;
using HumanResourcesSystem.DataAccess.Concrete.EntityFramework;
using HumanResourcesSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.DataAccess.Abstract
{
   public interface IOrganizationDal:IEntityRepository<Organization>
    {
    }
}
