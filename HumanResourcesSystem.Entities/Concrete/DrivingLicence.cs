﻿using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Entities.Concrete
{
   public class DrivingLicence:IEntity
    {
        public int Id { get; set; }
        public string LicenceType { get; set; }
    }
}
