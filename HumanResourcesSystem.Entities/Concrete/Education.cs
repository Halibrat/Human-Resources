using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Entities.Concrete
{
   public class Education:IEntity
    {
        public int Id { get; set; }
        public string HighSchoolName { get; set; }
        public string UniversityName { get; set; }
        public string Section { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
