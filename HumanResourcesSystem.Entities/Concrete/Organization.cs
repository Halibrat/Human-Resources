using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Entities.Concrete
{
    public class Organization:IEntity
    {
        public int Id { get; set; }
        public int TopOrganizationId { get; set; }
        public string OrganizationName { get; set; }
      


    }
}
