using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Entities.Concrete
{
   public class JobPosting:IEntity
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }

    }
}
