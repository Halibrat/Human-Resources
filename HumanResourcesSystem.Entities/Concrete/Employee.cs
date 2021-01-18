using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Entities.Concrete
{
   public class Employee:IEntity
    {
        public int Id { get; set; }
        public string TckNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SgkNo { get; set; }
        public DateTime InagurationDate { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckInOut { get; set; }
     

    }
}
