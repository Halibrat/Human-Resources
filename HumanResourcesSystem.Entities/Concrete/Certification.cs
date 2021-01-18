using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Entities.Concrete
{
    public class Certification:IEntity
    {
        public int Id { get; set; }
        public string CertificateName { get; set; }
        public string CertificationInstitution { get; set; }
    }
}
